using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string message)
        {
            bool result1 = message.Contains("Happy", StringComparison.OrdinalIgnoreCase);

            if (result1)
            {
                return "HAPPY";
            }
            bool result2 = message.Contains("Sad", StringComparison.OrdinalIgnoreCase);
             if (result2)
            {
                return "SAD";

            }
            return "HAPPY";
        }
    }
}
