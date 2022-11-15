/*ex3.1
 * VARIABLES
 * 
 * entier numberMystery;
 * entier tryNumber;
 * entier limitMin;
 * entier limitMax;
 * entier userInput;
 * 
 * PROCESS
 * 
 * limitMin <-- 0
 * limitMax <-- 100
 * numberMystery <-- Random(limitMin,limitMax)
 *  write ("Enter a numer between "limitMin" and "limitMax")
 *  read userInput
 *  tryNumber<--1
 *  
 *  while (userInput != numberMystery)
 *  
 *  if (userInput < numberMystery)
 *      limitMin <--userInput
 *  else 
 *      limitMax<--userInput
 *  ENDIF
 * write ("Enter a numer between "limitMin" and "limitMax") 
 * read userInput
 * tryNumber++
 * ENDWHILE
 * 
 * OUTPUT
 * 
 * Write ("You found after ",tryNumber, "try(ies)")
 * 
 */


Random rand = new Random(); // random object creation
int limitMin = 0;
int limitMax = 100;
int userInput;
int tryNumber = 1;
int numberMystery=rand.Next(limitMin,limitMax+1);// affectation du nombre myster
Console.WriteLine("Enter a numer between " + limitMin + " and " + limitMax + ".");
userInput = int.Parse(Console.ReadLine());

while (userInput != numberMystery)
{

    if (userInput < numberMystery)
    {
        limitMin = userInput;
    }
    else {
        limitMax = userInput;
    }
    Console.WriteLine("Enter a numer between "+limitMin+" and " +limitMax + ".");
    userInput=int.Parse(Console.ReadLine());   

    tryNumber++;
}

Console.WriteLine("You found after " + tryNumber + " try(ies).");







