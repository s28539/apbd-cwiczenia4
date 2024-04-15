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
        var result = userService.AddUser("Jan", "Kowalski", "kowalskigmailcom", DateTime.Parse("2000-01-01"), 2);

        //Assert
        Assert.Equal(false, result);
    }

    [Fact]
    public void AddUser_Returns_False_When_Age_Less_Than_21()
    {
        //Arrange
        var userService = new UserService();

        //Act
        var result = userService.AddUser("Jan", "Kowalski", "kowalski@gmail.com", DateTime.Parse("2020-01-01"), 2);

        //Assert
        Assert.Equal(false, result);
    }
    [Fact]
    public void AddUser_ThrowsExceptionWhenUserDoesNotExist()
    {
        // Arrange
        var userService = new UserService();
        
        // Act
        
        Action action =()=> userService.AddUser(
            "hEHEHHEHEH", 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2000-01-01"),
            100
        );
        
        // Assert
        Assert.Throws<ArgumentException>(action);
    }
    
    [Fact]
    public void AddUser_ThrowsExceptionWhenUserNoCreditLimitExistsForUser()
    {
        var userService = new UserService();

        // Act
        Action action = () => userService.AddUser(
            "Mariusz", 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2000-01-01"),
            6
        );

        // Assert
        Assert.Throws<ArgumentException>(action);
    }
    
    [Fact]
    public void AddUser_ReturnsTrueWhenVeryImportantClient()
    {
        int id = 2;
        ClientRepository clientRepository = new ClientRepository();
        var client = clientRepository.GetById(id);
        bool result = (client.Type == "VeryImportantClient");
        
        Assert.Equal(true,result);

    }
    [Fact]
    public void AddUser_ReturnsTrueWhenImportantClient()
    {
        int id = 3;
        ClientRepository clientRepository = new ClientRepository();
        var client = clientRepository.GetById(id);
        bool result = (client.Type == "ImportantClient");
        
        Assert.Equal(true,result);

    }
    [Fact]
    public void AddUser_ReturnsTrueWhenNormalClient()
    {
        // Arrange
        var userService = new UserService();
        
        // Act
        
        var result = userService.AddUser(
            "Marcin", 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2000-01-01"),
            5
        );
       
        
        // Assert
        Assert.False(result);

    }
}
