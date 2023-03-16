using System;
Console.WriteLine("Выберите на какую оценку вы хотите посмотреть (3-5):"); int ocenka = Convert.ToInt32(Console.ReadLine());
if (ocenka == 3)
{
    bool chetn = true;
    Console.WriteLine("Введите число:"); int x = Convert.ToInt32(Console.ReadLine());
    for (int i = 2; i < x; i++)
    {
        if (x % i == 0) chetn = false;
    }
    if (chetn) Console.WriteLine("Число простое"); else Console.WriteLine("Число не простое");
}
if (ocenka == 4)
{
    Console.Write("Введите конец диапазона от 2 до "); int max = int.Parse(Console.ReadLine());
    for (int i = 2; i <= max; i++)
    {
        bool chetn = true;
            for (int k = 2; k < i; k++)
            {
                if (i % k == 0 & i % 1 == 0) chetn = false;
            }
            if (chetn) Console.Write("{0} ", i);
    }
}
if (ocenka == 5)
{
    Console.Write("Введите число : "); int num = Convert.ToInt32(int.Parse(Console.ReadLine()));
    Console.Write("Число {0} раскладывается на : ", num);
    for (int k = 2; k < num; k++)
    {
        for (int i = 2; i <= num;)
        {
            if (num % i == 0)
            {
                Console.Write("\r\n{0}", i);
                num /= i;
            }
            else i += 1;
        }
    }
}