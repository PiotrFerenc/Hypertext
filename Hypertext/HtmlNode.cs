namespace Hypertext;

public record HtmlNode(string Tag, Dictionary<string, string> Attributes, HtmlElement[] Children) : HtmlElement
{
    public override string Render()
    {
        var attrString = string.Join(" ", Attributes.Select(kvp => $"{kvp.Key}=\"{kvp.Value}\""));
        var renderedChildren = string.Join("", Children.Select(child => child.Render()));

        return Attributes.Count != 0
            ? $"<{Tag} {attrString}>{renderedChildren}</{Tag}>"
            : $"<{Tag}>{renderedChildren}</{Tag}>";
    }
}