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

    public static class Badge
    {
        public static HtmlElement Primary(string text) => Html.Span(text).WithClass(BootstrapConstants.BadgePrimary);
        public static HtmlElement Danger(string text) => Html.Span(text).WithClass(BootstrapConstants.BadgeDanger);
        public static HtmlElement Success(string text) => Html.Span(text).WithClass(BootstrapConstants.BadgeSuccess);
        public static HtmlElement Warning(string text) => Html.Span(text).WithClass(BootstrapConstants.BadgeWarning);
        public static HtmlElement Info(string text) => Html.Span(text).WithClass(BootstrapConstants.BadgeInfo);
        public static HtmlElement Light(string text) => Html.Span(text).WithClass(BootstrapConstants.BadgeLight);
        public static HtmlElement Dark(string text) => Html.Span(text).WithClass(BootstrapConstants.BadgeDark);
    }

    public static class Progress
    {
        private static HtmlElement Bar(string text, uint value, string style, uint min = 0, uint max = 100) => Html.Div(Html.Div().WithClass(style).WithStyle($"width: {value}%")).WithClass(BootstrapConstants.Progress).WithAria("label", text).WithData("valuenow", value.ToString()).WithAria("valuemax", max.ToString()).WithAria("valuemin", min.ToString());
        public static HtmlElement SuccessBar(string text, uint value, uint min = 0, uint max = 100) => Bar(text, value, BootstrapConstants.ProgressBarSuccess, min, max);
        public static HtmlElement DangerBar(string text, uint value, uint min = 0, uint max = 100) => Bar(text, value, BootstrapConstants.ProgressBarDanger, min, max);
        public static HtmlElement WarningBar(string text, uint value, uint min = 0, uint max = 100) => Bar(text, value, BootstrapConstants.ProgressBarWarning, min, max);
        public static HtmlElement InfoBar(string text, uint value, uint min = 0, uint max = 100) => Bar(text, value, BootstrapConstants.ProgressBarInfo, min, max);
        public static HtmlElement LightBar(string text, uint value, uint min = 0, uint max = 100) => Bar(text, value, BootstrapConstants.ProgressBarLight, min, max);
        public static HtmlElement DarkBar(string text, uint value, uint min = 0, uint max = 100) => Bar(text, value, BootstrapConstants.ProgressBarDark, min, max);
    }
}