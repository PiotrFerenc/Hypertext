namespace Hypertext;

public abstract record HtmlElement
{
    protected Dictionary<string, string> Attributes = new();
    public abstract string Render();

    public HtmlElement WithAttribute(string key, string value)
    {
        Attributes = Attributes.AppendAttribute(key, value);
        return this;
    }

    public HtmlElement WithId(string id) => WithAttribute("id", id);
    public HtmlElement WithClass(string className) => WithAttribute("class", className);
    public HtmlElement WithClass(params string[] classes) => WithAttribute("class", classes.Aggregate((a, b) => $"{a} {b}"));
    public HtmlElement WithData(string key, string value) => WithAttribute($"data-{key}", value);
    public HtmlElement WithAria(string key, string value) => WithAttribute($"aria-{key}", value);
    public HtmlElement WithRole(string value) => WithAttribute("role", value);
    public HtmlElement WithOnClick(string script) => WithAttribute("onclick", script);
    public HtmlElement WithName(string name) => WithAttribute("name", name);
    public HtmlElement WithChecked(bool isChecked) => WithAttribute("checked", isChecked ? "checked" : string.Empty);
    public HtmlElement WithStyle(string style) => WithAttribute("style", style);
    public HtmlElement WithType(string type) => WithAttribute("type", type);
    public HtmlElement WithHref(string type) => WithAttribute("href", type);
}