
Console.WriteLine("Initial git setup."); //first commit [0]

//Second commit --> [1] dev
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

//Third commit --> [2] dev 
static double InputHelper(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();

    return double.Parse(input ?? "0");
}

//Forth commit --> [3] dev
static double ReadNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();

    if (!double.TryParse(input, out double result))
    {
        Console.WriteLine("Invalid number!");
        return 0;
    }

    return result;
}