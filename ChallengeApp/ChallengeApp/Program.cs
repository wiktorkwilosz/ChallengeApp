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
    if (input == "q" || input=="Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wystąpił błąd wyjątku: {ex.Message}");
    }
    }
    var statistics = employee.GetStatistics();
if (statistics.Count != 0)
{

    Console.WriteLine($"Podsumowanie dla : {employee.Name}{employee.Surname}");
    Console.WriteLine($"Liczba ocen pracownika: {statistics.Count}. Suma ocen {statistics.Sum}");
    Console.WriteLine($"Średnia wyrażona literą: {statistics.AverageLetter}");
    Console.WriteLine($"Średnia z uzyskanych ocen: {statistics.Average:N2}");
    Console.WriteLine($"Najnizsza ocena: {statistics.Min}");
    Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
}






