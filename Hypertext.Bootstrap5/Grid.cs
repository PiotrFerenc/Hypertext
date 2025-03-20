namespace Hypertext.Bootstrap5;

public static class Grid
{
    public static HtmlElement Container(params HtmlElement[] rows) => Html.Div(rows).WithClass(BootstrapConstants.ContainerClass);
    public static HtmlElement Row(params HtmlElement[] columns) => Html.Div(columns).WithClass(BootstrapConstants.RowClass);
    public static HtmlElement Column(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.ColumnClass);
    public static HtmlElement Column1(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column1Class);
    public static HtmlElement Column2(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column2Class);
    public static HtmlElement Column3(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column3Class);
    public static HtmlElement Column4(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column4Class);
    public static HtmlElement Column5(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column5Class);
    public static HtmlElement Column6(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column6Class);
    public static HtmlElement Column7(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column7Class);
    public static HtmlElement Column8(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column8Class);
    public static HtmlElement Column9(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column9Class);
    public static HtmlElement Column10(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column10Class);
    public static HtmlElement Column11(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column11Class);
    public static HtmlElement Column12(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.Column12Class);
}