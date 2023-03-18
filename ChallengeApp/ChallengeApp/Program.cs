using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników.");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee("Kamil", "Kowalski");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    try
    {
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
    catch (Exception ex)
    {
        Console.WriteLine($"Exception caught: {ex.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine($"{employee.Name}'s best grade is: {statistics.Max}");
Console.WriteLine($"{employee.Name}'s worst grade is: {statistics.Min}");
Console.WriteLine($"{employee.Name}'s average grade is: {statistics.Average:N2}");
Console.WriteLine($"{employee.Name}'s grade is: {statistics.AverageLetter}");

