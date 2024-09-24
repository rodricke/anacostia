using System;

class Program
{
    static void Main(string[] args)
    {
        string version = "3.0.1";
        string environment = Environment.GetEnvironmentVariable("RELEASE_ENVIRONMENTNAME") ?? "Unknown";
        Console.WriteLine($"Hello World version {version} from {environment} environment");
    }
}
