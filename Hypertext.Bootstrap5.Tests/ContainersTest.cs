using Hypertext;
using Hypertext.Bootstrap5;
using JetBrains.Annotations;

namespace Hypertext.Bootstrap5.Tests;

[TestSubject(typeof(Layout.Grid.Containers))]
public class ContainersTest
{
    [Fact]
    public void Container_WithNoRows_ShouldRenderContainerDivWithClass()
    {
        // Arrange

        // Act
        var result = Layout.Grid.Containers.Container();

        // Assert
        Assert.NotNull(result);
        Assert.Equal($"<div class=\"{BootstrapConstants.ContainerClass}\"></div>", result.Render());
    }

    [Fact]
    public void Container_WithRows_ShouldRenderContainerDivWithRowsInside()
    {
        // Arrange
        var row1 = Html.Div(Html.Text("Row1"));
        var row2 = Html.Div(Html.Text("Row2"));

        // Act
        var result = Layout.Grid.Containers.Container(row1, row2);

        // Assert
        Assert.NotNull(result);
        var expected = $"<div class=\"{BootstrapConstants.ContainerClass}\"><div>Row1</div><div>Row2</div></div>";
        Assert.Equal(expected, result.Render());
    }


    [Fact]
    public void Fluid_WithNoRows_ShouldRenderFluidContainerDivWithClass()
    {
        // Arrange

        // Act
        var result = Layout.Grid.Containers.Fluid();

        // Assert
        Assert.NotNull(result);
        Assert.Equal($"<div class=\"{BootstrapConstants.ContainerFluidClass}\"></div>", result.Render());
    }

    [Fact]
    public void Fluid_WithRows_ShouldRenderFluidContainerDivWithRowsInside()
    {
        // Arrange
        var row1 = Html.Div(Html.Text("Row1"));
        var row2 = Html.Div(Html.Text("Row2"));

        // Act
        var result = Layout.Grid.Containers.Fluid(row1, row2);

        // Assert
        Assert.NotNull(result);
        var expected = $"<div class=\"{BootstrapConstants.ContainerFluidClass}\"><div>Row1</div><div>Row2</div></div>";
        Assert.Equal(expected, result.Render());
    }


    [Fact]
    public void Fluid_ShouldHandleEmptyRows()
    {
        // Arrange

        // Act
        var result = Layout.Grid.Containers.Fluid(new HtmlElement[0]);

        // Assert
        Assert.NotNull(result);
        Assert.Equal($"<div class=\"{BootstrapConstants.ContainerFluidClass}\"></div>", result.Render());
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(100)]
    public void Container_ShouldHandleVariableNumberOfRows(int numberOfRows)
    {
        // Arrange
        var rows = Enumerable.Range(1, numberOfRows).Select(i => Html.Div(Html.Text($"Row{i}"))).ToArray();

        // Act
        var result = Layout.Grid.Containers.Container(rows);

        // Assert
        Assert.NotNull(result);
        var renderedRows = string.Join("", rows.Select(r => r.Render()));
        Assert.Equal($"<div class=\"{BootstrapConstants.ContainerClass}\">{renderedRows}</div>", result.Render());
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(100)]
    public void Fluid_ShouldHandleVariableNumberOfRows(int numberOfRows)
    {
        // Arrange
        var rows = Enumerable.Range(1, numberOfRows).Select(i => Html.Div(Html.Text($"Row{i}"))).ToArray();

        // Act
        var result = Layout.Grid.Containers.Fluid(rows);

        // Assert
        Assert.NotNull(result);
        var renderedRows = string.Join("", rows.Select(r => r.Render()));
        Assert.Equal($"<div class=\"{BootstrapConstants.ContainerFluidClass}\">{renderedRows}</div>", result.Render());
    }

    [Fact]
    public void Container_ShouldPreserveRowAttributes()
    {
        // Arrange
        var row1 = Html.Div(Html.Text("Row1")).WithId("row1");
        var row2 = Html.Div(Html.Text("Row2")).WithId("row2");

        // Act
        var result = Layout.Grid.Containers.Container(row1, row2);

        // Assert
        var expected = $"<div class=\"{BootstrapConstants.ContainerClass}\"><div id=\"row1\">Row1</div><div id=\"row2\">Row2</div></div>";
        Assert.Equal(expected, result.Render());
    }

    [Fact]
    public void Fluid_ShouldPreserveRowAttributes()
    {
        // Arrange
        var row1 = Html.Div(Html.Text("Row1")).WithId("row1");
        var row2 = Html.Div(Html.Text("Row2")).WithId("row2");

        // Act
        var result = Layout.Grid.Containers.Fluid(row1, row2);

        // Assert
        var expected = $"<div class=\"{BootstrapConstants.ContainerFluidClass}\"><div id=\"row1\">Row1</div><div id=\"row2\">Row2</div></div>";
        Assert.Equal(expected, result.Render());
    }
}