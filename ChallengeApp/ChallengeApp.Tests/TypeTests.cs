namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void StringEqualityTest()
        {
            string text1 = "text";
            string text2 = "text";

            Assert.AreEqual(text1, text2);
        }

        [Test]
        public void IntEqualityTest()
        {
            int number1 = 1;
            int number2 = 1;

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void EmployeesWithSameNameAreDiffrentObjects()
        {
            var emp1 = new Employee("name");
            var emp2 = new Employee("name");

            Assert.AreNotEqual(emp1, emp2);
        }

        [Test]
        public void EmployeesCanHaveTheSameName()
        {
            var emp1 = GetEmployee("name");
            var emp2 = GetEmployee("name");

            Assert.AreEqual(emp1.Name, emp2.Name);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
