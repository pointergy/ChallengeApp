namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public List<float> grades = new List<float>();

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public void AddGrade(double grade)
        {
            this.grades.Add((float)grade);
        }

        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
        }

        public void AddGrade(char grade)
        {
            this.grades.Add(grade);
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6-":
                case "-6":
                    this.grades.Add(95);
                    break;
                case "5+":
                case "+5":
                    this.grades.Add(85);
                    break;
                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;
                case "+4":
                case "4+":
                    this.grades.Add(65);
                    break;
                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;
                case "3+":
                case "+3":
                    this.grades.Add(45);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "+2":
                case "2+":
                    this.grades.Add(25);
                    break;
                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;
                case "+1":
                case "1+":
                    this.grades.Add(5);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "6":
                    this.grades.Add(100);
                    break;
                default:
                    if (float.TryParse(grade, out float result) && result <= 100 && result >= 0)
                    {
                        this.grades.Add(result);
                    }
                    else
                    {
                        throw new Exception("Wrong grade value");
                    }
                    break;
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 90:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 70:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 50:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 30:
                    statistics.AverageLetter = 'D';
                    break;
                case var average when average >= 10:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    statistics.AverageLetter = 'F';
                    break;
            }

            return statistics;
        }
    }
}
