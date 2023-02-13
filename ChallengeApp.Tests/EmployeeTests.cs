

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void StatisticTestForMin()
        {
            var employee = new Employee("Wiktor", "Kwilosz");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(8);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, 2);

        }
        [Test]
        public void StatisticTestForMax()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(15);
            employee.AddGrade(17);
            employee.AddGrade(30);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Max, 30);
        }
        [Test]
        public void StatisticTestForAverage()
        {
            var employee = new Employee("Grzegorz", "Nowak");
            employee.AddGrade(10);
            employee.AddGrade(10);
            employee.AddGrade(2);
            var statistics = employee.GetStatistics();

            Assert.AreNotEqual(statistics.Average, 10);
        }
    }
   
    
       

 
}
