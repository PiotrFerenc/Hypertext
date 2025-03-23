namespace Hypertext.Bootstrap5;

public static class Content
{
    public static class Typography
    {
        public static HtmlElement H1(string text) => Html.P(text).WithClass(BootstrapConstants.H1);
        public static HtmlElement H2(string text) => Html.P(text).WithClass(BootstrapConstants.H2);
        public static HtmlElement H3(string text) => Html.P(text).WithClass(BootstrapConstants.H3);
        public static HtmlElement H4(string text) => Html.P(text).WithClass(BootstrapConstants.H4);
        public static HtmlElement H5(string text) => Html.P(text).WithClass(BootstrapConstants.H5);
        public static HtmlElement H6(string text) => Html.P(text).WithClass(BootstrapConstants.H6);

        public static HtmlElement Display1(string text) => Html.H1(text).WithClass(BootstrapConstants.Display1);
        public static HtmlElement Display2(string text) => Html.H1(text).WithClass(BootstrapConstants.Display2);
        public static HtmlElement Display3(string text) => Html.H1(text).WithClass(BootstrapConstants.Display3);
        public static HtmlElement Display4(string text) => Html.H1(text).WithClass(BootstrapConstants.Display4);
        public static HtmlElement Display5(string text) => Html.H1(text).WithClass(BootstrapConstants.Display5);
        public static HtmlElement Display6(string text) => Html.H1(text).WithClass(BootstrapConstants.Display6);

        public static HtmlElement Mark(string text) => Html.Mark(text);
        public static HtmlElement Deleted(string text) => Html.Del(text);
        public static HtmlElement Strikethrough(string text) => Html.S(text);
        public static HtmlElement Inserted(string text) => Html.Ins(text);
        public static HtmlElement Underline(string text) => Html.U(text);
        public static HtmlElement Small(string text) => Html.Small(text);
        public static HtmlElement Strong(string text) => Html.Strong(text);
        public static HtmlElement Emphasized(string text) => Html.Em(text);
    }

    public static class Table
    {
        public static HtmlElement Default(params HtmlElement[] rows) => Html.Table(rows).WithClass(BootstrapConstants.TableClass);
        public static HtmlElement Primary(params HtmlElement[] rows) => Html.Table(rows).WithClass(BootstrapConstants.TablePrimaryClass);
        public static HtmlElement Secondary(params HtmlElement[] rows) => Html.Table(rows).WithClass(BootstrapConstants.TableSecondaryClass);
        public static HtmlElement Success(params HtmlElement[] rows) => Html.Table(rows).WithClass(BootstrapConstants.TableSuccessClass);
        public static HtmlElement Danger(params HtmlElement[] rows) => Html.Table(rows).WithClass(BootstrapConstants.TableDangerClass);
        public static HtmlElement Warning(params HtmlElement[] rows) => Html.Table(rows).WithClass(BootstrapConstants.TableWarningClass);
        public static HtmlElement Info(params HtmlElement[] rows) => Html.Table(rows).WithClass(BootstrapConstants.TableInfoClass);
        public static HtmlElement Light(params HtmlElement[] rows) => Html.Table(rows).WithClass(BootstrapConstants.TableLightClass);
        public static HtmlElement Dark(params HtmlElement[] rows) => Html.Table(rows).WithClass(BootstrapConstants.TableDarkClass);
    }
}

public class TableBuilder<T>
{
    private Dictionary<string, Func<T, HtmlElement>> _rows = new();

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