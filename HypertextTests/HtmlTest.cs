using Hypertext;
using JetBrains.Annotations;

namespace HypertextTests;

[TestSubject(typeof(Html))]
public class HtmlTest
{
    [Fact]
    public void Tag_WithHtmlTagAndChildren_RendersCorrectly()
    {
        var children = new[] { new HtmlText("child1"), new HtmlText("child2") };
        var result = Html.Tag(HtmlTag.Div, children);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("div", ((HtmlNode)result).Tag);
        Assert.Equal(children, ((HtmlNode)result).Children);
    }

    [Fact]
    public void Tag_WithStringNameAndChildren_RendersCorrectly()
    {
        var children = new[] { new HtmlText("child1"), new HtmlText("child2") };
        var result = Html.Tag("customTag", children);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("customTag", ((HtmlNode)result).Tag);
        Assert.Equal(children, ((HtmlNode)result).Children);
    }

    [Fact]
    public void Text_GeneratesHtmlTextCorrectly()
    {
        var content = "Sample Text";
        var result = Html.Text(content);

        Assert.IsType<HtmlText>(result);
        Assert.Equal(content, ((HtmlText)result).Content);
    }

    [Fact]
    public void Div_WithChildren_RendersCorrectly()
    {
        var children = new[] { Html.Text("Child1"), Html.Text("Child2") };
        var result = Html.Div(children);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("div", ((HtmlNode)result).Tag);
        Assert.Equal(children, ((HtmlNode)result).Children);
    }

    [Fact]
    public void Span_WithChildren_RendersCorrectly()
    {
        var children = new[] { Html.Text("Child1"), Html.Text("Child2") };
        var result = Html.Span(children);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("span", ((HtmlNode)result).Tag);
        Assert.Equal(children, ((HtmlNode)result).Children);
    }

    [Fact]
    public void Span_WithStringText_RendersCorrectly()
    {
        var text = "Sample Span Text";
        var result = Html.Span(text);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("span", ((HtmlNode)result).Tag);
        Assert.Single(((HtmlNode)result).Children);
        Assert.IsType<HtmlText>(((HtmlNode)result).Children.First());
        Assert.Equal(text, ((HtmlText)((HtmlNode)result).Children.First()).Content);
    }

    [Fact]
    public void P_WithChildren_RendersCorrectly()
    {
        var children = new[] { Html.Text("Paragraph1"), Html.Text("Paragraph2") };
        var result = Html.P(children);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("p", ((HtmlNode)result).Tag);
        Assert.Equal(children, ((HtmlNode)result).Children);
    }

    [Fact]
    public void P_WithStringText_RendersCorrectly()
    {
        var text = "Sample Paragraph Text";
        var result = Html.P(text);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("p", ((HtmlNode)result).Tag);
        Assert.Single(((HtmlNode)result).Children);
        Assert.IsType<HtmlText>(((HtmlNode)result).Children.First());
        Assert.Equal(text, ((HtmlText)((HtmlNode)result).Children.First()).Content);
    }

    [Fact]
    public void A_WithHrefAndChildren_RendersCorrectly()
    {
        var href = "https://example.com";
        var children = new[] { Html.Text("link text") };
        var result = Html.A(href, children);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("a", ((HtmlNode)result).Tag);
        Assert.Equal(children, ((HtmlNode)result).Children);
        Assert.Equal(href, ((HtmlElement)result).WithHref(href).Attributes["href"]);
    }

    [Fact]
    public void Img_WithSourceAndAlt_RendersCorrectly()
    {
        var src = "image.jpg";
        var alt = "Sample Image";
        var result = Html.Img(src, alt);

        Assert.IsType<SelfClosingTag>(result);
        Assert.Equal("img", ((SelfClosingTag)result).Tag);
        Assert.Equal(src, ((SelfClosingTag)result).Attributes["src"]);
        Assert.Equal(alt, ((SelfClosingTag)result).Attributes["alt"]);
    }

    [Fact]
    public void Button_WithText_RendersCorrectly()
    {
        var text = "Click Me";
        var result = Html.Button(text);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("button", ((HtmlNode)result).Tag);
        Assert.Single(((HtmlNode)result).Children);
        Assert.IsType<HtmlText>(((HtmlNode)result).Children.First());
        Assert.Equal(text, ((HtmlText)((HtmlNode)result).Children.First()).Content);
    }

    [Fact]
    public void Fragment_WithChildren_RendersCorrectly()
    {
        var children = new[] { Html.Text("Fragment1"), Html.Text("Fragment2") };
        var result = Html.Fragment(children);

        Assert.IsType<HtmlFragment>(result);
        Assert.Equal(children, ((HtmlFragment)result).Children);
    }

    [Fact]
    public void TextArea_WithValue_RendersCorrectly()
    {
        var value = "Sample Textarea Value";
        var result = Html.TextArea(value);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("textarea", ((HtmlNode)result).Tag);
        Assert.Single(((HtmlNode)result).Children);
        Assert.IsType<HtmlText>(((HtmlNode)result).Children.First());
        Assert.Equal(value, ((HtmlText)((HtmlNode)result).Children.First()).Content);
    }

    [Fact]
    public void Select_WithOptions_RendersCorrectly()
    {
        var options = new[] { Html.Text("Option1"), Html.Text("Option2") };
        var result = Html.Select(options);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("select", ((HtmlNode)result).Tag);
        Assert.Equal(options, ((HtmlNode)result).Children);
    }

    [Fact]
    public void Nav_WithItems_RendersCorrectly()
    {
        var items = new[] { Html.Text("NavItem1"), Html.Text("NavItem2") };
        var result = Html.Nav(items);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("nav", ((HtmlNode)result).Tag);
        Assert.Equal(items, ((HtmlNode)result).Children);
    }

    [Fact]
    public void Ol_WithItems_RendersCorrectly()
    {
        var items = new[] { Html.Text("ListItem1"), Html.Text("ListItem2") };
        var result = Html.Ol(items);

        Assert.IsType<HtmlNode>(result);
        Assert.Equal("ol", ((HtmlNode)result).Tag);
        Assert.Equal(items, ((HtmlNode)result).Children);
    }
}