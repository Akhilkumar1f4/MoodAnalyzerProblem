public class UseCase5
{
    public MoodAnalyzer CreateMoodAnalyzer(string message)
    {
        try
        {
            Type type = typeof(MoodAnalyzer);
            return (MoodAnalyzer)Activator.CreateInstance(type, message);
        }
        catch (TypeLoadException)
        {
            throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "No such class found");
        }
    }
}

