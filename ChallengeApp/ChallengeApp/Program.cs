using ChallengeApp;

var emp1 = new Employee("Kamil", "Kowalski", "54");
var emp2 = new Employee("Magda", "Nowak", "21");
var emp3 = new Employee("Bartek", "Pudzianowski", "49");

emp1.AddGrade(4);
emp1.AddGrade(4);
emp1.AddGrade(4);
emp1.AddGrade(4);
emp1.AddGrade(4);

emp2.AddGrade(3);
emp2.AddGrade(3);
emp2.AddGrade(3);
emp2.AddGrade(3);
emp2.AddGrade(3);

emp3.AddGrade(2);
emp3.AddGrade(2);
emp3.AddGrade(2);
emp3.AddGrade(2);
emp3.AddGrade(2);

List<Employee> employees = new List<Employee>()
{
    emp1, emp2, emp3
};

int maxResult = 0;
Employee employeeWithMaxResult = null;

foreach(var emp in employees)
{
    if(emp.sum > maxResult)
    {
        employeeWithMaxResult = emp;
    }
    maxResult = emp.sum;
}

Console.WriteLine($"Employee of the month: {employeeWithMaxResult.Name} {employeeWithMaxResult.Surname}" +
    $" {employeeWithMaxResult.Age} with the score: {employeeWithMaxResult.sum}");