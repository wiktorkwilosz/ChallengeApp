
public class Tests
{


    [Test]
    public void WhenUserCollectScores_ShouldReturnSum()
    {
        //arrange
        var user = new User("Wiktor", "Kwilosz",27);
        user.AddScore(5);
        user.AddScore(6);
        user.AddBadScore(4);


        //act
        var result = user.Result;

        //assert
        Assert.AreEqual(7, result);

    }
}

