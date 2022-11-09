/*VARIABLES
 * 
 * float radiusR;
 * float angleA;
 * float areaResult
 * 
 * 
 * PROCESS
 * 
 * Write ("Display the radiusR of a circle. ");
 * Read radiusR;
 * Write ("Display an angle A (in degrees). ");
 * Read angleA;
 * areaResult <-- Pi*radiusR*angleA / 360;
 * 
 * OUTPUT
 * 
 * Write ("Circular sector's area is: " + areaResult);
 * 
 */

double radiusR;
double angleA;
double areaResult;

Console.WriteLine("Display the radiusR of a circle. ");
radiusR = double.Parse(Console.ReadLine());
Console.WriteLine("Display an angle A (in degrees). ");
angleA = double.Parse(Console.ReadLine());


areaResult = Math.PI * radiusR * radiusR * angleA / 360;
Console.WriteLine("Circular sector's area is: " + areaResult);