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
    public static HtmlElement P(string text) => Tag("p", Text(text));

    public static HtmlElement A(string href, params HtmlElement[] children) => Tag("a", new Dictionary<string, string> { { "href", href } }, children);

    public static HtmlElement Ul(params HtmlElement[] children) => Tag("ul", children);

    public static HtmlElement Li(params HtmlElement[] children) => Tag("li", children);
    public static HtmlElement H1(string text) => Tag("h1", Text(text));
    public static HtmlElement H2(string text) => Tag("h2", Text(text));
    public static HtmlElement H3(string text) => Tag("h3", Text(text));
    public static HtmlElement H4(string text) => Tag("h4", Text(text));
    public static HtmlElement H5(string text) => Tag("h5", Text(text));
    public static HtmlElement H6(string text) => Tag("h6", Text(text));

    public static HtmlElement Img(string src, string alt = "") => new SelfClosingTag("img", new Dictionary<string, string> { { "src", src }, { "alt", alt } });

    public static HtmlElement Input(string type, string name, string value = "") => new SelfClosingTag("input", new Dictionary<string, string> { { "type", type }, { "name", name }, { "value", value } });

    public static HtmlElement Button(string text, Dictionary<string, string>? attributes = null) => Tag("button", attributes ?? new Dictionary<string, string>(), Text(text));

    public static HtmlElement Fragment(params HtmlElement[] children) => new HtmlFragment(children);
    public static HtmlElement Mark(string text) => Tag("mark", Text(text));
    public static HtmlElement Del(string text) => Tag("del", Text(text));
    public static HtmlElement S(string text) => Tag("s", Text(text));
    public static HtmlElement Ins(string text) => Tag("ins", Text(text));
    public static HtmlElement U(string text) => Tag("u", Text(text));
    public static HtmlElement Small(string text) => Tag("small", Text(text));
    public static HtmlElement Strong(string text) => Tag("strong", Text(text));
    public static HtmlElement Em(string text) => Tag("em", Text(text));
    public static HtmlElement Table(HtmlElement[] rows) => Tag("table", rows);

    public static HtmlElement Tr(params HtmlElement[] items) => Tag("tr", items);
    public static HtmlElement Thead(HtmlElement tr) => Tag("thead", tr);
    public static HtmlElement Tbody(params HtmlElement[] items) => Tag("tbody", items);
    public static HtmlElement Tfoot(HtmlElement tr) => Tag("tfoot", tr);
    public static HtmlElement Th(HtmlElement text) => Tag("th", text);
    public static HtmlElement Td(string text) => Tag("td", Text(text));

    public static HtmlElement Select(HtmlElement[] options) => Tag("select", options);

    public static HtmlElement TextArea(string value) => Tag("textarea", Text(value));
}