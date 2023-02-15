using ChallengeApp;

var employee = new Employee("Wiktor", "Kwilosz");
employee.AddGrade("5");
employee.AddGrade("Wiktor");
employee.AddGrade(4000);
employee.AddGrade(7);
employee.AddGrade(3l);
employee.AddGrade(7f);
employee.AddGrade(8);

var statistics = employee.GetStatisticsWithForEach();
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithDoWhile();
var statistics3 = employee.GetStatisticsWithWhile();

Console.WriteLine("Pętla For Each");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");

Console.WriteLine("Pętla For");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");

Console.WriteLine("Pętla Do While");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");

Console.WriteLine("Pętla While");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");

