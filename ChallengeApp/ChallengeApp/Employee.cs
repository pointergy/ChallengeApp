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
                Console.WriteLine("Invalid grade value");
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
                Console.WriteLine("Grade is not a number");
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
                default:
                    Console.WriteLine("Wrong letter!");
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
    
            switch(statistics.Average)
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

            statistics.Average /= this.grades.Count;
            Console.WriteLine($"Average: {statistics.Average:N2}");
            Console.WriteLine($"Min: {statistics.Min}");
            Console.WriteLine($"Max: {statistics.Max}");
            Console.WriteLine(statistics.AverageLetter);
            return statistics;
        }   
    }
}
