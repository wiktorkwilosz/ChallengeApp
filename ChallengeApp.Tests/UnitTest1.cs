

public class Tests
{

    [Test]
    public void WhenNumbersAreEqualThenTestShouldBePositive()
    {
        int number1 = 15;
        int number2 = 15;

        Assert.AreEqual(number1, number2);

    }
    [Test]
    public void WhenTwoFloatNumbersAreNotEqualTestBecomePositive()
    {
        float number3 = 3.14f;
        float number4 = 3.155f;
        Assert.AreNotEqual(number3, number4);

    }
    [Test]
    public void WhenTwoStringsAreNotSameThanTestShouldBePositive()
    {
        string name1 = "Wiktor";
        string name2 = "Adam";

        Assert.AreNotSame(name1, name2);
    }

    [Test]
    public void WhenTwoUserAreNotEqualThanTestBecomePositive()
    {
        var user1 = GetUser("Wiktor", "Kwilosz", 27);
        var user2 = GetUser("Wiktor", "Kwilosz", 27);

        Assert.AreNotEqual(user1, user2);



    }
    private User GetUser(string name, string surname, int age)
    {
        return new User(name, surname, age);
    }

}