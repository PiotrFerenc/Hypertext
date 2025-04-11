namespace Hypertext.Bootstrap5;

public static class Utilities
{
    public static class Link
    {
        public static class LinkUnderlines
        {
            public static HtmlElement Primary(HtmlText text, string link) => Html.A(link, text).WithClass(BootstrapConstants.LinkUnderlinePrimary);
            public static HtmlElement Secondary(HtmlText text, string link) => Html.A(link, text).WithClass(BootstrapConstants.LinkUnderlineSecondary);
            public static HtmlElement Success(HtmlText text, string link) => Html.A(link, text).WithClass(BootstrapConstants.LinkUnderlineSuccess);
            public static HtmlElement Danger(HtmlText text, string link) => Html.A(link, text).WithClass(BootstrapConstants.LinkUnderlineDanger);
            public static HtmlElement Warning(HtmlText text, string link) => Html.A(link, text).WithClass(BootstrapConstants.LinkUnderlineWarning);
            public static HtmlElement Info(HtmlText text, string link) => Html.A(link, text).WithClass(BootstrapConstants.LinkUnderlineInfo);
            public static HtmlElement Light(HtmlText text, string link) => Html.A(link, text).WithClass(BootstrapConstants.LinkUnderlineLight);
            public static HtmlElement Dark(HtmlText text, string link) => Html.A(link, text).WithClass(BootstrapConstants.LinkUnderlineDark);
        }
    }
}