using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblems
{
    public class Reflection
    {
        public static object MoodAnalyzer(string className, string constructorName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type moodAnalyserType = assembly.GetType(className);
            return Activator.CreateInstance(moodAnalyserType);
        }
    }
}

