namespace LegacyApp.Tests;


public class UserServiceTests
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameIsEmpty()
    {
        //Arrange
        var userService = new UserService();

        //Act
        var result = userService.AddUser(
            null,"Kowalski","kowalski@gmail.com",
            DateTime.Parse("2000-01-01"),
            1);

        //Assert
        Assert.False(result);
    }

    [Fact]
    public void AddUser_ReturnsFalseWhenEmailWithout_At_And_Dot()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser("Jan", "Kowalski", "kowal", DateTime.Parse("2000-01-01"), 2);
        
        //Assert
        Assert.Equal(false,result);
    }
}