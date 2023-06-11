using System;

class Program
{
    static void Main(string[] args)
    {
        // Use case 1: Mood analysis with message as parameter
        UseCase1 useCase1 = new UseCase1();
        string result1 = useCase1.AnalyzeMood("I am in Any Mood");
        Console.WriteLine("Use Case 1 Result: " + result1);

        // Test case 1.1: Given "I am in Any Mood" message, should return HAPPY
        TestCase1_1 testCase1_1 = new TestCase1_1();
        string result1_1 = testCase1_1.Execute();
        Console.WriteLine("Test Case 1.1 Result: " + result1_1);

        TestCase1_2 testCase1_2 = new TestCase1_2();
        string result1_2 = testCase1_2.Execute();
        Console.WriteLine("Test Case 1.2 Result: " + result1_2);

        // Use case 2: Mood analysis with null mood
        UseCase2 useCase2 = new UseCase2();
        string result2 = useCase2.AnalyzeMood();
        Console.WriteLine("Use Case 2 Result: " + result2);

        // Test case 2.1: Given null mood, should return HAPPY
        TestCase2_1 testCase2_1 = new TestCase2_1();
        string result2_1 = testCase2_1.Execute();
        Console.WriteLine("Test Case 2.1 Result: " + result2_1);

        // Use case 3: Mood analysis with null mood, throwing exception
        UseCase3 useCase3 = new UseCase3();
        string result3 = useCase3.AnalyzeMood();
        Console.WriteLine("Use Case 3 Result: " + result3);

        // Test case 3.1: Given NULL mood, should throw MoodAnalysisException
        TestCase3_1 testCase3_1 = new TestCase3_1();
        string result3_1 = testCase3_1.Execute();
        Console.WriteLine("Test Case 3.1 Result: " + result3_1);

        // Test case 3.2: Given empty mood, should throw MoodAnalysisException indicating Empty Mood
        TestCase3_2 testCase3_2 = new TestCase3_2();
        string result3_2 = testCase3_2.Execute();
        Console.WriteLine("Test Case 3.2 Result: " + result3_2);

        // Use case 4: Create MoodAnalyzer object using reflection
        UseCase4 useCase4 = new UseCase4();
        MoodAnalyzer moodAnalyzer4 = useCase4.CreateMoodAnalyzer();
        Console.WriteLine("Use Case 4 Result: MoodAnalyzer object created");

        // Test case 4.1: Given class name is improper, should throw MoodAnalysisException
        TestCase4_1 testCase4_1 = new TestCase4_1();
        try
        {
            MoodAnalyzer result4_1 = testCase4_1.Execute();
            Console.WriteLine("Test Case 4.1 Result: MoodAnalyzer object created");
        }
        catch (MoodAnalysisException ex)
        {
            Console.WriteLine("Test Case 4.1 Result: " + ex.Message);
        }

        // Test case 4.2: Given constructor is not proper, should throw MoodAnalysisException
        TestCase4_2 testCase4_2 = new TestCase4_2();
        try
        {
            MoodAnalyzer result4_2 = testCase4_2.Execute();
            Console.WriteLine("Test Case 4.2 Result: MoodAnalyzer object created");
        }
        catch (MoodAnalysisException ex)
        {
            Console.WriteLine("Test Case 4.2 Result: " + ex.Message);
        }
       

        // Use case 5: Create MoodAnalyzer object with parameterized constructor using reflection
        UseCase5 useCase5 = new UseCase5();
        MoodAnalyzer moodAnalyzer5 = useCase5.CreateMoodAnalyzer("I am in Happy Mood");
        Console.WriteLine("Use Case 5 Result: MoodAnalyzer object created");

        // Test case 5.1: Given class name is improper, should throw MoodAnalysisException
        TestCase5_1 testCase5_1 = new TestCase5_1();
        try
        {
            MoodAnalyzer result5_1 = testCase5_1.Execute();
            Console.WriteLine("Test Case 5.1 Result: MoodAnalyzer object created");
        }
        catch (MoodAnalysisException ex)
        {
            Console.WriteLine("Test Case 5.1 Result: " + ex.Message);
        }

        // Test case 5.2: Given constructor is not proper, should throw MoodAnalysisException
        TestCase5_2 testCase5_2 = new TestCase5_2();
        try
        {
            MoodAnalyzer result5_2 = testCase5_2.Execute();
            Console.WriteLine("Test Case 5.2 Result: MoodAnalyzer object created");
        }
        catch (MoodAnalysisException ex)
        {
            Console.WriteLine("Test Case 5.2 Result: " + ex.Message);
        }
       

        // Use case 6: Invoke AnalyzeMood method using reflection
        UseCase6 useCase6 = new UseCase6();
        string result6 = useCase6.InvokeAnalyzeMood("I am in Happy Mood");
        Console.WriteLine("Use Case 6 Result: " + result6);

        // Test case 6.1: Given proper method name, should return HAPPY mood
        TestCase6_1 testCase6_1 = new TestCase6_1();
        try
        {
            string result6_1 = testCase6_1.Execute();
            Console.WriteLine("Test Case 6.1 Result: " + result6_1);
        }
        catch (MoodAnalysisException ex)
        {
            Console.WriteLine("Test Case 6.1 Result: " + ex.Message);
        }

        // Use case 7: Modify mood dynamically using reflection
        UseCase7 useCase7 = new UseCase7();
        string result7 = useCase7.ModifyMoodDynamically("I am in Happy Mood");
        Console.WriteLine("Use Case 7 Result: " + result7);

        // Test case 7.1: Set field when improper, should throw exception with No Such Field
        TestCase7_1 testCase7_1 = new TestCase7_1();
        try
        {
            string result7_1 = testCase7_1.Execute();
            Console.WriteLine("Test Case 7.1 Result: " + result7_1);
        }
        catch (MoodAnalysisException ex)
        {
            Console.WriteLine("Test Case 7.1 Result: " + ex.Message);
        }

        // Test case 7.2: Setting null message should throw exception
        TestCase7_2 testCase7_2 = new TestCase7_2();
        try
        {
            string result7_2 = testCase7_2.Execute();
            Console.WriteLine("Test Case 7.2 Result: " + result7_2);
        }
        catch (MoodAnalysisException ex)
        {
            Console.WriteLine("Test Case 7.2 Result: " + ex.Message);
        }
    }
}
