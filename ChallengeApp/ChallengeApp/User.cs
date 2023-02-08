public class User
{


    private List<int> scores = new List<int>();

    public User(string Name, string Surname, int Age)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }
    public int Result


    {
        get
        {
            return this.scores.Sum();

        }
    }
    public void AddScore(int newscores)
    {
        this.scores.Add(newscores);
    }

}
