﻿/*Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите начальное число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNum(int sum, int m, int n)
{
    if (m > n)
    {
        return sum;
    }

    return SumNum(sum + m, m + 1, n);
}

Console.WriteLine(SumNum(0, m, n));