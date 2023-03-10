using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblems
{
    public class CustomeException:Exception
    {
        public enum CustomeExceptionType
        {
            NullMood,
            EmptyMood
        }
        public CustomeExceptionType Type;
        public CustomeException(CustomeExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }

}
    

