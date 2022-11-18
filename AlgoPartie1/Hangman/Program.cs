/*L'algorithme lit un mot proposé par un premier joueur.
Ce mot a une longueur minimum de 5 caractères (à contrôler).
L'algorithme affiche ensuite le mot où toutes les lettres sauf la première et la dernière sont remplacées par un tiret. Un
deuxième joueur propose des lettres une à une.
Chaque fois que la lettre proposée se trouve dans le mot, l'algorithme remplace les tirets qui remplaçaient cette lettre et
réaffiche le mot. Le second joueur a droit à un maximum de 6 erreurs pour retrouver toutes les lettres.
 * 
 * 
 */

//Variables
string userInput;
char user2Input;
char[] tabMot;
int test = 6;


//demande de recuperation de la saisie utilisateur
Console.WriteLine("Saisir un mot de 5 lettres Min.");
userInput = Console.ReadLine();

//conversion de la variable string en tableau de char
tabMot = userInput.ToCharArray();

//affichage du tabMot (facultatif)
AffichageDuTableau(tabMot);


// Creéé un tableau (tabMotCacher) qui sera modifié, pour conserver (tabMot) pour comparaison.
char[] tabMotCacher = tabMot;

// Dans le tableau de char, je pemplace les characters par des underscores "_" sauf la premiere et la derniere.

for (int i = 1; i < tabMotCacher.Length - 1; i++)
{
    tabMotCacher[i] = '_';
}

//Affichage duTabCacher (facultatif) pour voir la modif;
AffichageDuTableau(tabMotCacher);

Console.WriteLine("Presser une toucheet et appeler le joueur 2");
Console.ReadKey();// attendre que le joueur 1 presse une touche pour lancer le jeu
Console.Clear(); // vide la console donc efface de l'ecran l'entrée du joueur 1

//debut partie joueur 2

// operation effectuée pour 1 tour de jeu.

do
{
    Console.WriteLine($"Joueur 2 entrez une lettre vous avez droit à {test} erreurs pour trouver le mot, bonne chance!");
    AffichageDuTableau(tabMotCacher);

    user2Input = Console.ReadLine()[0]; // recuperation de la premiere lettre donnée par le joueur 2 
    Console.WriteLine(user2Input);

    for (int i = 1; i < tabMotCacher.Length - 1; i++)
    {
        if (tabMot[i])== user2Input)
                {
        tabMotCacher[i] = user2Input;
    }

}
}
while (test > 0 || tabMotCacher == tabMot) ;



static void AffichageDuTableau(char[] _tabMot)
{
    foreach (int i in _tabMot)
    {
        Console.Write((char)i);
    }
    Console.WriteLine(); // Pour avoir un saut de ligne
}

