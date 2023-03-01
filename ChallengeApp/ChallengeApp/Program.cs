using ChallengeApp;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("==========================================");
Console.WriteLine();

EmployeeInFile employee = new EmployeeInFile("Wiktor", "Kwilosz");


Console.WriteLine("Wprowadż litere od 1 do 100 lub wpisz Q żeby wyjść");


Console.WriteLine($"nowa ocena:");

while (true)
{
    Console.WriteLine("podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q" || input=="Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception emp)
    {
        Console.WriteLine($"exeption catched: {emp.Message}");
    }
    }
    var statistics = employee.GetStatistics();
    Console.WriteLine($"averageletter: {statistics.AverageLetter}");
    Console.WriteLine($"average: {statistics.Average}");
    Console.WriteLine($"min: {statistics.Min}");
    Console.WriteLine($"max: {statistics.Max}");







