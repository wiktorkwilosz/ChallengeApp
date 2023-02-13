public class User
{


    private List<int> scores = new List<int>();

    public User(string login)
    {
        this.Login = login;
    }
    public User(string login, string password, int age)
    {
        this.Login = login;
        this.Password = password;
    }
    public string Login { get; private set; }
    public string Password { get; private set; }

    public int Result;



    
}
