/* Ex2.2
 * 
 * VARIABLES
 * 
 * entier numberA
 * entier numberB
 * 
 * PROCESS
 * 
 * 
 * Write("Saisir A");
 * Read(numberA);
 *  Write("Saisir B");
 * Read(numberB);
 * 
 * SI numberA<numberB
 *      write(numberA,", ",numberB)
 * SINON SI numberA>numberB
 *      write(numberB,", ",numberA)
 * SINON
 *      write(numberA," = ",numberB)
 * 
 * FINSI
 * 
 * 
 */

int numberA;
int numberB;

Console.WriteLine("Saisir A");
numberA=int.Parse(Console.ReadLine());

Console.WriteLine("Saisir B");
numberB = int.Parse(Console.ReadLine());

if (numberA < numberB){
    Console.WriteLine(numberA+ ", "+ numberB);
}
else if (numberA > numberB)
{
    Console.WriteLine(numberB+ ", "+ numberA);
}
else
{
    Console.WriteLine(numberA+ " = "+ numberB);
}
 