namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to check Mood");
            string mood = Console.ReadLine();
            MoodAnalyzer analyzer = new MoodAnalyzer();
            analyzer.AnalyzeMood(mood);
        }
    }
}