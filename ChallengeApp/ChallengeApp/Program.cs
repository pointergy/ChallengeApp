using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników.");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee("Kamil", "Kowalski");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else if (char.TryParse(input, out char input2) == true)
    {
        employee.AddGrade(input2);
    }
    else
    {
        employee.AddGrade(input);
    }
}
var statistics = employee.GetStatistics();

