int number1 = 0, number2 = 0;
bool b = false; // эта переменная нужна, чтобы проверить, есть ли пробел.

Console.WriteLine("Введите два числа через пробел, выводом будет их сумма.");
Console.Write("Ввод: ");
string? str = Console.ReadLine();

try
{
    if (str == null || str == "") throw new Exception();

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            int a = 0;
            string str2 = "";
            while (a != i)
            {
                str2 += str[a];
                a++;
            }
            number1 = Convert.ToInt32(str2);
            str2 = "";
            while (a < str.Length)
            {
                str2 += str[a];
                a++;
            }
            number2 = Convert.ToInt32(str2);
            b = true;
            break;
        }
    }

    if (!b) throw new Exception();
}
catch
{
    Console.WriteLine("Вы действовали не по инструкции!");
    return;
}

var math = new MyMath();
Console.WriteLine(math.Sum(number1, number2));

class MyMath : ISum
{
    public int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
}

public interface ISum
{
    int Sum(int num1, int num2);
}