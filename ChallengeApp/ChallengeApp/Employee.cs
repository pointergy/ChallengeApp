namespace ChallengeApp
{
    public class Employee
    {
        public List<int> grades;

        public string Name { get; }

        public string Surname { get; }

        public string Age { get; }

        public int sum = 0;

        public Employee(string name)
        {
            this.grades = new List<int>();
            this.Name = name;
        }
        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
            sum += grade;
        }
        public void MinusGrade(int minus)
        {
            this.grades.Add(minus);
            sum += minus;
        }
    }
}
