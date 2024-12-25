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
    public partial class InterarrivalDistributionForm : Form
    {
        List<TimeDistribution> dataTable;
        public InterarrivalDistributionForm(List<TimeDistribution> dataTable)
        {
            this.dataTable = dataTable;
            InitializeComponent();
        }

        private void InterarrivalDistribution_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataTable;
        }
    }
}
