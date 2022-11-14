/* 2.1
 * VARIABLES
 * 
 * entier numberA;
 * 
 * PROCESS
 * 
 * Write ("Enter your age.");
 * Read numberA
 * if numberA >= 18
 *      write ("You're an adult.")
 * else if numberA<0
 *      write ("You're not born.");
 * else 
 *      write ("You're a minor.");
*/

using System.Diagnostics.Metrics;

int numberA;

Console.WriteLine("Enter your age.");
numberA = int.Parse(Console.ReadLine());

if (numberA >= 18) {
    Console.WriteLine("You're an adult.");
}
else if (numberA < 0) {
    Console.WriteLine("You're not born.");
}
else { 
    Console.WriteLine("You're a minor.");
}



