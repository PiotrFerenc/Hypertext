namespace Hypertext.Bootstrap5;

public class TableBuilder<T>
{
    private readonly Dictionary<string, Func<T, HtmlElement>> _rows = new();

    public delegate HtmlElement RowBuilder(params HtmlElement[] rows);

    public TableBuilder<T> WithRow(string name, Func<T, HtmlElement> row)
    {
        _rows.Add(name, row);
        return this;
    }

    public HtmlElement Build(List<T> items, RowBuilder rowBuilder)
    {
        var head = Html.Thead(Html.Tr(_rows.Select(x => Html.Th(Html.Text(x.Key))).ToArray()));
        var body = new List<HtmlElement>();
        foreach (var item in items)
        {
            foreach (var row in _rows)
            {
                var td = Html.Td(row.Value(item).Render());
                var tr = Html.Tr(td);
                body.Add(tr);
            }
        }

        var rows = new[] { head, Html.Tbody(body.ToArray()) };
        return rowBuilder(rows);
    }
}