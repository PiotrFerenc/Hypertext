using JetBrains.Annotations;

namespace Hypertext.Bootstrap5.Tests;

[TestSubject(typeof(Content.Typography))]
public class TypographyTest
{
    [Theory]
    [InlineData("Hello World", BootstrapConstants.H1)]
    [InlineData("", BootstrapConstants.H1)]
    public void H1_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.H1(text);
        Assert.NotNull(result);
        Assert.Equal($"<p class=\"{expectedClass}\">{text}</p>", result.Render());
    }

    [Theory]
    [InlineData("Hello World", BootstrapConstants.H2)]
    [InlineData("", BootstrapConstants.H2)]
    public void H2_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.H2(text);
        Assert.NotNull(result);
        Assert.Equal($"<p class=\"{expectedClass}\">{text}</p>", result.Render());
    }

    [Theory]
    [InlineData("Hello World", BootstrapConstants.H3)]
    public void H3_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.H3(text);
        Assert.NotNull(result);
        Assert.Equal($"<p class=\"{expectedClass}\">{text}</p>", result.Render());
    }

    [Theory]
    [InlineData("Hello World", BootstrapConstants.H4)]
    public void H4_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.H4(text);
        Assert.NotNull(result);
        Assert.Equal($"<p class=\"{expectedClass}\">{text}</p>", result.Render());
    }

    [Theory]
    [InlineData("Hello World", BootstrapConstants.H5)]
    public void H5_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.H5(text);
        Assert.NotNull(result);
        Assert.Equal($"<p class=\"{expectedClass}\">{text}</p>", result.Render());
    }

    [Theory]
    [InlineData("Hello World", BootstrapConstants.H6)]
    public void H6_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.H6(text);
        Assert.NotNull(result);
        Assert.Equal($"<p class=\"{expectedClass}\">{text}</p>", result.Render());
    }

    [Theory]
    [InlineData("Display Text", BootstrapConstants.Display1)]
    public void Display1_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.Display1(text);
        Assert.NotNull(result);
        Assert.Equal($"<h1 class=\"{expectedClass}\">{text}</h1>", result.Render());
    }

    [Theory]
    [InlineData("Display Text", BootstrapConstants.Display2)]
    public void Display2_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.Display2(text);
        Assert.NotNull(result);
        Assert.Equal($"<h1 class=\"{expectedClass}\">{text}</h1>", result.Render());
    }

    [Theory]
    [InlineData("Display Text", BootstrapConstants.Display3)]
    public void Display3_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.Display3(text);
        Assert.NotNull(result);
        Assert.Equal($"<h1 class=\"{expectedClass}\">{text}</h1>", result.Render());
    }

    [Theory]
    [InlineData("Display Text", BootstrapConstants.Display4)]
    public void Display4_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.Display4(text);
        Assert.NotNull(result);
        Assert.Equal($"<h1 class=\"{expectedClass}\">{text}</h1>", result.Render());
    }

    [Theory]
    [InlineData("Display Text", BootstrapConstants.Display5)]
    public void Display5_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.Display5(text);
        Assert.NotNull(result);
        Assert.Equal($"<h1 class=\"{expectedClass}\">{text}</h1>", result.Render());
    }

    [Theory]
    [InlineData("Display Text", BootstrapConstants.Display6)]
    public void Display6_ShouldReturnHtmlElementWithCorrectTextAndClass(string text, string expectedClass)
    {
        var result = Content.Typography.Display6(text);
        Assert.NotNull(result);
        Assert.Equal($"<h1 class=\"{expectedClass}\">{text}</h1>", result.Render());
    }

    [Theory]
    [InlineData("Highlighted text")]
    public void Mark_ShouldReturnHtmlElementWithMarkTag(string text)
    {
        var result = Content.Typography.Mark(text);
        Assert.NotNull(result);
        Assert.Equal($"<mark>{text}</mark>", result.Render());
    }

    [Theory]
    [InlineData("Deleted text")]
    public void Deleted_ShouldReturnHtmlElementWithDelTag(string text)
    {
        var result = Content.Typography.Deleted(text);
        Assert.NotNull(result);
        Assert.Equal($"<del>{text}</del>", result.Render());
    }

    [Theory]
    [InlineData("Strikethrough text")]
    public void Strikethrough_ShouldReturnHtmlElementWithSTag(string text)
    {
        var result = Content.Typography.Strikethrough(text);
        Assert.NotNull(result);
        Assert.Equal($"<s>{text}</s>", result.Render());
    }

    [Theory]
    [InlineData("Inserted text")]
    public void Inserted_ShouldReturnHtmlElementWithInsTag(string text)
    {
        var result = Content.Typography.Inserted(text);
        Assert.NotNull(result);
        Assert.Equal($"<ins>{text}</ins>", result.Render());
    }

    [Theory]
    [InlineData("Underlined text")]
    public void Underline_ShouldReturnHtmlElementWithUTag(string text)
    {
        var result = Content.Typography.Underline(text);
        Assert.NotNull(result);
        Assert.Equal($"<u>{text}</u>", result.Render());
    }

    [Theory]
    [InlineData("Small text")]
    public void Small_ShouldReturnHtmlElementWithSmallTag(string text)
    {
        var result = Content.Typography.Small(text);
        Assert.NotNull(result);
        Assert.Equal($"<small>{text}</small>", result.Render());
    }

    [Theory]
    [InlineData("Strong text")]
    public void Strong_ShouldReturnHtmlElementWithStrongTag(string text)
    {
        var result = Content.Typography.Strong(text);
        Assert.NotNull(result);
        Assert.Equal($"<strong>{text}</strong>", result.Render());
    }

    [Theory]
    [InlineData("Emphasized text")]
    public void Emphasized_ShouldReturnHtmlElementWithEmTag(string text)
    {
        var result = Content.Typography.Emphasized(text);
        Assert.NotNull(result);
        Assert.Equal($"<em>{text}</em>", result.Render());
    }
}