// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Summa (int M, int N)
{
    if ( M == N) return M;
    else return M + Summa(M+1,N);
}
Console.WriteLine("Введите число M :");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N :");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"сумма элементов в промежутке от M до N = {Summa(M,N)}");
