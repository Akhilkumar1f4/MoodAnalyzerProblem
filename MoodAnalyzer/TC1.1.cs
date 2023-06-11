public class TestCase1_1
{
    public string Execute()
    {
        UseCase1 useCase = new UseCase1();
        return useCase.AnalyzeMood("I am in Any Mood");
    }
}