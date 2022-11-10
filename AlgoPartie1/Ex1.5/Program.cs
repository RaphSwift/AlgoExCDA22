/*
 * VARIABLES
 * 
 * entier numberA;
 * entier numberB;
 * entier numberC;
 * 
 * Process
 * 
 * Write ("Enter numberA");
 * Read numberA;
 * Write ("Enter numberB");
 * Read numberB;
 * 
 * numberC <-- numberA;
 * numberA <-- numberB;
 * numberB <-- numberC;
 * 
 * OUTPUT
 * Write ("The value numberA is : " + numberA);
 * Write ("The value numberB is : " + numberB);
 * 
 */


int numberA;
int numberB;
int numberC;

Console.WriteLine("Enter numberA");
numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Enter numberB");
numberB = int.Parse(Console.ReadLine());

numberC = numberA;
numberA = numberB;
numberB = numberC;

Console.WriteLine("The value numberA is : " + numberA);
Console.WriteLine("The value numberB is : " + numberB);



