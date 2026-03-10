class Program5
{
    static void Main()
    {
        // Запуск приватного метода внутри того же класса
        PrintMessage("Hello from Private Method!");
    }

    private static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}
