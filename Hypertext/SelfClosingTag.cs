namespace Hypertext;

public record SelfClosingTag : HtmlElement
{
    private readonly string _tag;
    private readonly Dictionary<string, string> _attributes;

    public SelfClosingTag(string tag, Dictionary<string, string> attributes)
    {
        _tag = tag;
        _attributes = attributes;
    }

    public SelfClosingTag(HtmlTag tag, Dictionary<string, string> attributes) : this(tag.ToStringFast(), attributes)
    {
    }

    public override string Render()
    {
        var attrString = string.Join(" ", _attributes.Select(kvp => $@"{kvp.Key}=""{kvp.Value}"""));
        return _attributes.Count != 0 ? $@"<{_tag} {attrString} />" : $"<{_tag} />";
    }
}