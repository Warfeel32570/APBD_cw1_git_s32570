
Console.WriteLine("Initial git setup."); //first commit [0]

//Second commit --> dev [1]
Console.WriteLine("Sum() method added.");
static double Sum(double a, double b)
{
    Console.WriteLine("Sum of " + a + " and " + b);
    Console.WriteLine("Result:");
    return a + b;
}

Console.WriteLine("Test:\n");
double result = Sum(5.5, 2.75);
Console.WriteLine(result);