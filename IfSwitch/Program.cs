

// If Else Statement
// ==, >=, <=, <, >, !=

using System.ComponentModel.Design;

Console.Write("Entry your Age: ");
string? age = Console.ReadLine();

int ageIs = int.Parse(age);

if (ageIs >= 30)
{
    Console.WriteLine("Get Ready to DO WORK!!");
}
else if ( 30 > ageIs && ageIs >= 20)
{
    Console.WriteLine("Time to Party.");
}
else
{
    Console.WriteLine("Too young!");
}