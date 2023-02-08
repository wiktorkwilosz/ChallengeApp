var User1 = new User("Wiktor", "Kwilosz", 27);
User1.AddScore(5);
User1.AddScore(6);
User1.AddScore(9);
User1.AddScore(7);
User1.AddScore(4);

var User2 = new User("Jan", "Kowalski", 20);
User2.AddScore(3);
User2.AddScore(5);
User2.AddScore(4);
User2.AddScore(9);
User2.AddScore(8);

var User3 = new User("Ewa", "Kowalska", 19);
User3.AddScore(1);
User3.AddScore(2);
User3.AddScore(3);
User3.AddScore(4);
User3.AddScore(5);

List<User> Users = new List<User>()
{
    User1, User2, User3
};
int MaxResult = -1;
User UsersWithMaxResult = null;

foreach (var user in Users)
{
    if (user.Result > MaxResult)
    {
        MaxResult = user.Result;
        UsersWithMaxResult = user;
    }

}
Console.WriteLine("Pracownik z najwyższą ilością punktów to:" + UsersWithMaxResult.Name + " " + UsersWithMaxResult.Surname + " " + "Lat" + UsersWithMaxResult.Age);
Console.WriteLine("Suma punktów:" + UsersWithMaxResult.Result);
