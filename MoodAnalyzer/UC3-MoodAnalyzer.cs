public class UseCase3
{
    public string AnalyzeMood()
    {
        try
        {
            MoodAnalyzer analyzer = new MoodAnalyzer(null);
            return analyzer.AnalyzeMood();
        }
        catch (MoodAnalysisException ex)
        {
            return ex.Message;
        }
    }
}