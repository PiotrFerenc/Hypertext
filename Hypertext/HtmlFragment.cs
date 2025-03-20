namespace Hypertext;

public record HtmlFragment(HtmlElement[] Children) : HtmlElement
{
    public override string Render() => string.Join(string.Empty, Children.Select(c => c.Render()));
}