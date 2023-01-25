using MoodAnalyzerProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_HappyOrSad_Return_HappyOrSad()
        {
            MoodAnalyzer mood = new MoodAnalyzer();
            string result = mood.AnalyzeMood("Happy");

            Assert.AreEqual("Happy".ToUpper(), result);
        }
        [TestMethod]
        public void Given_Sad_Return_Sad()
        {
            MoodAnalyzer mood = new MoodAnalyzer();
            string result = mood.AnalyzeMood("I am in Sad Mood");

            Assert.AreEqual("Sad".ToUpper(), result);
        }
        [TestMethod]
        public void Given_Any_Return_Sad()
        {
            MoodAnalyzer mood = new MoodAnalyzer();
            string result = mood.AnalyzeMood("I am in Any Mood");

            Assert.AreEqual("Happy".ToUpper(), result);
        }
    }


}