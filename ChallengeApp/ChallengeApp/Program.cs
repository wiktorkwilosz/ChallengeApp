// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var gender = "Kobieta";
var age = 20;
string name = "Ewa";

if (gender == "kobieta" && age < 30)
{

    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name=="Ewa" && age > 18)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 || gender != "kobieta")
{
    Console.WriteLine("Niepelnoletni mężczyzna");

}
