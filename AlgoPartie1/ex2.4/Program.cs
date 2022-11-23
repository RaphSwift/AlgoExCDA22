int yearA = 0;

Console.WriteLine("Enter a year");
yearA = int.Parse(Console.ReadLine());
if (yearA % 4 == 0)
{
    Console.WriteLine("Leap year");
}
else if (yearA % 100 == 0 || yearA % 400 != 0)
{
    Console.WriteLine("Leap year");
}
else
{
    Console.WriteLine("Non leap year");
}