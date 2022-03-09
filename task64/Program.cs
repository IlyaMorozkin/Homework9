// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Numbers(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}");
        Fill(m,n);
    }

}
void Fill(int m,int n)
{
    while(m < n)
    {
        m++;
        Console.Write($", {m} ");
    }

}

Numbers(1, 5);
Console.WriteLine();
Numbers(4, 8);
