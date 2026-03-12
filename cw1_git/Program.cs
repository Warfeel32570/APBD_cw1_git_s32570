
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
    Console.WriteLine(" > End of InputHelper.");

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

    Console.WriteLine(" > End of ReadNumber.");
    return result;
}

//Fifth commit --> [4] feature-average
static double AverageOfTwo(double a, double b)
{
    Console.WriteLine("Average of " + a + " and " + b);
    Console.WriteLine("Result:");
    return (a + b) / 2;
}

double avgOfTwo = AverageOfTwo(63.89, 340.45);
Console.WriteLine(avgOfTwo);
Console.WriteLine(" > End of AverageOfTwo.");

static double AverageInArray(int[] values)
{
    if (values == null || values.Length == 0)
    {
        Console.WriteLine("Array is empty.");
        return 0;
    }

    int sum = 0;

    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }

    Console.WriteLine("A > End of AverageInArray.");
    return (double)sum / values.Length;
}

Console.WriteLine("---End of Git entry jorney---");

//Sixth commit --> [5] feature-max
static int CalculateMax(int[] values)
{
    if (values == null || values.Length == 0)
    {
        Console.WriteLine("Array is empty.");
        return 0;
    }

    int max = values[0];

    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] > max)
            max = values[i];
    }

    return max;
}

int[] vals = { 13, 23, 4, 21, 18, 56 };
Console.WriteLine("Max: " + CalculateMax(vals));

//Seventh commit --> [6] feature-min

static int CalculateMin(int[] values)
{
    if (values == null || values.Length == 0)
    {
        Console.WriteLine("Array is empty.");
        return 0;
    }

    int min = values[0];

    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] < min)
            min = values[i];
    }

    return min;
}

Console.WriteLine("Min: " + CalculateMin(vals));
Console.WriteLine("CalculateMin tested successfully");