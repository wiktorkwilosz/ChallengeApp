using ChallengeApp;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("==========================================");
Console.WriteLine();

EmployeeInFile employee = new EmployeeInFile("Wiktor", "Kwilosz");
employee.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine($"Dodano nową ocenę");

}
Console.WriteLine(employee.Name);
Console.WriteLine(employee.Surname);

Console.WriteLine();    
Console.WriteLine("Wprowadż litere od 1 do 100 lub wpisz Q żeby wyjść");


while (true)
{
    Console.WriteLine("podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"exeption catched: {ex.Message}");
    }
    }
    var statistics = employee.GetStatistics();

    Console.WriteLine($"averageletter: {statistics.AverageLetter}");
    Console.WriteLine($"average: {statistics.Average:N2}");
    Console.WriteLine($"min: {statistics.Min}");
    Console.WriteLine($"max: {statistics.Max}");







