// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
*  Pseudo code

* Déclaration des variables.
* Double userInput;
* Double result;
* Char commandeDeSortie = 'q';
* String uniteDeMesure = "Miles";

*(AFFICHAGE) PROCESS
*
*faire
*
*       Ecrire "Veuillez entrer une valeur à convertire en km comprise entre 0.01 et 1000000 svp."
*       Lire userInput;
* 
* si (userInput == 'q')
* Alors
*       fin du programme
* finsi
* 
* userInputConvert <-- (double) userInput
* 
* Tant que (userInput < 0.01 || userInput >= 1 000 000)

* 
* result <-- userInput / 1.609;
* 
* AFFICHAGE RESULTAT
* 
* Ecrire ("Le resultat est ", result,"Miles.")
*/

string userInput;
double userInputConvert;
double result;
string commandeDeSortie = "q";

do
{
    Console.WriteLine("Veuillez entrer une valeur à convertire en km comprise entre 0.01 et 1000000 svp.");
    userInput = Console.ReadLine();

    if (double.TryParse(userInput, out userInputConvert) && userInputConvert >= 0.01 && userInputConvert < 1000000)
    {
        result = userInputConvert / 1.609;
        Console.WriteLine("Le resultat est " + result + "Miles.");
    }
   
    //userInputConvert = double.Parse(userInput);

}
while (!userInput.Equals(commandeDeSortie));


Console.ReadLine();


