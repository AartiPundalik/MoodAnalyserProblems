using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyserProblems.CustomeException;

namespace MoodAnalyserProblems
{
    public class AbilityToAnalyze
    {
        public AbilityToAnalyze()
        {

        }
                
        string message;
        public AbilityToAnalyze(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }

            }
            catch (NullReferenceException)
            {

                throw new CustomeException(CustomeExceptionType.NullMood, "Message Should not be null");

            }
        }
    } 
}
    


