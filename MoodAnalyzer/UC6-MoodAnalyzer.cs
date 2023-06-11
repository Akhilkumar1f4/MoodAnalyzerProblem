// Custom exception for mood analysis errors
public class MoodAnalysisException1 : Exception
{
    public enum ExceptionType
    {
        NULL_MOOD,
        EMPTY_MOOD,
        NO_SUCH_CLASS,
        NO_SUCH_METHOD,
        NO_SUCH_FIELD
    }

    private readonly ExceptionType type;

    public MoodAnalysisException1(ExceptionType type, string message) : base(message)
    {
        this.type = type;
    }
}

// MoodAnalyzer class
public class MoodAnalyzer1
{
    private string message;

    // Default constructor
    public MoodAnalyzer1()
    {
        this.message = string.Empty;
    }

    // Parameterized constructor
    public MoodAnalyzer1(string message)
    {
        this.message = message;
    }

    // Analyze the mood based on the message
    public string AnalyzeMood()
    {
        try
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD, "Mood cannot be empty");
            }

            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
        catch (NullReferenceException)
        {
            throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Mood cannot be null");
        }
    }
}

// MoodAnalyzerReflector class for reflection operations on MoodAnalyzer class
public class MoodAnalyzerReflector
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

// Use case 6: Invoke AnalyzeMood method using reflection
public class UseCase6
{
    public string InvokeAnalyzeMood(string message)
    {
        MoodAnalyzer analyzer = new MoodAnalyzer(message);
        return MoodAnalyzerReflector.InvokeMethod("AnalyzeMood", analyzer);
    }
}

