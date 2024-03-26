namespace LegacyApp.Tests;


public class UserServiceTests
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameIsEmpty()
    {
        //Arrange
        var userServive = new UserService();

        //Act
        var result = userServive.AddUser(
            null,"Kowalski","kowalski@gmial.com",
            DateTime.Parse("2000-01-01"),
            1);

        //Assert
        Assert.False(result);
    }
}