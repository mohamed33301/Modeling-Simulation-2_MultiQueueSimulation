using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    internal class SimulationSystemHandling
    {
        public SimulationSystemHandling() {

            this.servers = new List<Server>();
                
                }
        public List<Server> servers { get; }
       
        public List<TimeDistribution> MakeTimeDistrubution(DataGridView dataGridView)
        {
            List<TimeDistribution> timeDistributions = new List<TimeDistribution>();
            for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
            {
                TimeDistribution time = new TimeDistribution();
                if (dataGridView.Rows[rows].Cells[0].Value == null) break;
                time.Time = int.Parse(dataGridView.Rows[rows].Cells[0].Value.ToString());
                time.Probability = decimal.Parse(dataGridView.Rows[rows].Cells[1].Value.ToString());
                timeDistributions.Add(time);

            }
            return timeDistributions;
        }
        public void AddServers(DataGridView server_dits_grid_view,DataGridView dataGridView1, int serversNumber)
        {
            List<DataGridView> distrbutions = new List<DataGridView>();
            distrbutions.Add(server_dits_grid_view);
            distrbutions.Add(dataGridView1);
            for (int i = 0; i < serversNumber; i++)
            {
                Server server = new Server
                {
                    ID = i + 1,
                    FinishTime = 0,
                    TimeDistribution = MakeTimeDistrubution(distrbutions[i]),
                };

                CalculateCummProbabiltyAndRange(server.TimeDistribution);
                servers.Add(server);
            }


        }
        public void CalculateCummProbabiltyAndRange(List<TimeDistribution> list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    list[i].CummProbability = list[i].Probability;
                    list[i].MinRange = 1;
                    list[i].MaxRange = (int)(list[i].Probability * 100);
                }
                else
                {
                    list[i].CummProbability = list[i - 1].CummProbability + list[i].Probability;
                    list[i].MinRange = list[i - 1].MaxRange + 1;
                    list[i].MaxRange = (int)(list[i].CummProbability * 100);

                }

            }
        }

        private int GetArivalOrServiceTime(List<TimeDistribution> list, int value)
        {
            foreach (TimeDistribution t in list)
            {
                if (value >= t.MinRange && value <= t.MaxRange)
                {
                    Debug.WriteLine(t.Time);
                    return t.Time;
                }

            }

            return 0;
        }

        private List<int> CheckOnEmptyServers(int time)
        {
            List<int> emptyServers = new List<int>();
            for (int i = 0; i < servers.Count; i++)
            {
                // return the list of the non busy servers at some point of time
                if (servers[i].FinishTime <= time) emptyServers.Add(i);

            }

            return emptyServers;
        }

        private int GetNearsetServer()
        {
            int minFinishTime = int.MaxValue;
            int minFinishTimeIndex = -1;

            for (int i = 0; i < servers.Count; i++)
            {
                int finishTime = servers[i].FinishTime;
                if (finishTime < minFinishTime)
                {
                    minFinishTime = finishTime;
                    minFinishTimeIndex = i;
                }
            }

            return minFinishTimeIndex;
        }
        private int AssignServerToClient(SimulationCase client, Enums.SelectionMethod selectionMethod)
        {

            int serverIndex;
            List<int> emptyServers = CheckOnEmptyServers(client.ArrivalTime);
            if (emptyServers.Count == 0)
            {
                client.AssignedServer = servers[GetNearsetServer()];
                return -1;
            }
            else
            {
                if (selectionMethod == Enums.SelectionMethod.HighestPriority)
                {
                    serverIndex = emptyServers.First();
                }
                else if (selectionMethod == Enums.SelectionMethod.Random)
                {

                    serverIndex = new Random().Next(emptyServers.Count);
                }
                else
                {
                    // using leatest utilization
                    serverIndex = 0;
                }
                client.AssignedServer = servers[serverIndex];
                return 0;
            }


            // if [serverIndex] = -1 add customer to qeuee
            // client.AssignedServer = servers[serverIndex];
        }

        public void StopWhenNumberOfCustomers(SimulationSystem system)
        {

            List<int> queue = new List<int>();
            for (int i = 0; i < system.StoppingNumber; i++)
            {
                queue.Add(0);
                SimulationCase simulationCase = new SimulationCase();
                if (i == 0)
                {
                    simulationCase.CustomerNumber = 1;
                    simulationCase.RandomInterArrival = 1;
                    simulationCase.InterArrival = 0;
                    simulationCase.ArrivalTime = 0;
                    AssignServerToClient(simulationCase, Enums.SelectionMethod.HighestPriority);
                    simulationCase.RandomService = new Random().Next(1,101);
                    simulationCase.ServiceTime = GetArivalOrServiceTime(simulationCase.AssignedServer.TimeDistribution, simulationCase.RandomService);
                 
                    simulationCase.StartTime = 0;
                    simulationCase.EndTime = simulationCase.ServiceTime;
                    simulationCase.AssignedServer.FinishTime = simulationCase.EndTime;

                }
                else
                {
                    simulationCase.CustomerNumber = i+1;
                    simulationCase.RandomInterArrival = new Random().Next(1, 101);
                    simulationCase.InterArrival = GetArivalOrServiceTime(system.InterarrivalDistribution, simulationCase.RandomInterArrival);
                    simulationCase.ArrivalTime = simulationCase.InterArrival + system.SimulationTable[i - 1].ArrivalTime;
                    simulationCase.RandomService = new Random().Next(1, 101);
                    int y = AssignServerToClient(simulationCase, Enums.SelectionMethod.HighestPriority);
                    if (y != 0)
                    {
                        if (queue[i - 1] != 0) queue[i] = queue[i - 1] + 1;
                    }
                    simulationCase.ServiceTime = GetArivalOrServiceTime(simulationCase.AssignedServer.TimeDistribution, simulationCase.RandomService);
                   // MessageBox.Show("server number " + simulationCase.AssignedServer.ID + "\n Random Service "+ simulationCase.RandomService + "\n Service Time "+ simulationCase.ServiceTime);
                    simulationCase.TimeInQueue = queue[i];
                   
                    simulationCase.StartTime = simulationCase.ArrivalTime > simulationCase.AssignedServer.FinishTime ? simulationCase.ArrivalTime : simulationCase.AssignedServer.FinishTime;
                   
                    simulationCase.EndTime = simulationCase.ServiceTime + simulationCase.StartTime;
                    simulationCase.AssignedServer.FinishTime = simulationCase.EndTime;

                }
                system.SimulationTable.Add(simulationCase);
            }




















            /* List<int> queue = new List<int>();
             for (int i = 0; i < system.StoppingNumber; i++)
             {
                 queue.Add(0);
                 SimulationCase simulationCase = new SimulationCase();
                 if (i == 0)
                 {

                     simulationCase.CustomerNumber = 1;
                     simulationCase.RandomInterArrival = 1;
                     simulationCase.InterArrival = 0;
                     simulationCase.ArrivalTime = 0;
                     simulationCase.AssignedServer = system.Servers[0];
                     simulationCase.RandomService = new Random().Next(101);
                     simulationCase.ServiceTime = GetArivalOrServiceTime(simulationCase.AssignedServer.TimeDistribution, simulationCase.RandomService);
                     simulationCase.StartTime = 0;
                     simulationCase.EndTime = simulationCase.ServiceTime;
                     simulationCase.AssignedServer.FinishTime = simulationCase.EndTime;



                 }
                 else
                 {
                     simulationCase.CustomerNumber = i;
                     simulationCase.RandomInterArrival = new Random().Next(101);
                     simulationCase.InterArrival = GetArivalOrServiceTime(system.InterarrivalDistribution, simulationCase.RandomInterArrival);
                     simulationCase.ArrivalTime = simulationCase.InterArrival + system.SimulationTable[i - 1].ArrivalTime;
                     simulationCase.RandomService = new Random().Next(101);
                     // handle this cases as it is not the best
                     if (simulationCase.ArrivalTime < system.Servers[0].FinishTime && simulationCase.ArrivalTime < system.Servers[1].FinishTime)
                     {
                         if (queue[i - 1] != 0)
                         {
                             queue[i] = queue[i - 1] + 1;
                         }

                         if (system.Servers[0].FinishTime <= system.Servers[1].FinishTime)
                         {
                             simulationCase.AssignedServer = system.Servers[0];
                             simulationCase.StartTime = simulationCase.AssignedServer.FinishTime;
                         }
                         else
                         {
                             simulationCase.AssignedServer = system.Servers[1];
                             simulationCase.StartTime = simulationCase.AssignedServer.FinishTime;
                         }
                     }
                     else if (simulationCase.ArrivalTime < system.SimulationTable[i - 1].AssignedServer.FinishTime)
                     {
                         simulationCase.StartTime = simulationCase.ArrivalTime;
                         var x = system.SimulationTable[i - 1].AssignedServer.ID == 1;
                         if (x)
                         {
                             simulationCase.AssignedServer = system.Servers[1];
                         }
                         else
                         {
                             simulationCase.AssignedServer = system.Servers[0];
                         }


                     }
                     else if (simulationCase.ArrivalTime >= system.SimulationTable[i - 1].AssignedServer.FinishTime)
                     {
                         simulationCase.StartTime = simulationCase.ArrivalTime;
                         simulationCase.AssignedServer = system.Servers[0];
                     }
                     simulationCase.TimeInQueue = queue[i];
                     simulationCase.ServiceTime = GetArivalOrServiceTime(simulationCase.AssignedServer.TimeDistribution, simulationCase.RandomService);
                     simulationCase.EndTime = simulationCase.ServiceTime + simulationCase.StartTime;
                     simulationCase.AssignedServer.FinishTime = simulationCase.EndTime;

                 }
                 system.SimulationTable.Add(simulationCase);
             }*/

        }
    }
}
