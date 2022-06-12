// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
NaturalNumber(number);


void NaturalNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num}  ");
    NaturalNumber(num - 1);
}