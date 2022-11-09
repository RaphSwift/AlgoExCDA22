
/*VARIABLES
 * 
 * double radius
 * double areaResult
 * double volumeResult
 * 
 * double Pi
 * 
 * PROCESS
 * 
 * Write ("Enter the radius of a sphere. ");
 * Read radius;
 * aireResult <-- 4*Pi*radius*radius;
 * volumeResult <-- 4/3*Pi*radius*radius*radius;
 * 
 * OUTPUT
 * 
 * Write ("The area is: " + areaResult);
 * Write ("And the volume is: " + volumeResult);
 * 
 */


double radius;
double areaResult;
double volumeResult;

Console.WriteLine("Enter the radius of a sphere. ");
radius = double.Parse(Console.ReadLine());
areaResult = 4 * Math.PI * radius * radius;
volumeResult = 4 / 3 * Math.PI * radius * radius * radius;

Console.WriteLine("The area is: " + areaResult);
Console.WriteLine("The volume is: " + volumeResult);



