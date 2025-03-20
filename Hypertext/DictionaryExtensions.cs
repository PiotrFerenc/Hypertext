namespace Hypertext;

public static class DictionaryExtensions
{
    public static Dictionary<string, string> AppendAttribute(this Dictionary<string, string> dict, string key, string value) => new Dictionary<string, string>(dict) { [key] = value };
}