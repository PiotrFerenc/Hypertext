namespace Hypertext;

public record SelfClosingTag : HtmlElement
{
    public readonly string Tag;
    public new readonly Dictionary<string, string> Attributes;

    public SelfClosingTag(string tag, Dictionary<string, string> attributes)
    {
        Tag = tag;
        Attributes = attributes;
    }

    public SelfClosingTag(HtmlTag tag, Dictionary<string, string> attributes) : this(tag.ToStringFast(), attributes)
    {
    }

    public override string Render()
    {
        var attrString = string.Join(" ", Attributes.Select(kvp => $@"{kvp.Key}=""{kvp.Value}"""));
        return Attributes.Count != 0 ? $@"<{Tag} {attrString} />" : $"<{Tag} />";
    }
}