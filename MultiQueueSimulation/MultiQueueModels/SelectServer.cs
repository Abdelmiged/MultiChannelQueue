using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiQueueModels;
using MultiQueueSimulation;

namespace MultiQueueSimulation
{
    static public class SelectServer
    {
        static private Random rand = new Random();
        static public Server GetServer(SimulationSystem system, int arrivalTime)
        {
            Server currentServer = new Server();
            if (system.SelectionMethod == Enums.SelectionMethod.HighestPriority)
                currentServer = HighestPriority(system, arrivalTime);
            //else if (selectionMethod == Enums.SelectionMethod.Random)
            //    currentServer = Random(servers, arrivalTime);
            else if (system.SelectionMethod == Enums.SelectionMethod.LeastUtilization)
            {
                if (system.SimulationTable.Count == 0)
                    currentServer = system.Servers[0];
                else
                    currentServer = LeastUtilization(system, arrivalTime);

            }

            return currentServer;
        }

        static private Server HighestPriority(SimulationSystem system, int arrivalTime)
        {
            Server currentServer = system.Servers[0];

            for(int i = 1; i < system.Servers.Count; i++)
            {
                if(currentServer.FinishTime > arrivalTime && system.Servers[i].FinishTime > arrivalTime)
                {
                    if (system.Servers[i].FinishTime - arrivalTime < currentServer.FinishTime - arrivalTime)
                        currentServer = system.Servers[i];
                }
                else if(currentServer.FinishTime > arrivalTime && system.Servers[i].FinishTime <= arrivalTime)
                {
                    currentServer = system.Servers[i];
                }
            }

            return currentServer;
        }

        //static private Server Random(SimulationSystem system, int arrivalTime)
        //{
        //    List<Server> availableServers = new List<Server>();
        //    for(int i = 0; i < servers.Count; i++)
        //    {
        //        if(servers[i].FinishTime <= arrivalTime)
        //        {
        //            availableServers.Add(servers[i]);
        //        }
        //    }

        //    if (availableServers.Count == 0)
        //    {
        //        Server currentServer = servers[rand.Next(0, servers.Count)];

        //        for (int i = 1; i < servers.Count; i++)
        //        {
        //            if (currentServer.FinishTime > arrivalTime && servers[i].FinishTime > arrivalTime)
        //            {
        //                if (servers[i].FinishTime - arrivalTime < currentServer.FinishTime - arrivalTime)
        //                    currentServer = servers[i];
        //            }
        //            else if (currentServer.FinishTime > arrivalTime && servers[i].FinishTime <= arrivalTime)
        //            {
        //                currentServer = servers[i];
        //            }
        //        }
        //        return currentServer;
        //    }

        //    return availableServers[rand.Next(0, availableServers.Count)];
        //}

        static private Server LeastUtilization(SimulationSystem system, int arrivalTime)
        {
            ServerMeasuresController.ServerUtilization(system);

            Server currentServer = system.Servers[0];

            for(int i = 1; i < system.Servers.Count; i++)
            {
                if (system.Servers[i].Utilization <= currentServer.Utilization)
                {
                    if (currentServer.FinishTime > arrivalTime && system.Servers[i].FinishTime > arrivalTime)
                    {
                        if (system.Servers[i].FinishTime - arrivalTime < currentServer.FinishTime - arrivalTime)
                            currentServer = system.Servers[i];
                    }
                    else if (currentServer.FinishTime > arrivalTime && system.Servers[i].FinishTime <= arrivalTime)
                    {
                        currentServer = system.Servers[i];
                    }
                }
                else
                {

                    if (currentServer.FinishTime > arrivalTime && system.Servers[i].FinishTime > arrivalTime)
                    {
                        if (system.Servers[i].FinishTime - arrivalTime < currentServer.FinishTime - arrivalTime)
                            currentServer = system.Servers[i];
                    }
                    else if (currentServer.FinishTime > arrivalTime && system.Servers[i].FinishTime <= arrivalTime)
                    {
                        currentServer = system.Servers[i];
                    }
                }
            }
            return currentServer;
        }

        static public void CalcServerFinishTime(Server server, int beginTime, int serviceTime)
        {
            server.FinishTime = beginTime + serviceTime;
        }
    }
}
