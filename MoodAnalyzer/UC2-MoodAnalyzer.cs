public class UseCase2
{
    public string AnalyzeMood()
    {
        MoodAnalyzer analyzer = new MoodAnalyzer();
        return analyzer.AnalyzeMood();
    }
}