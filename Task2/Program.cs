using Task2;

Logger logger = new Logger();

Console.WriteLine("Введите два числа через пробел, выводом будет их сумма.");
Console.Write("Ввод: ");
string? str = Console.ReadLine();

if (str == null) str = "";

var math = new MyMath(logger, str);

Console.WriteLine(math.Sum());