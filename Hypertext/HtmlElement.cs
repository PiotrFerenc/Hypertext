namespace Hypertext;

public abstract record HtmlElement
{
    public abstract string Render();

    public HtmlElement WithAttribute(string key, string value)
    {
        if (this is HtmlNode node)
            return node with { Attributes = node.Attributes.AppendAttribute(key, value) };

        if (this is SelfClosingTag tag)
            return tag with { Attributes = tag.Attributes.AppendAttribute(key, value) };

        return this;
    }

    public HtmlElement WithId(string id) => WithAttribute("id", id);

    public HtmlElement WithClass(string className) => WithAttribute("class", className);

    public HtmlElement WithData(string key, string value) => WithAttribute($"data-{key}", value);

    public HtmlElement WithAria(string key, string value) => WithAttribute($"aria-{key}", value);
    public HtmlElement WithRole(string value) => WithAttribute("role", value);

    public HtmlElement WithOnClick(string script) => WithAttribute("onclick", script);

    public HtmlElement WithName(string name) => WithAttribute("name", name);

    public HtmlElement WithChecked(bool isChecked) => WithAttribute("checked", isChecked ? "checked" : string.Empty);
}