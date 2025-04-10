using Hypertext;
using Hypertext.Bootstrap5;
using Xunit;
using JetBrains.Annotations;
using System.Linq;

namespace Hypertext.Bootstrap5.Tests;

[TestSubject(typeof(Components.Breadcrumb))]
public class BreadcrumbTest
{
    [Fact]
    [UsedImplicitly]
    public void Default_ShouldRenderEmptyBreadcrumb_WhenNoLinksProvided()
    {
        // Arrange
        var expectedClass = BootstrapConstants.Breadcrumb;
        var expectedAria = BootstrapConstants.Breadcrumb;

        // Act
        var breadcrumb = Components.Breadcrumb.Default();

        // Assert
        var rendered = breadcrumb.Render();
        Assert.Contains("nav", rendered);
        Assert.Contains($"aria-label=\"{expectedAria}\"", rendered);
        Assert.Contains($"class=\"{expectedClass}\"", rendered);
        Assert.DoesNotContain("li", rendered); // No list items expected
    }

    [Fact]
    [UsedImplicitly]
    public void Default_ShouldRenderSingleLink()
    {
        // Arrange
        var link = Html.A("#", Html.Text("Home"));
        var expectedClass = BootstrapConstants.BreadcrumbItem;

        // Act
        var breadcrumb = Components.Breadcrumb.Default(link);

        // Assert
        var rendered = breadcrumb.Render();
        Assert.Contains("li", rendered);
        Assert.Contains($"class=\"{expectedClass}\"", rendered);
        Assert.Contains("<a href=\"#\">Home</a>", rendered); // Link content validation
    }

    [Fact]
    [UsedImplicitly]
    public void Default_ShouldRenderMultipleLinks()
    {
        // Arrange
        var links = new[]
        {
            Html.A("#", Html.Text("Home")),
            Html.A("#about", Html.Text("About")),
            Html.A("#contact", Html.Text("Contact"))
        };
        var expectedClass = BootstrapConstants.BreadcrumbItem;

        // Act
        var breadcrumb = Components.Breadcrumb.Default(links);

        // Assert
        var rendered = breadcrumb.Render();
        Assert.Contains("nav", rendered);
        Assert.Contains("ol", rendered);
        Assert.Equal(links.Length, rendered.Split("<li").Length - 1); // Count validation
        Assert.Contains($"class=\"{expectedClass}\"", rendered);
        Assert.Contains("<a href=\"#\">Home</a>", rendered);
        Assert.Contains("<a href=\"#about\">About</a>", rendered);
        Assert.Contains("<a href=\"#contact\">Contact</a>", rendered);
    }

    [Fact]
    [UsedImplicitly]
    public void Default_ShouldHandleNullLinksGracefully()
    {
        // Arrange
        HtmlElement[] links = null!;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Components.Breadcrumb.Default(links));
    }

    [Fact]
    [UsedImplicitly]
    public void Default_ShouldRenderCorrectOutput_WhenLinksContainSpecialCharacters()
    {
        // Arrange
        var link = Html.A("#", Html.Text("H<>\"&'me"));

        // Act
        var breadcrumb = Components.Breadcrumb.Default(link);

        // Assert
        var rendered = breadcrumb.Render();
        Assert.Contains("&lt;&gt;&quot;&amp;&apos;me", rendered);
    }

    [Fact]
    [UsedImplicitly]
    public void Default_ShouldAllowComplexLinkStructure()
    {
        // Arrange
        var links = new[]
        {
            Html.A("#", Html.Text("Home")),
            Html.A("#services", Html.Span(Html.Text("Services")), Html.Span(Html.Text("Info")))
        };

        // Act
        var breadcrumb = Components.Breadcrumb.Default(links);

        // Assert
        var rendered = breadcrumb.Render();
        Assert.Contains("<a href=\"#\"><span>Services</span><span>Info</span></a>", rendered);
    }

    [Fact]
    [UsedImplicitly]
    public void Default_ShouldHandleDuplicateLinksProperly()
    {
        // Arrange
        var links = new[]
        {
            Html.A("#", Html.Text("Home")),
            Html.A("#", Html.Text("Home"))
        };

        // Act
        var breadcrumb = Components.Breadcrumb.Default(links);

        // Assert
        var rendered = breadcrumb.Render();
        Assert.Equal(2, rendered.Split("<a href=\"#\">Home</a>").Length - 1);
    }

    [Fact]
    [UsedImplicitly]
    public void Default_ShouldWorkWithEmptyTextInLinks()
    {
        // Arrange
        var links = new[]
        {
            Html.A("#", Html.Text(string.Empty)),
            Html.A("#", Html.Text("About"))
        };

        // Act
        var breadcrumb = Components.Breadcrumb.Default(links);

        // Assert
        var rendered = breadcrumb.Render();
        Assert.Contains("<a href=\"#\"></a>", rendered);
        Assert.Contains("<a href=\"#\">About</a>", rendered);
    }

    [Fact]
    [UsedImplicitly]
    public void Default_ShouldRenderChildrenInOrder()
    {
        // Arrange
        var links = new[]
        {
            Html.A("#first", Html.Text("First")),
            Html.A("#second", Html.Text("Second")),
            Html.A("#third", Html.Text("Third"))
        };

        // Act
        var breadcrumb = Components.Breadcrumb.Default(links);

        // Assert
        var rendered = breadcrumb.Render();
        Assert.True(rendered.IndexOf("<a href=\"#first\">First</a>") < rendered.IndexOf("<a href=\"#second\">Second</a>"));
        Assert.True(rendered.IndexOf("<a href=\"#second\">Second</a>") < rendered.IndexOf("<a href=\"#third\">Third</a>"));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    [InlineData(50)]
    [UsedImplicitly]
    public void Default_ShouldRenderLargeNumberOfLinks(int count)
    {
        // Arrange
        var links = Enumerable.Range(1, count).Select(i => Html.A($"#{i}", Html.Text($"Link {i}"))).ToArray();

        // Act
        var breadcrumb = Components.Breadcrumb.Default(links);

        // Assert
        var rendered = breadcrumb.Render();
        Assert.Equal(count, rendered.Split("<li").Length - 1);
    }
}