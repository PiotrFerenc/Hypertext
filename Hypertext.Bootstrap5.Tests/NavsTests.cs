namespace Hypertext.Bootstrap5.Tests;

public class NavsTests
{
    [Fact]
    public void Nav_ShouldRenderCorrectHtml_ForGivenLinks()
    {
        // Arrange
        var links = new[]
        {
            ("https://example.com/home", "Home", true),
            ("https://example.com/about", "About", false),
            ("https://example.com/contact", "Contact", false)
        };

        // Act
        var result = Components.Navs.Nav(links);

        // Assert
        var renderedHtml = result.Render();
        const string expectedHtml = 
            "<ul class=\"nav\">" +
            "<li class=\"nav-item\">" +
            "<a href=\"https://example.com/home\" class=\"nav-link active\" aria-current=\"page\">Home</a>" +
            "</li>" +
            "<li class=\"nav-item\">" +
            "<a href=\"https://example.com/about\" class=\"nav-link\">About</a>" +
            "</li>" +
            "<li class=\"nav-item\">" +
            "<a href=\"https://example.com/contact\" class=\"nav-link\">Contact</a>" +
            "</li>" +
            "</ul>";
        
        Assert.Equal(expectedHtml, renderedHtml);
    }
}