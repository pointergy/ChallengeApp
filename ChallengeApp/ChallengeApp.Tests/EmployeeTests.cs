namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoGrades_ShouldReturnCorrectResult()
        {
            var emp = new Employee("Piotr");
            emp.AddGrade(5);
            emp.AddGrade(6);
            emp.MinusGrade(-11);
            var result = emp.sum;

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}