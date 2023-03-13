namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void GetStatisticsReturnsCorrectMax()
        {
            var emp1 = new Employee("name1", "surname1");

            emp1.AddGrade(2);
            emp1.AddGrade(4);
            emp1.AddGrade(3);

            var statistics = emp1.GetStatistics();

            Assert.AreEqual(4, statistics.Max);
        }

        [Test]
        public void GetStatisticsReturnsCorrectMin()
        {
            var emp1 = new Employee("name1", "surname1");

            emp1.AddGrade(2);
            emp1.AddGrade(4);
            emp1.AddGrade(3);

            var statistics = emp1.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void GetStatisticsReturnsCorrectAverage()
        {
            var emp1 = new Employee("name1", "surname1");

            emp1.AddGrade(2);
            emp1.AddGrade(4);
            emp1.AddGrade(3);

            var statistics = emp1.GetStatistics();

            Assert.AreEqual(Math.Round(3.00, 2), Math.Round(statistics.Average, 2));
        }
    }
}