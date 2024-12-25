using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MultiQueueSimulation
{
    static public class InputParser
    {

        static public string[][] ParseFileContent(string fileContent)
        {
            string[] words = ParseWords(fileContent); // Values not used for now
            string[] numbers = ParseNumbers(fileContent);

            string[][] separatedFileContent = {words, numbers};

            return separatedFileContent;
        }

        static private string[] ParseWords(string fileContent)
        {
            Regex regexPatternWords = new Regex(@"(_*([a-zA-Z]+)_*[0-9]*)+");
            MatchCollection wordMatches = regexPatternWords.Matches(fileContent);
            return wordMatches.Cast<Match>().Select(m => m.Value).ToArray();
        }

        static private string[] ParseNumbers(string fileContent)
        {
            Regex regexPatternNumbers = new Regex(@"(((\d+,\s+\d+\.\d+)|(\d+,\s+\d+))|((?<!\w+)(\d+)))");
            MatchCollection numberMatches = regexPatternNumbers.Matches(fileContent);
            return numberMatches.Cast<Match>().Select(m => m.Value).ToArray();
        }

        static public string[] ParseProbValue(string value)
        {
            Regex regexPatternProbValue = new Regex(@"((\d+(?!\.))|(\d+\.\d+))");
            MatchCollection probValue = regexPatternProbValue.Matches(value);
            return probValue.Cast<Match>().Select(m => m.Value).ToArray();
        }
    }
}