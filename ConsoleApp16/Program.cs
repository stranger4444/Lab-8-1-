using ConsoleApp16;

class Program
{
    static void Main()
    {
        ConfigurationManager configManager = ConfigurationManager.Instance;

        Console.WriteLine("Enter logging mode:");
        configManager.LoggingMode = Console.ReadLine();

        Console.WriteLine("Enter database connection string:");
        configManager.DatabaseConnectionString = Console.ReadLine();

        Console.ReadLine(); 
    }
}