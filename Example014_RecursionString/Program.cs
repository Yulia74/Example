// Собрать строку с числами от а до b (a <= b).

// итеративный подход

Console.WriteLine(NumbersFor(1, 10));

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}


// с помощью рекурсии

Console.WriteLine(NumbersRec(1, 10));

string NumbersRec(int a, int b)
{
    if (a <= b)
        return $"{a} " + NumbersRec(a + 1, b);
    else
        return String.Empty;
}
