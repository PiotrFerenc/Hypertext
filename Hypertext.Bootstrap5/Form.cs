namespace Hypertext.Bootstrap5;

public static class Form
{
    public static class FormControls
    {
        public static HtmlElement TextInput(string name, string value) => Html.Input(BootstrapConstants.FormControlTextInput, name, value).WithClass(BootstrapConstants.FormControlClass);
        public static HtmlElement NumberInput(string name, string value) => Html.Input(BootstrapConstants.FormControlNumberInput, name, value).WithClass(BootstrapConstants.FormControlClass);

        public static HtmlElement PasswordInput(string name, string value) => Html.Input(BootstrapConstants.FormControlPasswordInput, name, value).WithClass(BootstrapConstants.FormControlClass);

        public static HtmlElement RangeInput(string name, string value) => Html.Input(BootstrapConstants.FormControlRangeInput, name, value).WithClass(BootstrapConstants.FormControlClass);

        public static HtmlElement EmailInput(string name, string value) => Html.Input(BootstrapConstants.FormControlEmailInput, name, value).WithClass(BootstrapConstants.FormControlClass);

        public static HtmlElement DateInput(string name, string value) => Html.Input(BootstrapConstants.FormControlDateInput, name, value).WithClass(BootstrapConstants.FormControlClass);

        public static HtmlElement TimeInput(string name, string value) => Html.Input(BootstrapConstants.FormControlTimeInput, name, value).WithClass(BootstrapConstants.FormControlClass);

        public static HtmlElement FileInput(string name) => Html.Input(BootstrapConstants.FormControlFileInput, name, string.Empty).WithClass(BootstrapConstants.FormControlClass);

        public static HtmlElement ColorInput(string name, string value) => Html.Input(BootstrapConstants.FormControlColorInput, name, value).WithClass(BootstrapConstants.FormControlClass);

        public static HtmlElement CheckboxInput(string name, bool isChecked) => Html.Input(BootstrapConstants.FormControlCheckbox, name, isChecked ? "true" : "false");

        public static HtmlElement RadioInput(string name, string value, bool isChecked = false) => Html.Input(BootstrapConstants.FormControlRadio, name, value).WithChecked(isChecked);

        public static HtmlElement SelectInput(string name, params HtmlElement[] options) => Html.Select(options).WithClass(BootstrapConstants.FormControlClass).WithName(name);

        public static HtmlElement TextareaInput(string name, string value, int rows = 3) => Html.TextArea(value).WithClass(BootstrapConstants.FormControlClass).WithName(name).WithAttribute("rows", rows.ToString());
    }
}