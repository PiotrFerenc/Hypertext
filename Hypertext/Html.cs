namespace Hypertext;

using System.Collections.Generic;

public static class Html
{
    public static HtmlElement Tag(HtmlTag name, params HtmlElement[] children) => new HtmlNode(name.ToStringFast(true), new Dictionary<string, string>(), children);
    public static HtmlElement Tag(string name, params HtmlElement[] children) => new HtmlNode(name, new Dictionary<string, string>(), children);

    public static HtmlElement Tag(HtmlTag name, Dictionary<string, string> attributes, params HtmlElement[] children) => new HtmlNode(name.ToStringFast(true), attributes, children);
    public static HtmlElement Tag(string name, Dictionary<string, string> attributes, params HtmlElement[] children) => new HtmlNode(name , attributes, children);

    public static HtmlElement Text(string content) => new HtmlText(content);

    public static HtmlElement Div(params HtmlElement[] children) => Tag(HtmlTag.Div, children);

    public static HtmlElement Span(params HtmlElement[] children) => Tag(HtmlTag.Span, children);
    public static HtmlElement Span(string text) => Tag(HtmlTag.Span, Html.Text(text));

    public static HtmlElement P(params HtmlElement[] children) => Tag(HtmlTag.P, children);
    public static HtmlElement P(string text) => Tag(HtmlTag.P, Text(text));

    public static HtmlElement A(string href, params HtmlElement[] children) => Tag(HtmlTag.A, new Dictionary<string, string> { { "href", href } }, children);

    public static HtmlElement Ul(params HtmlElement[] children) => Tag(HtmlTag.Ul, children);

    public static HtmlElement Li(params HtmlElement[] children) => Tag(HtmlTag.Li, children);
    public static HtmlElement H1(string text) => Tag(HtmlTag.H1, Text(text));
    public static HtmlElement H2(string text) => Tag(HtmlTag.H2, Text(text));
    public static HtmlElement H3(string text) => Tag(HtmlTag.H3, Text(text));
    public static HtmlElement H4(string text) => Tag(HtmlTag.H4, Text(text));
    public static HtmlElement H5(string text) => Tag(HtmlTag.H5, Text(text));
    public static HtmlElement H6(string text) => Tag(HtmlTag.H6, Text(text));

    public static HtmlElement Img(string src, string alt = "") => new SelfClosingTag(HtmlTag.Img.ToStringFast(true), new Dictionary<string, string> { { "src", src }, { "alt", alt } });

    public static HtmlElement Input(string type, string name, string value = "") => new SelfClosingTag(HtmlTag.Input.ToStringFast(true), new Dictionary<string, string> { { "type", type }, { "name", name }, { "value", value } });

    public static HtmlElement Button(string text, Dictionary<string, string>? attributes = null) => Tag(HtmlTag.Button, attributes ?? new Dictionary<string, string>(), Text(text));

    public static HtmlElement Fragment(params HtmlElement[] children) => new HtmlFragment(children);
    public static HtmlElement Mark(string text) => Tag(HtmlTag.Mark, Text(text));
    public static HtmlElement Del(string text) => Tag(HtmlTag.Del, Text(text));
    public static HtmlElement S(string text) => Tag(HtmlTag.S, Text(text));
    public static HtmlElement Ins(string text) => Tag(HtmlTag.Ins, Text(text));
    public static HtmlElement U(string text) => Tag(HtmlTag.U, Text(text));
    public static HtmlElement Small(string text) => Tag(HtmlTag.Small, Text(text));
    public static HtmlElement Strong(string text) => Tag(HtmlTag.Strong, Text(text));
    public static HtmlElement Em(string text) => Tag(HtmlTag.Em, Text(text));
    public static HtmlElement Table(HtmlElement[] rows) => Tag(HtmlTag.Table, rows);

    public static HtmlElement Tr(params HtmlElement[] items) => Tag(HtmlTag.Tr, items);
    public static HtmlElement Thead(HtmlElement tr) => Tag(HtmlTag.Thead, tr);
    public static HtmlElement Tbody(params HtmlElement[] items) => Tag(HtmlTag.Tbody, items);
    public static HtmlElement Tfoot(HtmlElement tr) => Tag(HtmlTag.Tfoot, tr);
    public static HtmlElement Th(HtmlElement text) => Tag(HtmlTag.Th, text);
    public static HtmlElement Td(string text) => Tag(HtmlTag.Td, Text(text));
    public static HtmlElement Td(params HtmlElement[] items) => Tag(HtmlTag.Td, items);

    public static HtmlElement Select(HtmlElement[] options) => Tag(HtmlTag.Select, options);

    public static HtmlElement TextArea(string value) => Tag(HtmlTag.TextArea, Text(value));

    public static HtmlElement Nav(HtmlElement ul) => Tag(HtmlTag.Nav, ul);
}