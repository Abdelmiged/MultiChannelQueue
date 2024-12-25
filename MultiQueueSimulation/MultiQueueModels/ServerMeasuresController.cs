using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    static public class ServerMeasuresController
    {
        static public void ProbabilityOfIdleServer(SimulationSystem system)
        {
            int simulationRuntime = GetSimulationRuntime(system);
            decimal[] serversServiceTime = new decimal[system.NumberOfServers];

            for(int i = 0; i < system.SimulationTable.Count; i++)
            {
                serversServiceTime[system.SimulationTable[i].AssignedServer.ID - 1] += system.SimulationTable[i].ServiceTime;
            }

            for(int i = 0; i < system.NumberOfServers; i++)
            {
                system.Servers[i].IdleProbability = (simulationRuntime - serversServiceTime[i]) / simulationRuntime;
            }
        }

        static public void AverageServiceTime(SimulationSystem system)
        {
            decimal[] serversServiceTime = new decimal[system.NumberOfServers];
            int[] customersPerServer = new int[system.NumberOfServers];

            for (int i = 0; i < system.SimulationTable.Count; i++)
            {
                serversServiceTime[system.SimulationTable[i].AssignedServer.ID - 1] += system.SimulationTable[i].ServiceTime;
                customersPerServer[system.SimulationTable[i].AssignedServer.ID - 1] += 1;
            }

            for(int i = 0; i < system.NumberOfServers; i++)
            {
                if(customersPerServer[i] == 0)
                {
                    system.Servers[i].AverageServiceTime = 0;
                    continue;
                }
                system.Servers[i].AverageServiceTime = serversServiceTime[i] / customersPerServer[i];
            }
        }

        static public void ServerUtilization(SimulationSystem system)
        {
            int simulationRuntime = GetSimulationRuntime(system);
            decimal[] serverServiceTime = new decimal[system.NumberOfServers];

            for(int i = 0; i < system.SimulationTable.Count; i++)
            {
                serverServiceTime[system.SimulationTable[i].AssignedServer.ID - 1] += system.SimulationTable[i].ServiceTime;
            }

            for(int i = 0; i < system.NumberOfServers; i++)
            {
                system.Servers[i].Utilization = serverServiceTime[i] / simulationRuntime;
            }
        }

        static private int GetSimulationRuntime(SimulationSystem system)
        {
            int simulationRuntime = 0;
            for(int i = system.SimulationTable.Count - 1; i >= 0; i--)
            {
                simulationRuntime = (simulationRuntime < system.SimulationTable[i].EndTime) ? system.SimulationTable[i].EndTime : simulationRuntime;
            }
            return simulationRuntime;
        }
    }
}
