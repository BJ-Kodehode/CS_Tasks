namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Opprett en instans av Fundament
        Fundament fundament = new Fundament();

        // Test metodene
        fundament.SumTwoNumbers();
        Console.WriteLine(fundament.SumTwoNumbersOfGivenType(5.5, 4.5));
        fundament.CheckOddOrEven(7);
        Console.WriteLine(fundament.GetAInterestingFact("Did you know C# was created by Microsoft?"));
    }
}
