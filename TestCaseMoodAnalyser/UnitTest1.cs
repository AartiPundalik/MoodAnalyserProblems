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

        [Test]
        public void NullMood_WhenAnalyzed_ShouldReturnhappy()
        {

            try
            {
                AbilityToAnalyze abilitytoAnalyse = new AbilityToAnalyze(null);
                string result = abilitytoAnalyse.AnalyseMood();
            }
            catch (CustomeException obj)
            {
                Assert.AreEqual("Message Should not be null", obj.Message);
            }
        }
        [Test]
        public void GivenEmptyMood_ThrowMoodAnalysisException_EmptyMessage()
        {
            AbilityToAnalyze moodAnalyzer = new AbilityToAnalyze("");
            try
            {
                string result = moodAnalyzer.AnalyseMood();
            }
            catch (CustomeException obj)
            {
                Assert.AreEqual("Message should not be null", obj.Message);
            }
        }
    }
    }

   
    



    


    
