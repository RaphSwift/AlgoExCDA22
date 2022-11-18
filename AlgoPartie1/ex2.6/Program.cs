int n;
static string DisplayPrime(int nb)
{
    string result ="This is a prime number.";

    for (int i = 2; i < nb; i++) // i++ = (i=i+1) = (i+=1)
    {
        if (nb % i == 0)
        {   
            result= "This is NOT a prime number.";
        }
    }
    return result;
}
static void FindPrime(int numberN)
{
    int k = 0;
    for (int i = 2; i < numberN; i++) // i++ = (i=i+1) = (i+=1)
    {
        if (numberN % i == 0)
        {
            Console.WriteLine(i);
        }
    }
}
if ()
Console.WriteLine("Enter a number.");
n = int.Parse(Console.ReadLine());

FindPrime(n);
Console.WriteLine(DisplayPrime(n));

