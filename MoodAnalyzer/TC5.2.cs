public class TestCase5_2
{
    public MoodAnalyzer Execute()
    {
        UseCase5 useCase = new UseCase5();
        return useCase.CreateMoodAnalyzer("I am in Happy Mood");
    }
}
