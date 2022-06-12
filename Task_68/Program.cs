// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите неотрицательное число N: ");
int n = int.Parse(Console.ReadLine());

int result = AkkermanFunction(m, n);
Console.WriteLine($"Функция Аккермана равна: {result}");

int AkkermanFunction(int a, int b)
{
    if (a == 0) return b + 1;
    else if (a > 0 && b == 0)
    {
        return AkkermanFunction(a - 1, 1);
    }
    else if (a > 0 && b > 0)
    {
        return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
    }
   return AkkermanFunction(a, b);
}