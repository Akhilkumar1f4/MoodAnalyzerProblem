public class TestCase4_2
{
    public MoodAnalyzer Execute()
    {
        UseCase4 useCase = new UseCase4();
        return useCase.CreateMoodAnalyzer();
    }
}
