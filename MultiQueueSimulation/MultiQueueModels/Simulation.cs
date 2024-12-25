using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiQueueModels;
using MultiQueueSimulation;

namespace MultiQueueSimulation
{
    public class Simulation
    {
        SimulationSystem system;
        private Random rand = new Random();

        public Simulation(SimulationSystem system)
        {
            this.system = system;
        }

        public void BeginSimulation()
        {
            int stoppingNumber = system.StoppingNumber;
            int custID = 1;
            int indx = 1;

            //List<SimulationCase> simulationCases = new List<SimulationCase>();

            SimulationCase firstCust = new SimulationCase();

            FillSimulationCaseRow(system.SimulationTable, firstCust, custID, indx, true);

            system.SimulationTable.Add(firstCust);
            custID++;
            stoppingNumber = (system.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers) 
                ? stoppingNumber - 1 
                : stoppingNumber - firstCust.EndTime;

            while (stoppingNumber > 0)
            {
                SimulationCase simulationCaseRow = new SimulationCase();

                FillSimulationCaseRow(system.SimulationTable, simulationCaseRow, custID, indx);
                stoppingNumber = (system.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
                    ? stoppingNumber - 1
                    : stoppingNumber - Math.Abs(simulationCaseRow.EndTime - system.SimulationTable[indx - 1].EndTime);

                system.SimulationTable.Add(simulationCaseRow);
                custID++;
                indx++;
            }

            //system.SimulationTable = simulationCases;
            CalcPerformanceMeasures();
            CalcServerPerformanceMeasures();
        }

        private void FillSimulationCaseRow(List<SimulationCase> cases, SimulationCase caseRow,int custID, int indx, bool firstCustomer = false)
        {
            caseRow.CustomerNumber = custID;
            caseRow.RandomInterArrival = GenerateRandomNumber();
            //caseRow.InterArrival = (firstCustomer) ? 1 : GetRandomValueTime(system.InterarrivalDistribution, caseRow.RandomInterArrival);
            if (!firstCustomer)
                caseRow.InterArrival = GetRandomValueTime(system.InterarrivalDistribution, caseRow.RandomInterArrival);
            caseRow.ArrivalTime = (firstCustomer) ? 0 : caseRow.InterArrival + cases[indx - 1].ArrivalTime;
            caseRow.RandomService = GenerateRandomNumber();
            caseRow.AssignedServer = SelectServer.GetServer(system, caseRow.ArrivalTime);
            caseRow.TimeInQueue = TimeInQueue(caseRow.AssignedServer, caseRow.ArrivalTime);
            caseRow.StartTime = caseRow.ArrivalTime + caseRow.TimeInQueue;
            caseRow.ServiceTime = GetRandomValueTime(caseRow.AssignedServer.TimeDistribution, caseRow.RandomService);
            caseRow.EndTime = caseRow.StartTime + caseRow.ServiceTime;
            caseRow.AssignedServerID = caseRow.AssignedServer.ID;
            SelectServer.CalcServerFinishTime(caseRow.AssignedServer, caseRow.StartTime, caseRow.ServiceTime);
        }

        private int GenerateRandomNumber()
        {
            return rand.Next(1, 101);
        }

        private int GetRandomValueTime(List<TimeDistribution> distributionTable, int randomValue)
        {
            for(int i = 0; i < distributionTable.Count; i++)
            {
                if (randomValue >= distributionTable[i].MinRange && randomValue <= distributionTable[i].MaxRange)
                    return (distributionTable[i].Probability == 0) ? 0 : distributionTable[i].Time;
            }
            return 0;
        }

        private int TimeInQueue(Server assignedServer, int arrivalTime)
        {
            return (assignedServer.FinishTime <= arrivalTime) ? 0 : assignedServer.FinishTime - arrivalTime;
        }

        private void CalcPerformanceMeasures()
        {
            system.PerformanceMeasures.AverageWaitingTime = PerformanceMeasuresController.AverageWaitingTime(system.SimulationTable);
            system.PerformanceMeasures.WaitingProbability = PerformanceMeasuresController.CustomerWaitProbability(system.SimulationTable);
            system.PerformanceMeasures.MaxQueueLength = PerformanceMeasuresController.MaxQueueLength(system.SimulationTable);
        }

        private void CalcServerPerformanceMeasures()
        {
            ServerMeasuresController.ProbabilityOfIdleServer(system);
            ServerMeasuresController.AverageServiceTime(system);
            ServerMeasuresController.ServerUtilization(system);
        }
    }
}