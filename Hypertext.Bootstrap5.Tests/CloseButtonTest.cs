using Hypertext.Bootstrap5;
using JetBrains.Annotations;
using Xunit;

namespace Hypertext.Bootstrap5.Tests;

[TestSubject(typeof(Components.CloseButton))]
public class CloseButtonTest
{
    [Fact]
    public void Close_ShouldReturnHtmlElementWithCloseButtonAttributes()
    {
        // Act
        var result = Components.CloseButton.Close();

        // Assert
        Assert.NotNull(result);
        Assert.IsAssignableFrom<HtmlElement>(result);

        // Verify that the button has the correct class
        Assert.Contains("class", result.ToString());
        Assert.Contains(BootstrapConstants.CloseButton, result.ToString());

        // Verify the aria-label attribute
        Assert.Contains("aria-label", result.ToString());
        Assert.Contains("Close", result.ToString());

        // Verify the type attribute
        Assert.Contains("type", result.ToString());
        Assert.Contains("button", result.ToString());

        // Ensure no other unexpected attributes exist
        // Additional assertions can extend here if new features are added to the Close method
    }

    [Fact]
    public void Close_ShouldAllowChainingAdditionalMethods()
    {
        // Act
        var result = Components.CloseButton.Close()
            .WithId("close-button-id")
            .WithStyle("color:red");

        // Assert
        Assert.NotNull(result);
        Assert.IsAssignableFrom<HtmlElement>(result);

        var resultString = result.ToString();

        // Verify ID attribute
        Assert.Contains("id", resultString);
        Assert.Contains("close-button-id", resultString);

        // Verify style attribute
        Assert.Contains("style", resultString);
        Assert.Contains("color:red", resultString);
    }

    [Fact]
    public void Close_ShouldBeReusableForMultipleInvocations()
    {
        // Act
        var firstButton = Components.CloseButton.Close();
        var secondButton = Components.CloseButton.Close();

        // Assert
        Assert.NotNull(firstButton);
        Assert.NotNull(secondButton);
        Assert.IsAssignableFrom<HtmlElement>(firstButton);
        Assert.IsAssignableFrom<HtmlElement>(secondButton);

        Assert.NotSame(firstButton, secondButton);
    }
}