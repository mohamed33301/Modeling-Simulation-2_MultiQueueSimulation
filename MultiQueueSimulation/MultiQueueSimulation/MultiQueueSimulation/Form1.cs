using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stopping_criteria_cmb.Items.Add(Enums.StoppingCriteria.NumberOfCustomers);
            stopping_criteria_cmb.Items.Add(Enums.StoppingCriteria.SimulationEndTime);
        }

        private void generate_sim_table_btn_Click(object sender, EventArgs e)
        {
            SimulationSystemHandling simulationSystem = new SimulationSystemHandling();
            SimulationSystem system = new SimulationSystem
            {
                StoppingCriteria = (Enums.StoppingCriteria)stopping_criteria_cmb.SelectedItem,
                StoppingNumber = int.Parse(stopping_number_txt.Text),
                NumberOfServers = int.Parse(number_of_servers_txt.Text),
                SelectionMethod = Enums.SelectionMethod.HighestPriority,
                InterarrivalDistribution = simulationSystem.MakeTimeDistrubution(interarrival_dits_grid_view)
            };
            simulationSystem.CalculateCummProbabiltyAndRange(system.InterarrivalDistribution);
            simulationSystem.AddServers(server_dits_grid_view, dataGridView1, int.Parse(number_of_servers_txt.Text));
            system.Servers = simulationSystem.servers;
            switch (system.StoppingCriteria)
            {
                case Enums.StoppingCriteria.NumberOfCustomers:
                    {
                        simulationSystem.StopWhenNumberOfCustomers(system);

                        break;
                    }

                case Enums.StoppingCriteria.SimulationEndTime:
                    {
                        break;
                    }
            }
            var x = system.SimulationTable.Find((SimulationCase t) => t.RandomInterArrival < 0 || t.RandomInterArrival > 100);

            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
        }




    }
}
