//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

void Spisok (int N)
{
    if (N > 0)
    {
        Console.Write(N);
        Spisok(N - 1);
    }
}
Console.WriteLine("Введите число :");
int N = Convert.ToInt32(Console.ReadLine());
Spisok(N);
