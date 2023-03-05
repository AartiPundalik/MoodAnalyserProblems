using MoodAnalyserProblems;
namespace TestCaseMoodAnalyser
{
    public class Tests
    {
        AbilityToAnalyze abilitytoAnalyze = new AbilityToAnalyze();

        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnsad()
        {

            string result = abilitytoAnalyze.AnalyseMood("I Am In sad Mood");
            Assert.AreEqual(result, "sad");
        }
    }
}