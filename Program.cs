Console.Write("Введите значение N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите значение M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
        if (M>N)
                for (int i = N; i <= M; i++)
            Console.Write($" {i}");
           else
                for (int i = M; i <= N; i++)
            Console.Write($" {i}");

Console.Write("Введите натуральное число M: ");
string m = Console.ReadLine()!;

Console.Write("Введите натуральное число N: ");
string n = Console.ReadLine()!;
//////////////////////////////////////////
var numberM = ExceptionHandling(m);
var numberN = ExceptionHandling(n);

if (numberM.exception && numberN.exception && numberM.number >= 0 && numberN.number >= 0)
{
    if (numberM.number < numberN.number)
    {
        Console.WriteLine($"Сумма = {Summa(numberM.number, numberN.number)}");
    }
    else
    {
        Console.WriteLine($"Сумма = {Summa(numberN.number, numberM.number)}");
    }
    
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{m}, {n} -> Некорректный ввод!");
}

int Summa(int firstNumber, int lastNumber)
{
    if (lastNumber >= firstNumber) return (lastNumber) + Summa(firstNumber, --lastNumber);
    return 0;  
}

(bool exception, int number) ExceptionHandling(string number)
{
    bool yesInt = int.TryParse(number, out int d);
    if (!yesInt)
    {
        return (false, d);
    }
    return (true, d);
}
//////////////////////////////////////
﻿Console.Write("Введите неотрицательное число M: ");
string a = Console.ReadLine();

Console.Write("Введите неотрицательное число N: ");
string b = Console.ReadLine()!;

var number1M = ExceptionHandling2(a);
var number1N = ExceptionHandling2(b);

if (number1M.exception && number1N.exception && number1M.number >= 0 && number1N.number >= 0)
{
    Console.WriteLine($"A({number1M.number}, {number1N.number}) = {Akkerman(number1M.number, number1N.number)}");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{a}, {b} -> Некорректный ввод!");
}




int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return 0;
}

(bool exception, int number) ExceptionHandling2(string number)
{
    bool yesInt = int.TryParse(number, out int d);
    if (!yesInt)
    {
        return (false, d);
    }
    return (true, d);
}