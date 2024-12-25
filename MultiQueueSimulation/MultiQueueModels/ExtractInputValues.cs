using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiQueueModels;
using MultiQueueSimulation;

namespace MultiQueueSimulation
{
    static public class ExtractInputValues
    {
        static private int dataIndx = 4;
        static public void FillData(SimulationSystem system, string fileContent)
        {
            string[][] separatedFileContent = InputParser.ParseFileContent(fileContent);

            system.NumberOfServers = Convert.ToInt32(separatedFileContent[1][0]);
            system.StoppingNumber = Convert.ToInt32(separatedFileContent[1][1]);
            system.StoppingCriteria = (Convert.ToInt32(separatedFileContent[1][2]) == 1) 
                ? Enums.StoppingCriteria.NumberOfCustomers 
                : Enums.StoppingCriteria.SimulationEndTime;
            system.SelectionMethod = (Convert.ToInt32(separatedFileContent[1][3]) == 1)
                ? Enums.SelectionMethod.HighestPriority
                : (Convert.ToInt32(separatedFileContent[1][3]) == 2)
                ? Enums.SelectionMethod.Random
                : Enums.SelectionMethod.LeastUtilization;

            system.InterarrivalDistribution = FillDistributionTable(separatedFileContent[1]);
            system.Servers = InitializeServers(system.NumberOfServers, separatedFileContent[1]);
        }

        static private List<TimeDistribution> FillDistributionTable(string[] data)
        {
            Decimal cummulativeProbabilty = 0;

            List<TimeDistribution> distributionTable = new List<TimeDistribution>();
            while(cummulativeProbabilty != 1)
            {
                TimeDistribution timeDistributionRow = new TimeDistribution();
                string[] probValues = InputParser.ParseProbValue(data[dataIndx]);

                if (Convert.ToDecimal(probValues[1]) == 0)
                {
                    dataIndx++;
                    continue;
                }

                int time = Convert.ToInt32(probValues[0]);
                Decimal probability = Convert.ToDecimal(probValues[1]);
                cummulativeProbabilty += probability;

                timeDistributionRow.Time = time;
                timeDistributionRow.Probability = probability;
                timeDistributionRow.CummProbability = cummulativeProbabilty;

                distributionTable.Add(timeDistributionRow);
                dataIndx++;
            }

            CalcRange(distributionTable);
            return distributionTable;
        }

        static private List<Server> InitializeServers(int numberOfServers, string[] data)
        {
            List<Server> servers = new List<Server>();
            int serverID = 1;

            for(int i = 0; i < numberOfServers; i++)
            {
                Server server = new Server();

                server.ID = serverID;
                server.TimeDistribution = FillDistributionTable(data);
                server.FinishTime = 0;

                servers.Add(server);
                serverID++;
            }
            dataIndx = 4;
            return servers;
        }

        static private void CalcRange(List<TimeDistribution> distributionTable)
        {
            distributionTable[0].MinRange = 1;
            distributionTable[0].MaxRange = Convert.ToInt32((distributionTable[0].CummProbability * 100));

            for(int i = 1; i < distributionTable.Count; i++)
            {
                distributionTable[i].MinRange = distributionTable[i - 1].MaxRange + 1;
                distributionTable[i].MaxRange = Convert.ToInt32((distributionTable[i].CummProbability * 100));

                //if (distributionTable[i].MaxRange < distributionTable[i].MinRange)
                //    distributionTable[i].MaxRange++;
            }
        }
    }
}