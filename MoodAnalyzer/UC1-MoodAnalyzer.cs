using System;

// Custom exception for mood analysis errors
public class MoodAnalysisException : Exception
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

    public MoodAnalysisException(ExceptionType type, string message) : base(message)
    {
        this.type = type;
    }
}

// MoodAnalyzer class
public class MoodAnalyzer
{
    private string message;

    // Default constructor
    public MoodAnalyzer()
    {
        this.message = string.Empty;
    }

    // Parameterized constructor
    public MoodAnalyzer(string message)
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

// Use case 1: Mood analysis with message as parameter
public class UseCase1
{
    public string AnalyzeMood(string message)
    {
        MoodAnalyzer analyzer = new MoodAnalyzer(message);
        return analyzer.AnalyzeMood();
    }
}