using Microsoft.VisualBasic;
using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] intput = new string[] { "Hello" };

        // Act
        string[] result = Reverser.ReverseStrings(intput);

        // Assert
        CollectionAssert.AreEqual(result, new[] {"olleH"});
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] input = new string[] { "Hi", "Bye", };

        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
        CollectionAssert.AreEqual(result, new[] { "iH", "eyB" });
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] input = new string[] { "Hi!", "Bye." };

        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
        CollectionAssert.AreEqual(result, new[] {"!iH", ".eyB"});
    }
}
