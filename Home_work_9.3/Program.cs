/*Задача 68: Напишите программу вычисления функции Аккермана
 с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }

    if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    return -1;
}

Console.WriteLine("Ackermann(0, 0) = " + Ackermann(0, 0));
Console.WriteLine("Ackermann(0, 1) = " + Ackermann(0, 1));
Console.WriteLine("Ackermann(1, 0) = " + Ackermann(1, 0));
Console.WriteLine("Ackermann(1, 1) = " + Ackermann(1, 1));
Console.WriteLine("Ackermann(1, 2) = " + Ackermann(1, 2));
Console.WriteLine("Ackermann(2, 1) = " + Ackermann(2, 1));
Console.WriteLine("Ackermann(2, 2) = " + Ackermann(2, 2));
Console.WriteLine("Ackermann(2, 3) = " + Ackermann(2, 3));
Console.WriteLine("Ackermann(3, 1) = " + Ackermann(3, 1));
Console.WriteLine("Ackermann(3, 2) = " + Ackermann(3, 2));
Console.WriteLine("Ackermann(3, 3) = " + Ackermann(3, 3));



