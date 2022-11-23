
/**
* 
* Variables
* 
* Declarer list<chaine>
* */

static void Main(string[] args)
{
    Console.WriteLine("Les legumes");
    List<string> grocery = new List<string>();
    List<string> prices = new List<float>();
    string userInput;
    string[] splitUserInput;
    float tempPrice;

    do
    {
        Console.WriteLine("Veuillez entrer un nom de légume suivi par son prix au kilo" + Environment.NewLine);
        Console.WriteLine("Lorsque vous avez fini vous pouvez taper \"go\" pour afficher la liste et connaitre
            userInput = Console.ReadLine();
        userInput = userInput.ToLower();

        if (userInput != "go")
        {
            splitUserInput = userInput.Split(' ', String);
        }
    }
} // fin Classe
} // fin namespace
