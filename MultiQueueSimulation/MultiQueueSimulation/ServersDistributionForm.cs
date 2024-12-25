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
    public partial class ServersDistributionForm : Form
    {
        List<Server> servers;
        int indx = 0;
        public ServersDistributionForm(List<Server> servers)
        {
            this.servers = servers;
            InitializeComponent();
        }

        private void ServersDistribution_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servers[indx].TimeDistribution;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            indx = (indx == 0) ? servers.Count - 1 : indx - 1;
            dataGridView1.DataSource = servers[indx].TimeDistribution;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            indx = (indx + 1) % servers.Count;
            dataGridView1.DataSource = servers[indx].TimeDistribution;
        }
    }
}
