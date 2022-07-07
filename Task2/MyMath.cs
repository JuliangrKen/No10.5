namespace Task2
{
    class MyMath : ISum
    {
        readonly ILogger log;
        string str;
        public MyMath(ILogger logger, string str)
        {
            log = logger;
            log.Event("Калькулятор начал работу.");
            this.str = str;
        }
        public int Sum(int number1 = 0, int number2 = 0)
        {
            bool b = false; // эта переменная нужна, чтобы проверить, есть ли пробел.
            try
            {
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

                log.Event("Калькулятор принял числа на вход.");
                return number1 + number2;
            }
            catch
            {
                log.Error("Вы действовали не по инструкции!");
                return 0;
            }
        }
    }
}
