using Hypertext.Bootstrap5;
using JetBrains.Annotations;

namespace Hypertext.Bootstrap5.Tests;

[TestSubject(typeof(Components.Alert))]
public class AlertTest
{
    [Fact]
    public void Primary_ShouldReturnHtmlElementWithCorrectClassAndRole()
    {
        // Arrange
        var child = Html.Text("Test");

        // Act
        var result = Components.Alert.Primary(child);

        // Assert
        Assert.Equal("div", (result as HtmlNode)?.Tag);
        Assert.Contains("alert alert-primary", (result as HtmlNode)?.Attributes["class"]);
        Assert.Equal("alert", (result as HtmlNode)?.Attributes["role"]);
        Assert.Contains(child, (result as HtmlNode)?.Children);
    }

    [Fact]
    public void Secondary_ShouldReturnHtmlElementWithCorrectClassAndRole()
    {
        // Arrange
        var child = Html.Text("Test");

        // Act
        var result = Components.Alert.Secondary(child);

        // Assert
        Assert.Equal("div", (result as HtmlNode)?.Tag);
        Assert.Contains("alert alert-secondary", (result as HtmlNode)?.Attributes["class"]);
        Assert.Equal("alert", (result as HtmlNode)?.Attributes["role"]);
        Assert.Contains(child, (result as HtmlNode)?.Children);
    }

    [Fact]
    public void Success_ShouldReturnHtmlElementWithCorrectClassAndRole()
    {
        // Arrange
        var child = Html.Text("Test");

        // Act
        var result = Components.Alert.Success(child);

        // Assert
        Assert.Equal("div", (result as HtmlNode)?.Tag);
        Assert.Contains("alert alert-success", (result as HtmlNode)?.Attributes["class"]);
        Assert.Equal("alert", (result as HtmlNode)?.Attributes["role"]);
        Assert.Contains(child, (result as HtmlNode)?.Children);
    }

    [Fact]
    public void Danger_ShouldReturnHtmlElementWithCorrectClassAndRole()
    {
        // Arrange
        var child = Html.Text("Test");

        // Act
        var result = Components.Alert.Danger(child);

        // Assert
        Assert.Equal("div", (result as HtmlNode)?.Tag);
        Assert.Contains("alert alert-danger", (result as HtmlNode)?.Attributes["class"]);
        Assert.Equal("alert", (result as HtmlNode)?.Attributes["role"]);
        Assert.Contains(child, (result as HtmlNode)?.Children);
    }

    [Fact]
    public void Warning_ShouldReturnHtmlElementWithCorrectClassAndRole()
    {
        // Arrange
        var child = Html.Text("Test");

        // Act
        var result = Components.Alert.Warning(child);

        // Assert
        Assert.Equal("div", (result as HtmlNode)?.Tag);
        Assert.Contains("alert alert-warning", (result as HtmlNode)?.Attributes["class"]);
        Assert.Equal("alert", (result as HtmlNode)?.Attributes["role"]);
        Assert.Contains(child, (result as HtmlNode)?.Children);
    }

    [Fact]
    public void Info_ShouldReturnHtmlElementWithCorrectClassAndRole()
    {
        // Arrange
        var child = Html.Text("Test");

        // Act
        var result = Components.Alert.Info(child);

        // Assert
        Assert.Equal("div", (result as HtmlNode)?.Tag);
        Assert.Contains("alert alert-info", (result as HtmlNode)?.Attributes["class"]);
        Assert.Equal("alert", (result as HtmlNode)?.Attributes["role"]);
        Assert.Contains(child, (result as HtmlNode)?.Children);
    }

    [Fact]
    public void Light_ShouldReturnHtmlElementWithCorrectClassAndRole()
    {
        // Arrange
        var child = Html.Text("Test");

        // Act
        var result = Components.Alert.Light(child);

        // Assert
        Assert.Equal("div", (result as HtmlNode)?.Tag);
        Assert.Contains("alert alert-light", (result as HtmlNode)?.Attributes["class"]);
        Assert.Equal("alert", (result as HtmlNode)?.Attributes["role"]);
        Assert.Contains(child, (result as HtmlNode)?.Children);
    }

    [Fact]
    public void Dark_ShouldReturnHtmlElementWithCorrectClassAndRole()
    {
        // Arrange
        var child = Html.Text("Test");

        // Act
        var result = Components.Alert.Dark(child);

        // Assert
        Assert.Equal("div", (result as HtmlNode)?.Tag);
        Assert.Contains("alert alert-dark", (result as HtmlNode)?.Attributes["class"]);
        Assert.Equal("alert", (result as HtmlNode)?.Attributes["role"]);
        Assert.Contains(child, (result as HtmlNode)?.Children);
    }

    [Fact]
    public void AlertMethods_ShouldHandleEmptyChildren()
    {
        // Act
        var resultPrimary = Components.Alert.Primary();
        var resultSecondary = Components.Alert.Secondary();
        var resultSuccess = Components.Alert.Success();
        var resultDanger = Components.Alert.Danger();
        var resultWarning = Components.Alert.Warning();
        var resultInfo = Components.Alert.Info();
        var resultLight = Components.Alert.Light();
        var resultDark = Components.Alert.Dark();

        // Assert
        Assert.Empty((resultPrimary as HtmlNode)?.Children);
        Assert.Empty((resultSecondary as HtmlNode)?.Children);
        Assert.Empty((resultSuccess as HtmlNode)?.Children);
        Assert.Empty((resultDanger as HtmlNode)?.Children);
        Assert.Empty((resultWarning as HtmlNode)?.Children);
        Assert.Empty((resultInfo as HtmlNode)?.Children);
        Assert.Empty((resultLight as HtmlNode)?.Children);
        Assert.Empty((resultDark as HtmlNode)?.Children);
    }

    [Fact]
    public void AlertMethods_ShouldAllowMultipleChildren()
    {
        // Arrange
        var child1 = Html.Text("Child 1");
        var child2 = Html.Text("Child 2");

        // Act
        var result = Components.Alert.Primary(child1, child2);

        // Assert
        Assert.Contains(child1, (result as HtmlNode)?.Children);
        Assert.Contains(child2, (result as HtmlNode)?.Children);
    }
}