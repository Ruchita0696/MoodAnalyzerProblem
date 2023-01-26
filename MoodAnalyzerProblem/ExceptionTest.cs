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
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EcxeptionTest"/> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public ExceptionTest(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
