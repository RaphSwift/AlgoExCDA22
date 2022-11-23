using Ex2_5 = ExerciceMikaCours;

namespace NombreParfait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * VARIABLE
             * Entier nombreATrouver            //nombre de nombre parfait à afficher
             * Liste<entier>listDiviseur       //list des diviseurs
             * Entier nombreParfaitTrouvé     //compteur de nombre parfait trouvé
             * Entier sommeDiviseur          //stock la somme des entiers
             * Entier nombreCourant         //nombre que l'on teste
             * 
             * 
             * 
             * TRAITEMENT
             * Ecrire "Combien de nombres parfaits souhaitez vous connaitre? (Réponse en dessous de 4 attendu)"
             * nombreATrouver <-- GetUserInput()
             * Tant que nombreParfaitTrouvé est inferieur à nombreATrouver
             *    sommeDiviseur <-- 1
             *    listDiviseur <-- TrouverDiviseur(nombreCourant)
             *     pour chaque entier dans diviseur faire 
             *      sommeDiviseur<-- sommeDiviseur + entier
             *     fin pour chaque
             *     si sommeDiviseur est égqle à nombreCourant
             *      nombreParfaitTrouvé <-- nombreParfaitTrouvé + 1
             *      Ecrire nombreCourant, "est un nombre parfait."
             *      fin si
             *      nombreCourant + 1
             * fin tant que 
             * 
             * Affichage
             * 
             * Fonction
             * GetUserInput(): entier
             * TrouveDiviseur(entier) : Liste<entier>
             * 
             */
            int nombreATrouver = 0;
            List<int> listDiviseur;
            int nombreParfaitATrouver = 0;
            int sommeDiviseur;
            int nombreCourant = 1;

            Console.WriteLine("Combien de nombres parfaits souhaitez vous connaitre? (Réponse en dessous de 4 attendu)");

            nombreATrouver = Ex2_5.Program.GetUserInput();

            while (nombreParfaitATrouver < nombreATrouver)
            {
                sommeDiviseur = 1;
                listDiviseur = Ex2_5.Program.FindDivisor(++nombreCourant);
                foreach (int diviseurCourant in listDiviseur)
                {
                    sommeDiviseur = sommeDiviseur + diviseurCourant;
                    //sommeDiviseur += diviseurCourant;
                }
                if (sommeDiviseur == nombreCourant)
                {
                    ++nombreParfaitATrouver;
                    Console.WriteLine(nombreCourant + "est un nombre parfait.");
                }
            }
        }
    }
}



   