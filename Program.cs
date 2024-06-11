using ConvertStringToHash;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Convert Your String To Hash");
        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Convert To Hash");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    GenerateHash.GenerateMD5Hash();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}