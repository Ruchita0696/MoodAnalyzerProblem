using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class ExceptionTest : Exception
    {
        private readonly ExceptionType type;
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
        }
        public ExceptionTest(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
