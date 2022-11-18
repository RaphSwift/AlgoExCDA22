

int n;

static void findDiviseur(int numberN)
{
    for (int i = 2; i < numberN; i++) // i++ = (i=i+1) = (i+=1)
    {
        if (numberN % i == 0)   // pour trouver les diviseurs , on utilise le modulo (reste d'une division)
        {
            Console.WriteLine(i);
        }
    }
}

Console.WriteLine("Enter a number.");
n = int.Parse(Console.ReadLine());


findDiviseur(n);


