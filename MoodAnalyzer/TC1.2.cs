class TestCase1_2
{
    public string Execute()
    {
        try
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            string mood = moodAnalyzer.AnalyzeMood();
            return mood;
        }
        catch (MoodAnalysisException ex)
        {
            return ex.Message;
        }
    }
}