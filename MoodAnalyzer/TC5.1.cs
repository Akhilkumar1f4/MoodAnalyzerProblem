
// Test case 5.1: Given class name is improper, should throw MoodAnalysisException
public class TestCase5_1
{
    public MoodAnalyzer Execute()
    {
        UseCase5 useCase = new UseCase5();
        return useCase.CreateMoodAnalyzer("I am in Happy Mood");
    }
}