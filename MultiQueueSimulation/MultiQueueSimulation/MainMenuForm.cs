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
using MultiQueueTesting;
using System.IO;

namespace MultiQueueSimulation
{
    public partial class MainMenuForm : Form
    {
        SimulationSystem system;
        public MainMenuForm(SimulationSystem system)
        {
            this.system = system;
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string textFile = openFileDialog.FileName;
            string textFileContent = File.ReadAllText(textFile);
            SystemNotificationLabelController("");

            ExtractInputValues.FillData(system, textFileContent);

            DisplayData();
        }

        private void DisplayData()
        {
            numberOfServersLabel.Text = system.NumberOfServers.ToString();
            stoppingNumberLabel.Text = system.StoppingNumber.ToString();
            stoppingCriteriaLabel.Text = system.StoppingCriteria.ToString();
            selectionMethodLabel.Text = system.SelectionMethod.ToString();
        }

        private void interarrivalDistributionButton_Click(object sender, EventArgs e)
        {
            if (system.InterarrivalDistribution.Count != 0)
            {
                InterarrivalDistributionForm interarrivalDistributionForm = new InterarrivalDistributionForm(system.InterarrivalDistribution);
                SystemNotificationLabelController("");
                interarrivalDistributionForm.Show();
            }
            else
                SystemNotificationLabelController("Please choose a text file!");
        }

        private void serversDistributionButton_Click(object sender, EventArgs e)
        {
            if (system.Servers.Count != 0)
            {
                ServersDistributionForm serversDistributionForm = new ServersDistributionForm(system.Servers);
                SystemNotificationLabelController("");
                serversDistributionForm.Show();
            }
            else
                SystemNotificationLabelController("Please choose a text file!");
        }

        private void beginSimulationButton_Click(object sender, EventArgs e)
        {
            Simulation simulator = new Simulation(system);
            if (system.InterarrivalDistribution.Count != 0)
            {
                simulator.BeginSimulation();
                SystemNotificationLabelController("Simulation Done!", "green");
            }
            else
                SystemNotificationLabelController("Please choose a text file!");
        }

        private void simulationTableButton_Click(object sender, EventArgs e)
        {
            if (system.SimulationTable.Count != 0)
            {
                SimulationTableForm simulationTableForm = new SimulationTableForm(system.SimulationTable);
                SystemNotificationLabelController("");
                simulationTableForm.Show();
            }
            else
                SystemNotificationLabelController("Please begin simulation first!");
        }

        private void performanceMeasuresButton_Click(object sender, EventArgs e)
        {
            if (system.SimulationTable.Count != 0)
            {
                PerformanceMeasuresForm performanceMeasuresForm = new PerformanceMeasuresForm(system);
                SystemNotificationLabelController("");
                performanceMeasuresForm.Show();
            }
            else
                SystemNotificationLabelController("Please begin simulation first!");
        }

        private void SystemNotificationLabelController(string message, string color = "red")
        {
            if (color.ToLower() == "red")
            {
                systemNotificationLabel.ForeColor = Color.Red;
                systemNotificationLabel.Text = message;
            }
            else if(color.ToLower() == "green")
            {
                systemNotificationLabel.ForeColor = Color.Green;
                systemNotificationLabel.Text = message;
            }
        }
    }
}