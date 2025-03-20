namespace Hypertext;

public record SelfClosingTag(string Tag, Dictionary<string, string> Attributes) : HtmlElement
{
    public override string Render()
    {
        var attrString = string.Join(" ", Attributes.Select(kvp => $@"{kvp.Key}=""{kvp.Value}"""));
        return Attributes.Count != 0 ? $@"<{Tag} {attrString} />" : $"<{Tag} />";
    }
}