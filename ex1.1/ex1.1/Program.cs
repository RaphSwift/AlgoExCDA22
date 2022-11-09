// See https://aka.ms/new-console-template for more information

/*INPUT
 * Double userInputN1;
 * 
 * Double userInputN2;
 * 
 * Double result;
 * 
 * PROCESS
 * 
 * Write ("Enter the 1st number");
 * Read userInputN1;
 * Write ("Enter the 2nd number");
 * Read userInputN2;
 * result <-- (userInputN1 + userInputN2 )/ 2;
 * 
 * OUTPUT
 * 
 * Write ("The average is: ", result, ".");
 * 
 * 
 */

double userInputN1;
double userInputN2;
double result;

Console.WriteLine("Enter the 1st number");
userInputN1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the 2nd number");
userInputN2 = double.Parse(Console.ReadLine());

result = (userInputN1 + userInputN2) / 2;

Console.WriteLine("The average is: " + result + ".");
