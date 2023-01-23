// Сумма чисел от 1 до n
// итеративный подход
/*
int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++)
        result += i;
    return result;
}
Console.WriteLine(SumFor(10));
*/

// рекусия

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(10));
