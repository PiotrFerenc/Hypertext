using Hypertext.Bootstrap5;
using JetBrains.Annotations;
using Xunit;

namespace Hypertext.Bootstrap5.Tests;

[TestSubject(typeof(Components))]
public class ComponentsTest
{
    #region Alert Component Tests

    [Fact]
    public void Alert_Primary_ShouldContainCorrectClassAndRole()
    {
        var element = Components.Alert.Primary();

        Assert.Contains("alert alert-primary", element.Render());
        Assert.Contains("role=\"alert\"", element.Render());
    }

    [Fact]
    public void Alert_Secondary_ShouldContainCorrectClassAndRole()
    {
        var element = Components.Alert.Secondary();

        Assert.Contains("alert alert-secondary", element.Render());
        Assert.Contains("role=\"alert\"", element.Render());
    }

    [Fact]
    public void Alert_Success_ShouldContainCorrectClassAndRole()
    {
        var element = Components.Alert.Success();

        Assert.Contains("alert alert-success", element.Render());
        Assert.Contains("role=\"alert\"", element.Render());
    }

    [Fact]
    public void Alert_Danger_ShouldContainCorrectClassAndRole()
    {
        var element = Components.Alert.Danger();

        Assert.Contains("alert alert-danger", element.Render());
        Assert.Contains("role=\"alert\"", element.Render());
    }

    [Fact]
    public void Alert_Warning_ShouldContainCorrectClassAndRole()
    {
        var element = Components.Alert.Warning();

        Assert.Contains("alert alert-warning", element.Render());
        Assert.Contains("role=\"alert\"", element.Render());
    }

    [Fact]
    public void Alert_Info_ShouldContainCorrectClassAndRole()
    {
        var element = Components.Alert.Info();

        Assert.Contains("alert alert-info", element.Render());
        Assert.Contains("role=\"alert\"", element.Render());
    }

    [Fact]
    public void Alert_Light_ShouldContainCorrectClassAndRole()
    {
        var element = Components.Alert.Light();

        Assert.Contains("alert alert-light", element.Render());
        Assert.Contains("role=\"alert\"", element.Render());
    }

    [Fact]
    public void Alert_Dark_ShouldContainCorrectClassAndRole()
    {
        var element = Components.Alert.Dark();

        Assert.Contains("alert alert-dark", element.Render());
        Assert.Contains("role=\"alert\"", element.Render());
    }

    #endregion

    #region Buttons Component Tests

    [Fact]
    public void Buttons_Default_ShouldContainCorrectClass()
    {
        var element = Components.Buttons.Default("Click Me");

        Assert.Contains("btn", element.Render());
        Assert.Contains("Click Me", element.Render());
    }

    [Theory]
    [InlineData("Primary", "btn btn-primary")]
    [InlineData("Secondary", "btn btn-secondary")]
    [InlineData("Success", "btn btn-success")]
    [InlineData("Danger", "btn btn-danger")]
    [InlineData("Warning", "btn btn-warning")]
    [InlineData("Info", "btn btn-info")]
    [InlineData("Light", "btn btn-light")]
    [InlineData("Dark", "btn btn-dark")]
    public void Buttons_WithStyles_ShouldContainCorrectClass(string style, string expectedClass)
    {
        var element = style switch
        {
            "Primary" => Components.Buttons.Primary("Click Me"),
            "Secondary" => Components.Buttons.Secondary("Click Me"),
            "Success" => Components.Buttons.Success("Click Me"),
            "Danger" => Components.Buttons.Danger("Click Me"),
            "Warning" => Components.Buttons.Warning("Click Me"),
            "Info" => Components.Buttons.Info("Click Me"),
            "Light" => Components.Buttons.Light("Click Me"),
            "Dark" => Components.Buttons.Dark("Click Me"),
            _ => throw new ArgumentOutOfRangeException()
        };

        Assert.Contains(expectedClass, element.Render());
        Assert.Contains("Click Me", element.Render());
    }

    #endregion

    #region Badges Component Tests

