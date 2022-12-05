//LA SUITE DE FIBONACCI


int position = 2;
int n;
string resultat = "0\n1";
int nbPrecedent = 0;
int nbCourant = 1;
int nbSuivant;

Console.WriteLine("Combien de nombres de la suite de Fibonacci souhaitez vous afficher ?");
n = int.Parse(Console.ReadLine());

if (n > 2)
{
    while (position < n)
    {
        nbSuivant = nbPrecedent + nbCourant;
        resultat = resultat + "\n" + nbSuivant;
        nbPrecedent = nbCourant;
        nbCourant = nbSuivant;
        position++;
    }
}
else
{
    n = 2;
}


Console.WriteLine("Les " + n + " premiers nombres de la suite de Fibonacci sont \n" + resultat);

