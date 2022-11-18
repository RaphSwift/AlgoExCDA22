/*EX2.3
 * 
 * */
/*
static double[] AskValue(int _limitArray)
{
    int limitArray = _limitArray;
    double[] array = new double[limitArray - 1];
    double number;

    string stringInput = "";

    for (int i = 1; i == limitArray; i++)
    {
        while (!double.TryParse(stringInput, out number))
        {
            Console.WriteLine("Enter number " + i);
            stringInput =Console.ReadLine();
        }
        array[i - 1] = number;  
    }
    return array;
}

*/

double numberA;
double numberB;
double numberC;


static void returnNumber(double num1, double num2)
{

    if (num1 < num2)
    {
        Console.Write(num1 + " " + num2);
    }
    else
    {

        Console.Write(num2 + " " + num1);
    }
}

Console.WriteLine("Enter the first number");
numberA = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
numberB = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number");
numberC = double.Parse(Console.ReadLine());

if (numberA < numberB && numberA < numberC)
{
    Console.Write(numberA + " ");  // I know A is the smallest  
    returnNumber(numberC, numberB);

    //if (numberB < numberC)
    //{
    //    Console.Write(numberB + " "); // I know B is smaller than C
    //    Console.Write(numberC + " ");
    //}
    //else
    //{
    //    Console.Write(numberC + " "); // I know C is smaller than B
    //    Console.Write(numberB + " ");
    //}
}

else if (numberB < numberA && numberB < numberC)
{
    Console.Write(numberB + " "); // I know B is the smallest
    returnNumber(numberC, numberA);

    //if (numberA < numberC)
    //{
    //    Console.Write(numberA + " ");// I know A is the smaller than C
    //    Console.Write(numberC + " ");
    //}
    //else
    //{
    //    Console.Write(numberC + " "); // I know C is smaller than A
    //    Console.Write(numberA + " ");
    //}
}

else
{
    Console.Write(numberC + " ");
    returnNumber(numberA, numberB);
    //if (numberA < numberB)
    //{
    //    Console.Write(numberA + " ");// I know A is the smaller than B
    //    Console.Write(numberB + " ");
    //}
    //else
    //{
    //    Console.Write(numberB + " ");
    //    Console.Write(numberA + " ");
    //}
}
