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
    }
}