using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string email = "test@example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(email);

        // Assert
        Assert.IsTrue(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string email = "test.example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(email);

        // Assert
        Assert.IsFalse(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string? email = null;

        // Act
        bool isValidEmail = Email.IsValidEmail(email);

        // Assert
        Assert.IsFalse(isValidEmail);
    }
}
