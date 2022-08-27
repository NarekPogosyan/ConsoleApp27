Console.WriteLine("Fibonachii series by recursia ");
Console.WriteLine("pliese insert matrixss size ");

Console.WriteLine("n = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Fibonachii series " + Fibonachii(n));
static int Fibonachii(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;

    return (Fibonachii(n - 2) + Fibonachii(n - 1));
}