    [Theory]
    [InlineData("Primary", "badge badge-primary")]
    [InlineData("Danger", "badge badge-danger")]
    [InlineData("Success", "badge badge-success")]
    [InlineData("Warning", "badge badge-warning")]
    [InlineData("Info", "badge badge-info")]
    [InlineData("Light", "badge badge-light")]
    [InlineData("Dark", "badge badge-dark")]
    public void Badges_WithStyles_ShouldContainCorrectClass(string style, string expectedClass)
    {
        var element = style switch
        {
            "Primary" => Components.Badge.Primary("Badge"),
            "Danger" => Components.Badge.Danger("Badge"),
            "Success" => Components.Badge.Success("Badge"),
            "Warning" => Components.Badge.Warning("Badge"),
            "Info" => Components.Badge.Info("Badge"),
            "Light" => Components.Badge.Light("Badge"),
            "Dark" => Components.Badge.Dark("Badge"),
            _ => throw new ArgumentOutOfRangeException()
        };

        Assert.Contains(expectedClass, element.Render());
        Assert.Contains("Badge", element.Render());
    }

    #endregion

    #region Progress Component Tests

    [Theory]
    [InlineData("Success", "progress-bar bg-success")]
    [InlineData("Danger", "progress-bar bg-danger")]
    [InlineData("Warning", "progress-bar bg-warning")]
    [InlineData("Info", "progress-bar bg-info")]
    [InlineData("Light", "progress-bar bg-light")]
    [InlineData("Dark", "progress-bar bg-dark")]
    public void ProgressBar_WithStyles_ShouldContainCorrectClass(string style, string expectedClass)
    {
        var element = style switch
        {
            "Success" => Components.Progress.SuccessBar("Progress", 50),
            "Danger" => Components.Progress.DangerBar("Progress", 50),
            "Warning" => Components.Progress.WarningBar("Progress", 50),
            "Info" => Components.Progress.InfoBar("Progress", 50),
            "Light" => Components.Progress.LightBar("Progress", 50),
            "Dark" => Components.Progress.DarkBar("Progress", 50),
            _ => throw new ArgumentOutOfRangeException()
        };

        Assert.Contains(expectedClass, element.Render());
        Assert.Contains("width: 50%", element.Render());
    }

    [Fact]
    public void ProgressBar_Values_ShouldHaveCorrectAttributes()
    {
        var element = Components.Progress.InfoBar("Progress", 75, 0, 100);

        var render = element.Render();
        
        Assert.Contains("aria-label=\"Progress\"", render);
        Assert.Contains("aria-valuemin=\"0\"", render);
        Assert.Contains("aria-valuemax=\"100\"", render);
        Assert.Contains("aria-valuenow=\"75\"", render);
    }

    #endregion

    #region Spinners Component Tests

    [Theory]
    [InlineData("Primary", "spinner-border text-primary")]
    [InlineData("Secondary", "spinner-border text-secondary")]
    [InlineData("Success", "spinner-border text-success")]
    [InlineData("Danger", "spinner-border text-danger")]
    [InlineData("Warning", "spinner-border text-warning")]
    [InlineData("Info", "spinner-border text-info")]
    [InlineData("Light", "spinner-border text-light")]
    [InlineData("Dark", "spinner-border text-dark")]
    public void Spinner_WithStyles_ShouldContainCorrectClass(string style, string expectedClass)
    {
        var element = style switch
        {
            "Primary" => Components.Spinners.Primary("Loading..."),
            "Secondary" => Components.Spinners.Secondary("Loading..."),
            "Success" => Components.Spinners.Success("Loading..."),
            "Danger" => Components.Spinners.Danger("Loading..."),
            "Warning" => Components.Spinners.Warning("Loading..."),
            "Info" => Components.Spinners.Info("Loading..."),
            "Light" => Components.Spinners.Light("Loading..."),
            "Dark" => Components.Spinners.Dark("Loading..."),
            _ => throw new ArgumentOutOfRangeException()
        };

        Assert.Contains(expectedClass, element.Render());
        Assert.Contains("role=\"status\"", element.Render());
        Assert.Contains("Loading...", element.Render());
    }

    #endregion


}