using ChallengeApp;

var employee = new Employee("Pitor", "Pipi");
employee.AddGrade("2");
employee.AddGrade(400);
employee.AddGrade("Pitto");
employee.AddGrade(1);
employee.AddGrade(3);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");