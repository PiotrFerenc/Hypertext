namespace Hypertext;

public record HtmlText(string Content) : HtmlElement
{
    public override string Render() => Content;
}