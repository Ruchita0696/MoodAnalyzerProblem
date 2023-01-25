using MoodAnalyzerProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Sad_Return_Sad()
        {
            MoodAnalyzer mood = new MoodAnalyzer("I am in Sad Mood");
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Sad".ToUpper(), result);
        }
        [TestMethod]
        public void Given_Happy_Return_Happy()
        {
            MoodAnalyzer mood = new MoodAnalyzer("I am in Happy Mood");
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Happy".ToUpper(), result);
        }
    }


}