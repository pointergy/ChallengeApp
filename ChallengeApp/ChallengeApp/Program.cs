var name = "Ewa";
var sex = 'F';
var age = 14;

if (name == "Ewa" && sex == 'F' && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == 'F' && age < 30)
{
    Console.WriteLine("Kobieta, poniżej 30 lat");
}
else if (sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}