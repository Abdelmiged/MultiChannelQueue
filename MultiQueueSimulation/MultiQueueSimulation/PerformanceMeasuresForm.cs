using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;

namespace MultiQueueSimulation
{
    public partial class PerformanceMeasuresForm : Form
    {
        SimulationSystem system;
        int indx = 0;
        public PerformanceMeasuresForm(SimulationSystem system)
        {
            this.system = system;
            InitializeComponent();
        }

        private void PerformanceMeasures_Load(object sender, EventArgs e)
        {
            averageWaitingTimeLabel.Text = system.PerformanceMeasures.AverageWaitingTime.ToString();
            probabilityCustomerInQueueLabel.Text = system.PerformanceMeasures.WaitingProbability.ToString();
            maximumQueueLengthLabel.Text = system.PerformanceMeasures.MaxQueueLength.ToString();

            DisplayServerMeasures(indx);
        }

        private void previousServerButton_Click(object sender, EventArgs e)
        {
            indx = (indx == 0) ? system.Servers.Count - 1 : indx - 1;
            DisplayServerMeasures(indx);
        }

        private void nextServerButton_Click(object sender, EventArgs e)
        {
            indx = (indx + 1) % system.Servers.Count;
            DisplayServerMeasures(indx);
        }

        private void DisplayServerMeasures(int indx)
        {
            idleProbabilityLabel.Text = system.Servers[indx].IdleProbability.ToString();
            averageServiceTimeLabel.Text = system.Servers[indx].AverageServiceTime.ToString();
            utilizationLabel.Text = system.Servers[indx].Utilization.ToString();
            serverIdLabel.Text = $"Server ID: {system.Servers[indx].ID}";
        }
    }
}
