using ChallengeApp;

var employee = new Employee("Wiktor", "Kwilosz");
employee.AddGrade("5");
employee.AddGrade("Wiktor");
employee.AddGrade(4000);
employee.AddGrade(7);
employee.AddGrade(3l);
employee.AddGrade(7f);
employee.AddGrade(8);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");

