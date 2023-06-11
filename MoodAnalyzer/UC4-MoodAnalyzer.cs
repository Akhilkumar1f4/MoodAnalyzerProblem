// MoodAnalyzerFactory class for creating MoodAnalyzer objects using reflection
public  class  MoodAnalyzerFactory
{
    // Create MoodAnalyzer object using default constructor
    public  MoodAnalyzer CreateMoodAnalyzer()
    {
        try
        {
            Type type = typeof(MoodAnalyzer);
            return (MoodAnalyzer)Activator.CreateInstance(type);
        }
        catch (TypeLoadException)
        {
            throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "No such class found");
        }
    }

    // Create MoodAnalyzer object using parameterized constructor
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
public class UseCase4
{
    public  MoodAnalyzer CreateMoodAnalyzer()
    {
        MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
        return factory.CreateMoodAnalyzer();
    }
}
