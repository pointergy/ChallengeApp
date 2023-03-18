using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade (float grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        //public void AddGrade(double grade)
        //{
        //    if (grade>= 0 && grade <= 100)
        //    {
        //        this.grades.Add((float)grade);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid grade value");
        //    }
        //}

        //public void AddGrade(long grade)
        //{
        //    if (grade >= 0 && grade <= 100)
        //    {
        //        this.grades.Add((long)grade);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid grade value");
        //    }
        //}

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Grade is not a number");
            }
        }

        //public void AddGrade(int grade)
        //{
        //    if (grade >= 0 && grade <= 100)
        //    {
        //        this.grades.Add((int)grade);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid grade value");
        //    }
        //}       

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'a':
                case 'A':
                    this.grades.Add(100);
                    break;
                case 'b':
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'c':
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'd':
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'e':
                case 'E':
                    this.grades.Add(20);
                    break;
                case 'F':
                case 'f':
                    this.grades.Add(0);
                    break;
                case '1':
                    this.grades.Add(1);
                    break;
                case '0':
                    this.grades.Add(0);
                    break;
                case '2':
                    this.grades.Add(2);
                    break;
                case '3':
                    this.grades.Add(3);
                    break;
                case '4':
                    this.grades.Add(4);
                    break;
                case '5':
                    this.grades.Add(5);
                    break;
                case '6':
                    this.grades.Add(6);
                    break;
                case '7':
                    this.grades.Add(7);
                    break;
                case '8':
                    this.grades.Add(8);
                    break;
                case '9':
                    this.grades.Add(9);
                    break;
                default:
                    throw new Exception("Wrong letter!");
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
