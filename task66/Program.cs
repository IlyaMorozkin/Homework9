// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void Numbers(int m, int n)
{
    if (m < n)
    {
        FindSum(m, n);
    }

}
void FindSum(int m, int n)
{
    int sum = m;
    while (m < n)
    {
        m++;
        sum = sum + m;
    }
    Console.Write(sum);
}

Numbers(1, 15);
Console.WriteLine();
Numbers(4, 8);
