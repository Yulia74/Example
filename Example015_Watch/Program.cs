// Использование метода для подсчета скорости работы написанного кода

using System;                             // 1
using System.Diagnostics;                 // 2

Console.Write("Enter a number - the base of the degree (A):  ");

int a = int.Parse(Console.ReadLine());

Console.Write("Enter a number - exponent (B):  ");

int b = int.Parse(Console.ReadLine());

Stopwatch watch = new Stopwatch();          // 3
watch.Start();                              // 4

double PowerAB(double a, double b)
{
    if (b < 0) return (1 / a) * PowerAB(a, b + 1); // a ^ (-2) = 1 / (a * a)
    if (b > 0) return a * PowerAB(a, b - 1);
    else return 1;
}
Console.WriteLine($"The number A to the power of B is equal to   {PowerAB(a, b)}");

watch.Stop();                                 // 5
Console.WriteLine(watch.ElapsedMilliseconds); // 6