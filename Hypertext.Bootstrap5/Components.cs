namespace Hypertext.Bootstrap5;

public static class Components
{
    public static class Alert
    {
        public static HtmlElement Primary(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.AlertPrimaryClass).WithRole(BootstrapConstants.Alert);
        public static HtmlElement Secondary(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.AlertSecondaryClass).WithRole(BootstrapConstants.Alert);
        public static HtmlElement Success(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.AlertSuccessClass).WithRole(BootstrapConstants.Alert);
        public static HtmlElement Danger(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.AlertDangerClass).WithRole(BootstrapConstants.Alert);
        public static HtmlElement Warning(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.AlertWarningClass).WithRole(BootstrapConstants.Alert);
        public static HtmlElement Info(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.AlertInfoClass).WithRole(BootstrapConstants.Alert);
        public static HtmlElement Light(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.AlertLightClass).WithRole(BootstrapConstants.Alert);
        public static HtmlElement Dark(params HtmlElement[] children) => Html.Div(children).WithClass(BootstrapConstants.AlertDarkClass).WithRole(BootstrapConstants.Alert);
    }
}