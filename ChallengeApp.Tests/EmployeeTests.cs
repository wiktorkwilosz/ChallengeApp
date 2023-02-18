

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void WhenOnlyLettersAddingShowTheAverage()
        {
            var employee = new Employee("Wiktor","Kwilosz") ;
          
            employee.AddGrade('e');
            employee.AddGrade('a');
            employee.AddGrade('D');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.AverageLetter,'C');

        }
        [Test]
        public void WhenCalculationsWithCharsAndNumbersIsCorrectShowAverages()
        {
            var employee = new Employee("Wiktor", "Kwilosz");
            employee.AddGrade('B');
            employee.AddGrade(35);
            employee.AddGrade(80);
            employee.AddGrade('a');
            employee.AddGrade(60);

         
            var statistics = employee.GetStatistics();

            Assert.AreNotEqual(statistics.AverageLetter, 'C');
            Assert.AreEqual(statistics.Average, 71.0f);
        }
        [Test]
        public void WhenCalculationWithCharsAndNumbersIsCorrectShowEquals()
        {
            var employee = new Employee("Wiktor", "Kwilosz");
            employee.AddGrade('A');
            employee.AddGrade(45);
            employee.AddGrade(99);
            employee.AddGrade('c');
            employee.AddGrade(91);

            
            var statistics = employee.GetStatistics();

           
            Assert.AreEqual(statistics.AverageLetter, 'B');
            Assert.AreEqual(79, statistics.Average);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(45, statistics.Min);
        }
    }
   
    
       

 
}
