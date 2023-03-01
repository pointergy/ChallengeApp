namespace ChallengeApp
{
    class Employee
    {
        private List<int> grades;

        public string Name { get; }

        public string Surname { get; }

        public string Age { get; }

        public int sum = 0;

        public Employee(string name, string surname, string age)
        {
            this.grades = new List<int>();
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
            sum += grade;
        }
    }
}
