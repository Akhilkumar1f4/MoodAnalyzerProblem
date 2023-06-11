public class TestCase6_1
{
    public string Execute()
    {
        UseCase6 useCase = new UseCase6();
        return useCase.InvokeAnalyzeMood("I am in Happy Mood");
    }
}
