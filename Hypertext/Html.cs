namespace Hypertext;

using System.Collections.Generic;

public static class Html
{
    public static HtmlElement Tag(string name, params HtmlElement[] children) => new HtmlNode(name, new Dictionary<string, string>(), children);

    public static HtmlElement Tag(string name, Dictionary<string, string> attributes, params HtmlElement[] children) => new HtmlNode(name, attributes, children);

    public static HtmlElement Text(string content) => new HtmlText(content);

    public static HtmlElement Div(params HtmlElement[] children) => Tag("div", children);

    public static HtmlElement Span(params HtmlElement[] children) => Tag("span", children);

    public static HtmlElement P(params HtmlElement[] children) => Tag("p", children);

    public static HtmlElement A(string href, params HtmlElement[] children) => Tag("a", new Dictionary<string, string> { { "href", href } }, children);

    public static HtmlElement Ul(params HtmlElement[] children) => Tag("ul", children);

    public static HtmlElement Li(params HtmlElement[] children) => Tag("li", children);

    public static HtmlElement Img(string src, string alt = "") => new SelfClosingTag("img", new Dictionary<string, string> { { "src", src }, { "alt", alt } });

    public static HtmlElement Input(string type, string name, string value = "") => new SelfClosingTag("input", new Dictionary<string, string> { { "type", type }, { "name", name }, { "value", value } });

    public static HtmlElement Button(string text, Dictionary<string, string>? attributes = null) => Tag("button", attributes ?? new Dictionary<string, string>(), Text(text));

    public static HtmlElement Fragment(params HtmlElement[] children) => new HtmlFragment(children);
    
}