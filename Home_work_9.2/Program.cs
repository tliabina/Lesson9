/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите начальное число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNum(n,m));

string PrintNum(int start, int end)
{
    if (start==end)
    {
        return end.ToString();
    }
    return(start+ " "+PrintNum(start +1,  end));
}

int PrintSum (int s)
{
if (n==m)
    {
        return m;
    }
    
    int sum=0;
    sum = n +(n+1);
    return (PrintSum (s));

}


