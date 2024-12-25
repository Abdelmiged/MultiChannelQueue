using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    static public class PerformanceMeasuresController
    {
        static public Decimal AverageWaitingTime(List<SimulationCase> simulationTable)
        {
            Decimal totalTime = 0;
            for (int i = 0; i < simulationTable.Count; i++)
            {
                totalTime += simulationTable[i].TimeInQueue;
            }
            return totalTime / simulationTable.Count;
        }

        static public Decimal CustomerWaitProbability(List<SimulationCase> simulationTable)
        {
            Decimal waitingCustomers = 0;
            for (int i = 0; i < simulationTable.Count; i++)
            {
                if (simulationTable[i].TimeInQueue > 0)
                    waitingCustomers++;
            }
            return waitingCustomers / simulationTable.Count;
        }

        static public int MaxQueueLength(List<SimulationCase> simulationTable)
        {
            List<int> customersQueue = new List<int>();
            int maxQueueLength = 0;

            for(int i = 0; i < simulationTable.Count; i++)
            {
                if(simulationTable[i].TimeInQueue > 0 && customersQueue.Count == 0)
                {
                    customersQueue.Add(simulationTable[i].StartTime);
                }
                else if(simulationTable[i].TimeInQueue > 0 && customersQueue.Count > 0)
                {
                    CheckQueueDeparture(customersQueue, simulationTable[i].ArrivalTime);
                    customersQueue.Add(simulationTable[i].StartTime);
                }

                maxQueueLength = (maxQueueLength < customersQueue.Count) ? customersQueue.Count : maxQueueLength;
            }
            return maxQueueLength;
        }

        static private void CheckQueueDeparture(List<int> customersQueue, int customerArrivalTime)
        {
            for(int i = 0; i < customersQueue.Count; i++)
            {
                if (customersQueue[i] <= customerArrivalTime)
                    customersQueue.RemoveAt(i);
            }
        }
    }
}
