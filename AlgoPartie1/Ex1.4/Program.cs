/*VARIABLES
 * 
 * float sumS; 
 * float interestI;
 * float numberYearsN;
 * float interestSimple;
 * float interestCompose;
 * 
 * INPUT
 * 
 * Write ("Enter the value during N years on a bank account. ");
 * Read sumS;
 * Write ("Enter the interest  i given by the bank.")
 * Raed interestI;
 * Write ("Enter the number of years of sumS placement.")
 * Read numberYearsN;
 * 
 * PROCESS
 * 
 * InteretSimple <-- sumS ( 1 + numberYearsN * i )
    //InteretComposé <-- sumS ( 1 + interestI )numberYearsN
 * 
 * OUTPUT
 * 
 * Write ("Calculate the " +sumS+ " value during " +numberYearsN+ " with " + interetSimple+ " et " + interetComposé");
 */

using System.Diagnostics.Metrics;

float sumS;
float interestI;
float numberYearsN;
float interestSimple;
float interestCompose;


Console.WriteLine("Enter the value during N years on a bank account.");
sumS = float.Parse(Console.ReadLine());
Console.WriteLine("Enter the interest  i given by the bank.");
interestI = float.Parse(Console.ReadLine())/100;
Console.WriteLine("Enter the number of years of sumS placement.");
numberYearsN = float.Parse(Console.ReadLine());

interestSimple = sumS * (1 + numberYearsN * interestI);
interestCompose = sumS * MathF.Pow(1 + interestI, numberYearsN);

Console.WriteLine( "Calculate the " + sumS + " value during " + numberYearsN + " with " + interestSimple + " et " + interestCompose);




