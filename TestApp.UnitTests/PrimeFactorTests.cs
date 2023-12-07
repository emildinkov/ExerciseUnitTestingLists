using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange
        long number = 1;

        // Act + Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(number), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long number = 5;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        // Assert
        Assert.That(result, Is.EqualTo(number));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber() // Търсим в google prime factors of 123456789123456789
    {
        // Arrange
        long number = 123456789123456789;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        // Assert
        Assert.That(result, Is.EqualTo(52579));
    }
}
