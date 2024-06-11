using ConvertStringToHash;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your string to Convert to Hash");
        string input = Console.ReadLine();
        string hash = GenerateHash.GenerateMD5Hash(input);
        Console.WriteLine("The Hash value for {0} is {1} ", input, hash);
        Console.ReadLine();
    }
}