using System.Linq;
using Hypertext;
using Hypertext.Bootstrap5;
using JetBrains.Annotations;
using Xunit;

namespace Hypertext.Bootstrap5.Tests;

[TestSubject(typeof(Content.Table))]
public class TableTest
{
    [Fact]
    public void Default_ShouldRenderTableWithDefaultClass()
    {
        // Arrange
        var row = Html.Tr(Html.Td("Cell 1"), Html.Td("Cell 2"));
        var table = Content.Table.Default(row);

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Contains("class=\"table\"", rendered);
        Assert.Contains("<tr><td>Cell 1</td><td>Cell 2</td></tr>", rendered);
    }

    [Fact]
    public void Primary_ShouldRenderTableWithPrimaryClass()
    {
        // Arrange
        var row = Html.Tr(Html.Td("Cell 1"), Html.Td("Cell 2"));
        var table = Content.Table.Primary(row);

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Contains("class=\"table table-primary\"", rendered);
        Assert.Contains("<tr><td>Cell 1</td><td>Cell 2</td></tr>", rendered);
    }

    [Fact]
    public void Secondary_ShouldRenderTableWithSecondaryClass()
    {
        // Arrange
        var row = Html.Tr(Html.Td("Cell 1"), Html.Td("Cell 2"));
        var table = Content.Table.Secondary(row);

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Contains("class=\"table table-secondary\"", rendered);
        Assert.Contains("<tr><td>Cell 1</td><td>Cell 2</td></tr>", rendered);
    }

    [Fact]
    public void Success_ShouldRenderTableWithSuccessClass()
    {
        // Arrange
        var row = Html.Tr(Html.Td("Cell 1"), Html.Td("Cell 2"));
        var table = Content.Table.Success(row);

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Contains("class=\"table table-success\"", rendered);
        Assert.Contains("<tr><td>Cell 1</td><td>Cell 2</td></tr>", rendered);
    }

    [Fact]
    public void Danger_ShouldRenderTableWithDangerClass()
    {
        // Arrange
        var row = Html.Tr(Html.Td("Cell 1"), Html.Td("Cell 2"));
        var table = Content.Table.Danger(row);

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Contains("class=\"table table-danger\"", rendered);
        Assert.Contains("<tr><td>Cell 1</td><td>Cell 2</td></tr>", rendered);
    }

    [Fact]
    public void Warning_ShouldRenderTableWithWarningClass()
    {
        // Arrange
        var row = Html.Tr(Html.Td("Cell 1"), Html.Td("Cell 2"));
        var table = Content.Table.Warning(row);

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Contains("class=\"table table-warning\"", rendered);
        Assert.Contains("<tr><td>Cell 1</td><td>Cell 2</td></tr>", rendered);
    }

    [Fact]
    public void Info_ShouldRenderTableWithInfoClass()
    {
        // Arrange
        var row = Html.Tr(Html.Td("Cell 1"), Html.Td("Cell 2"));
        var table = Content.Table.Info(row);

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Contains("class=\"table table-info\"", rendered);
        Assert.Contains("<tr><td>Cell 1</td><td>Cell 2</td></tr>", rendered);
    }

    [Fact]
    public void Light_ShouldRenderTableWithLightClass()
    {
        // Arrange
        var row = Html.Tr(Html.Td("Cell 1"), Html.Td("Cell 2"));
        var table = Content.Table.Light(row);

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Contains("class=\"table table-light\"", rendered);
        Assert.Contains("<tr><td>Cell 1</td><td>Cell 2</td></tr>", rendered);
    }

    [Fact]
    public void Dark_ShouldRenderTableWithDarkClass()
    {
        // Arrange
        var row = Html.Tr(Html.Td("Cell 1"), Html.Td("Cell 2"));
        var table = Content.Table.Dark(row);

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Contains("class=\"table table-dark\"", rendered);
        Assert.Contains("<tr><td>Cell 1</td><td>Cell 2</td></tr>", rendered);
    }

    [Fact]
    public void MultipleRows_ShouldRenderTableWithAllRows()
    {
        // Arrange
        var row1 = Html.Tr(Html.Td("Row 1 Cell 1"), Html.Td("Row 1 Cell 2"));
        var row2 = Html.Tr(Html.Td("Row 2 Cell 1"), Html.Td("Row 2 Cell 2"));
        var table = Content.Table.Default(row1, row2);

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Contains("<tr><td>Row 1 Cell 1</td><td>Row 1 Cell 2</td></tr>", rendered);
        Assert.Contains("<tr><td>Row 2 Cell 1</td><td>Row 2 Cell 2</td></tr>", rendered);
    }

    [Fact]
    public void NoRows_ShouldRenderEmptyTable()
    {
        // Arrange
        var table = Content.Table.Default();

        // Act
        var rendered = table.Render();

        // Assert
        Assert.Equal("<table class=\"table\"></table>", rendered);
    }
}