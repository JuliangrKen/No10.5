namespace Task2
{
    class Logger : ILogger
    {
        public void Error(string message)
        {
            var def = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = def;
            Thread.Sleep(1000);
        }

        public void Event(string message)
        {
            var def = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = def;
            Thread.Sleep(1000);
        }
    }
}