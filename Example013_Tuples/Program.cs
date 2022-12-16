// Tuples - кортежи, позволяют вывести из метода несколько значений
// и разных типов переменных (int, double, object)

(int,int) coordinates = GetSomething();
Console.WriteLine(coordinates.Item1);
Console.WriteLine(coordinates.Item2);

(int,int) GetSomething()
{
    int a = 5;
    int b = 10;
    return (a,b);
}