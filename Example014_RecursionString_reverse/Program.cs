// Собрать строку с числами от а до b (a >= b).

// итеративный подход
/*
Console.WriteLine(NumbersFor(10, 1));

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
*/

// с помощью рекурсии

Console.WriteLine(NumbersRec(10, 1));

string NumbersRec(int a, int b)
{
    if (a >= b)
        return NumbersRec(a, b + 1) + $"{b} ";
    else 
        return String.Empty;
}
 Console.WriteLine(NumbersRec(1,10)); // 10 9 8 7 6 5 4 3 2 1 