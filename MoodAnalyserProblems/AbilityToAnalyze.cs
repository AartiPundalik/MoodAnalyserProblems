using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblems
{
    public class AbilityToAnalyze
    {
        string message;
        public AbilityToAnalyze(string message)
        {
            this.message = message;
        }
       
        public string AnalyseMood()
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
    }
}



