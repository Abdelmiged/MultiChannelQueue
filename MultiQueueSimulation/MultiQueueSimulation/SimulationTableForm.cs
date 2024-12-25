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
    public partial class SimulationTableForm : Form
    {
        List<SimulationCase> simulationCases;
        public SimulationTableForm(List<SimulationCase> simulationCases)
        {
            this.simulationCases = simulationCases;
            InitializeComponent();
        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = simulationCases;
        }
    }
}
