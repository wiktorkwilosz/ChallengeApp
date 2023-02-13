

var employee = new Employee("Wiktor", "Kwilosz");
employee.AddGrade(6);
employee.AddGrade(7);
employee.AddGrade(8);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");