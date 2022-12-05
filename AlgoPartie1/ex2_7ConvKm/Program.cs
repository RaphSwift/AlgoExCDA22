
double value;
double converter = 0.621;

Console.WriteLine("Enter a value in km.");
value = double.Parse(Console.ReadLine());


do
{
    Console.WriteLine(value * converter + " miles");
    Environment.Exit(0);
}

while (value > 0.01 || value < 1000000);

       {
        Console.WriteLine("The number must be between 0.01 and 1000000! Enter a new value.");
    }
    if (value == 'q')
    {
        Environment.Exit(0);
    }
    else if (value < 0.01 || value > 1000000)
{

}