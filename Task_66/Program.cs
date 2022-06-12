// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

if (m > n)
{
    int sumresult = SumNaturalNumberUp(m, n);
    Console.WriteLine($"Сумма числе в промежутке между указанными числам: {sumresult}");
}

if (n > m)
{
    int sumresult = SumNaturalNumberDown(m, n);
    Console.WriteLine($"Сумма числе в промежутке между указанными числам: {sumresult}");
}


int SumNaturalNumberUp(int a, int b)
{
    if (a == (b - 1)) return 0;
    int sum = SumNaturalNumberUp(a - 1, b) + a;
    return sum;
}

int SumNaturalNumberDown(int m, int n)
{
    if (n == (m - 1)) return 0;
    int sum = SumNaturalNumberDown(m, n - 1) + n;
    return sum;
}