using System.Security.Cryptography.X509Certificates;

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

    public static class Spinners
    {
        private static HtmlElement Spinner(string text, string color) => Html.Div(Html.Span(Html.Text(text)).WithClass("visually-hidden")).WithClass(color).WithRole("status");

        public static HtmlElement Primary(string text) => Spinner(text, BootstrapConstants.SpinnerPrimary);
        public static HtmlElement Secondary(string text) => Spinner(text, BootstrapConstants.SpinnerSecondary);
        public static HtmlElement Success(string text) => Spinner(text, BootstrapConstants.SpinnerSuccess);
        public static HtmlElement Danger(string text) => Spinner(text, BootstrapConstants.SpinnerDanger);
        public static HtmlElement Warning(string text) => Spinner(text, BootstrapConstants.SpinnerWarning);
        public static HtmlElement Info(string text) => Spinner(text, BootstrapConstants.SpinnerInfo);
        public static HtmlElement Light(string text) => Spinner(text, BootstrapConstants.SpinnerLight);
        public static HtmlElement Dark(string text) => Spinner(text, BootstrapConstants.SpinnerDark);
    }

    public static class Pagination
    {
        public static HtmlElement Default(List<(string Link, string Text)> items) =>
            Html.Nav(Html.Ul(items.Select(x => Html.Li(_link(x.Link, x.Text)).WithClass(BootstrapConstants.PageItem)).ToArray()).WithClass(BootstrapConstants.Pagination));

        private static HtmlElement _link(string link, string text) => Html.A(link, Html.Text(text)).WithClass(BootstrapConstants.PageLink);
    }

    public static class Breadcrumb
    {
        public static HtmlElement Default(params HtmlElement[] links) => Html.Nav(Html.Ol(links.Select(x => Html.Li(x).WithClass(BootstrapConstants.BreadcrumbItem)).ToArray())).WithAria("label", BootstrapConstants.Breadcrumb);
    }

    public static class Placeholders
    {
        public static HtmlElement Col1() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol1);
        public static HtmlElement Col2() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol2);
        public static HtmlElement Col3() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol3);
        public static HtmlElement Col4() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol4);
        public static HtmlElement Col5() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol5);
        public static HtmlElement Col6() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol6);
        public static HtmlElement Col7() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol7);
        public static HtmlElement Col8() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol8);
        public static HtmlElement Col9() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol9);
        public static HtmlElement Col10() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol10);
        public static HtmlElement Col11() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol11);
        public static HtmlElement Col12() => Html.Span().WithClass(BootstrapConstants.PlaceholderCol12);
    }
}