using Hypertext;
using JetBrains.Annotations;

namespace HypertextTests;

[TestSubject(typeof(Html))]
public class HtmlTest
{
    [Fact]
    public void Tag_WithNameAndChildren_ShouldRenderCorrectHtml()
    {
        var child = Html.Text("content");
        var tag = Html.Tag(HtmlTag.Div, child);
        Assert.Equal("<div>content</div>", tag.Render());
    }

    [Fact]
    public void Tag_WithNameAttributesAndChildren_ShouldRenderCorrectHtml()
    {
        var child = Html.Text("content");
        var attributes = new Dictionary<string, string> { { "class", "test" } };
        var tag = Html.Tag("p", attributes, child);
        Assert.Equal("<p class=\"test\">content</p>", tag.Render());
    }

    [Fact]
    public void Text_WithContent_ShouldRenderContent()
    {
        var text = Html.Text("sample text");
        Assert.Equal("sample text", text.Render());
    }

    [Fact]
    public void Div_WithChildren_ShouldRenderCorrectHtml()
    {
        var child = Html.Text("content");
        var div = Html.Div(child);
        Assert.Equal("<div>content</div>", div.Render());
    }

    [Fact]
    public void Span_WithChildren_ShouldRenderCorrectHtml()
    {
        var child = Html.Text("content");
        var span = Html.Span(child);
        Assert.Equal("<span>content</span>", span.Render());
    }

    [Fact]
    public void P_WithChildren_ShouldRenderCorrectHtml()
    {
        var child = Html.Text("paragraph content");
        var p = Html.P(child);
        Assert.Equal("<p>paragraph content</p>", p.Render());
    }

    [Fact]
    public void P_WithText_ShouldRenderCorrectHtml()
    {
        var p = Html.P("paragraph text");
        Assert.Equal("<p>paragraph text</p>", p.Render());
    }

    [Fact]
    public void A_WithHrefAndChildren_ShouldRenderCorrectHtml()
    {
        var child = Html.Text("link text");
        var anchor = Html.A("https://example.com", child);
        Assert.Equal("<a href=\"https://example.com\">link text</a>", anchor.Render());
    }

    [Fact]
    public void Ul_WithChildren_ShouldRenderCorrectHtml()
    {
        var child = Html.Li(Html.Text("item 1"));
        var ul = Html.Ul(child);
        Assert.Equal("<ul><li>item 1</li></ul>", ul.Render());
    }

    [Fact]
    public void Img_WithSrcAndAlt_ShouldRenderCorrectHtml()
    {
        var img = Html.Img("image.jpg", "An image");
        Assert.Equal("<img src=\"image.jpg\" alt=\"An image\" />", img.Render());
    }

    [Fact]
    public void Img_WithSrcAndNoAlt_ShouldRenderCorrectHtml()
    {
        var img = Html.Img("image.jpg");
        Assert.Equal("<img src=\"image.jpg\" alt=\"\" />", img.Render());
    }

    [Fact]
    public void Input_WithTypeNameAndValue_ShouldRenderCorrectHtml()
    {
        var input = Html.Input("text", "username", "defaultUser");
        Assert.Equal("<input type=\"text\" name=\"username\" value=\"defaultUser\" />", input.Render());
    }

    [Fact]
    public void Button_WithTextAndAttributes_ShouldRenderCorrectHtml()
    {
        var attributes = new Dictionary<string, string> { { "class", "btn" } };
        var button = Html.Button("Click Me", attributes);
        Assert.Equal("<button class=\"btn\">Click Me</button>", button.Render());
    }

    [Fact]
    public void Fragment_WithChildren_ShouldRenderCorrectHtml()
    {
        var child1 = Html.Text("child1");
        var child2 = Html.Text("child2");
        var fragment = Html.Fragment(child1, child2);
        Assert.Equal("child1child2", fragment.Render());
    }

    [Fact]
    public void Table_WithRows_ShouldRenderCorrectHtml()
    {
        var row = Html.Tr(Html.Td("Cell 1"), Html.Td("Cell 2"));
        var table = Html.Table(new[] { row });
        Assert.Equal("<table><tr><td>Cell 1</td><td>Cell 2</td></tr></table>", table.Render());
    }

    [Fact]
    public void HtmlNode_WithAttributes_ShouldRenderCorrectHtml()
    {
        var node = Html.Tag("custom", new Dictionary<string, string> { { "data-test", "value" } });
        Assert.Equal("<custom data-test=\"value\"></custom>", node.Render());
    }

    [Fact]
    public void HtmlNode_WithoutAttributes_ShouldRenderCorrectHtml()
    {
        var node = Html.Tag("custom");
        Assert.Equal("<custom></custom>", node.Render());
    }

    [Fact]
    public void HtmlElement_WithAttribute_ShouldAddAttribute()
    {
        var element = Html.Tag("span").WithAttribute("id", "test");
        Assert.Equal("<span id=\"test\"></span>", element.Render());
    }

    [Fact]
    public void HtmlElement_WithId_ShouldAddId()
    {
        var element = Html.Tag("div").WithId("main");
        Assert.Equal("<div id=\"main\"></div>", element.Render());
    }

    [Fact]
    public void HtmlElement_WithClass_ShouldAddClass()
    {
        var element = Html.Tag("span").WithClass("highlight");
        Assert.Equal("<span class=\"highlight\"></span>", element.Render());
    }

    [Fact]
    public void HtmlElement_WithData_ShouldAddDataAttribute()
    {
        var element = Html.Tag("div").WithData("key", "value");
        Assert.Equal("<div data-key=\"value\"></div>", element.Render());
    }

    [Fact]
    public void HtmlElement_WithAria_ShouldAddAriaAttribute()
    {
        var element = Html.Tag("div").WithAria("label", "Example");
        Assert.Equal("<div aria-label=\"Example\"></div>", element.Render());
    }

    [Fact]
    public void HtmlElement_WithRole_ShouldAddRoleAttribute()
    {
        var element = Html.Tag("span").WithRole("button");
        Assert.Equal("<span role=\"button\"></span>", element.Render());
    }

    [Fact]
    public void HtmlElement_WithOnClick_ShouldAddOnClick()
    {
        var element = Html.Tag("div").WithOnClick("alert('clicked')");
        Assert.Equal("<div onclick=\"alert('clicked')\"></div>", element.Render());
    }
}