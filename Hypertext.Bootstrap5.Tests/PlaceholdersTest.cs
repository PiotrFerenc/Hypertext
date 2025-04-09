using Hypertext.Bootstrap5;
using Xunit;
using JetBrains.Annotations;

namespace Hypertext.Bootstrap5.Tests;

[TestSubject(typeof(Components.Placeholders))]
public class PlaceholdersTest
{
    [Fact]
    public void Size1_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size1();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-1", result.Render());
    }

    [Fact]
    public void Size2_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size2();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-2", result.Render());
    }

    [Fact]
    public void Size3_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size3();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-3", result.Render());
    }

    [Fact]
    public void Size4_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size4();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-4", result.Render());
    }

    [Fact]
    public void Size5_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size5();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-5", result.Render());
    }

    [Fact]
    public void Size6_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size6();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-6", result.Render());
    }

    [Fact]
    public void Size7_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size7();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-7", result.Render());
    }

    [Fact]
    public void Size8_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size8();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-8", result.Render());
    }

    [Fact]
    public void Size9_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size9();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-9", result.Render());
    }

    [Fact]
    public void Size10_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size10();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-10", result.Render());
    }

    [Fact]
    public void Size11_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size11();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-11", result.Render());
    }

    [Fact]
    public void Size12_ShouldReturnHtmlElementWithCorrectClass()
    {
        // Act
        var result = Components.Placeholders.Size12();

        // Assert
        Assert.NotNull(result);
        Assert.Contains("placeholder col-12", result.Render());
    }
}