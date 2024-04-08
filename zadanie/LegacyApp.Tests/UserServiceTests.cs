namespace LegacyApp.Tests;


public class UserServiceTests
{
    [Fact]
    public void AddUser_Returns_False_When_FirstName_Is_Empty()
    {
        //Arrange
        var userService = new UserService();

        //Act
        var result = userService.AddUser(
            null, "Kowalski", "kowalski@gmail.com",
            DateTime.Parse("2000-01-01"),
            1);

        //Assert
        Assert.False(result);
    }

    [Fact]
    public void AddUser_Returns_False_When_Email_Without_At_And_Dot()
    {
        //Arrange
        var userService = new UserService();

        //Act
        var result = userService.AddUser("Jan", "Kowalski", "kowal", DateTime.Parse("2000-01-01"), 2);

        //Assert
        Assert.Equal(false, result);
    }

    [Fact]
    public void AddUser_Returns_False_When_Age_Less_Than_21()
    {
        //Arrange
        var userService = new UserService();

        //Act
        var result = userService.AddUser("Jan", "Kowalski", "kowal", DateTime.Parse("2020-01-01"), 2);

        //Assert
        Assert.Equal(false, result);
    }

}
