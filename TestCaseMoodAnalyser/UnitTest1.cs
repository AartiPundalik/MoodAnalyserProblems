using MoodAnalyserProblems;
namespace TestCaseMoodAnalyser
{
    public class Tests
    {
        
        [Test]
        public void SadMood_WhenAnalyse_ShouldReturnsad()
        {
            AbilityToAnalyze abilitytoAnalyse = new AbilityToAnalyze("I am in sad mood");
            string result = abilitytoAnalyse.AnalyseMood();
            Assert.AreEqual(result, "sad");
        }
        [Test]
        public void HappyMood_WhenAnalyse_ShouldReturnhappy()
        {
            AbilityToAnalyze abilitytoAnalyse = new AbilityToAnalyze("I am in happy mood");
            string result = abilitytoAnalyse.AnalyseMood();
            Assert.AreEqual(result, "happy");
        }
    }
}

    
