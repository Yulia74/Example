// Факториал числа
// итеративный подход
/*
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
        result *= i;
    return result;
}
Console.WriteLine(FactorialFor(10));
*/

// рекурсия

int Factorialrec(int n)
{
    if (n == 1) return 1;
    else return n * Factorialrec(n - 1);
}
Console.WriteLine(Factorialrec(10));