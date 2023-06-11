// Use case 7: Modify mood dynamically using reflection
public class UseCase7
{
    public string ModifyMoodDynamically(string message)
    {
        MoodAnalyzer analyzer = new MoodAnalyzer();
        MoodAnalyzerReflector.SetFieldValue("message", analyzer, message);
        return analyzer.AnalyzeMood();
    }
}


// MoodAnalyzerReflector class for reflection operations on MoodAnalyzer class
public class MoodAnalyzerReflector1
{
    // Invoke a method on the MoodAnalyzer object
    public static string InvokeMethod(string methodName, MoodAnalyzer moodAnalyzer)
    {
        try
        {
            Type type = typeof(MoodAnalyzer);
            var methodInfo = type.GetMethod(methodName);
            return (string)methodInfo.Invoke(moodAnalyzer, null);
        }
        catch (NullReferenceException)
        {
            throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "No such method found");
        }
    }

    // Set the value of a field in the MoodAnalyzer object
    public static void SetFieldValue(string fieldName, MoodAnalyzer moodAnalyzer, string value)
    {
        try
        {
            Type type = typeof(MoodAnalyzer);
            var fieldInfo = type.GetField(fieldName);
            fieldInfo.SetValue(moodAnalyzer, value);
        }
        catch (NullReferenceException)
        {
            throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_FIELD, "No such field found");
        }
    }
}

