using ChallengeApp;

var employee = new Employee("Pitor", "Pipi");
employee.AddGrade(5);
employee.AddGrade(1);
employee.AddGrade(4);
employee.AddGrade(1);
employee.AddGrade(3);
var statistics = employee.GetStatisticsWithWhile();
var statistics1 = employee.GetStatisticsWithDoWhile();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithForEach();

