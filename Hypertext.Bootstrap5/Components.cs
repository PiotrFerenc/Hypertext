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

    public static class Buttons
    {
        public static HtmlElement Default(string text) => Html.Button(text).WithClass(BootstrapConstants.Button);
        public static HtmlElement Primary(string text) => Html.Button(text).WithClass(BootstrapConstants.ButtonPrimaryClass);
        public static HtmlElement Secondary(string text) => Html.Button(text).WithClass(BootstrapConstants.ButtonSecondaryClass);
        public static HtmlElement Success(string text) => Html.Button(text).WithClass(BootstrapConstants.ButtonSuccessClass);
        public static HtmlElement Danger(string text) => Html.Button(text).WithClass(BootstrapConstants.ButtonDangerClass);
        public static HtmlElement Warning(string text) => Html.Button(text).WithClass(BootstrapConstants.ButtonWarningClass);
        public static HtmlElement Info(string text) => Html.Button(text).WithClass(BootstrapConstants.ButtonInfoClass);
        public static HtmlElement Light(string text) => Html.Button(text).WithClass(BootstrapConstants.ButtonLightClass);
        public static HtmlElement Dark(string text) => Html.Button(text).WithClass(BootstrapConstants.ButtonDarkClass);
    }
}