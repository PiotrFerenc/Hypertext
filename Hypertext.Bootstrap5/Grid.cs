namespace Hypertext.Bootstrap5;

public static class Grid
{
    public static HtmlElement Container(params HtmlElement[] rows) => Html.Div(rows).WithClass(BootstrapConstants.ContainerClass);
    public static HtmlElement Row(params HtmlElement[] columns) => Html.Div(columns).WithClass(BootstrapConstants.RowClass);
    public static HtmlElement Column(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.ColumnClass);
}