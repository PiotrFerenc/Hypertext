using Hypertext.Bootstrap5;
using JetBrains.Annotations;
using Xunit;

namespace Hypertext.Bootstrap5.Tests;

[TestSubject(typeof(TableBuilder<>))]
public class TableBuilderTest
{
    [Fact]
    public void WithRow_AddsRowCorrectly()
    {
        // Arrange
        var builder = new TableBuilder<TestEntity>();
        const string columnName = "Name";
        Func<TestEntity, HtmlElement> rowFunc = entity => Html.Text(entity.Name);

        // Act
        builder.WithRow(columnName, rowFunc);

        // Assert
        var builtTable = builder.Build(new List<TestEntity> { new() { Name = "Test" } },
            rows => Html.Table(rows));

        Assert.Contains("<th>Name</th>", builtTable.Render());
        Assert.Contains("<td>Test</td>", builtTable.Render());
    }

    [Fact]
    public void Build_BuildsTableWithCorrectHeadersAndRows()
    {
        // Arrange
        var builder = new TableBuilder<TestEntity>();

        builder.WithRow("Header1", entity => Html.Text(entity.Name));
        builder.WithRow("Header2", entity => Html.Text(entity.Age.ToString()));

        var entities = new List<TestEntity>
        {
            new() { Name = "Alice", Age = 25 },
            new() { Name = "Bob", Age = 30 }
        };

        // Act
        var result = builder.Build(entities, rows => Html.Table(rows));

        // Assert - check headers
        Assert.Contains("<th>Header1</th>", result.Render());
        Assert.Contains("<th>Header2</th>", result.Render());

        // Assert - check rows
        Assert.Contains("<td>Alice</td>", result.Render());
        Assert.Contains("<td>25</td>", result.Render());
        Assert.Contains("<td>Bob</td>", result.Render());
        Assert.Contains("<td>30</td>", result.Render());
    }

    [Fact]
    public void Build_EmptyRowDefinitions_YieldsEmptyTableBody()
    {
        // Arrange
        var builder = new TableBuilder<TestEntity>();

        // Act
        var result = builder.Build(new List<TestEntity>(), rows => Html.Table(rows));

        // Assert
        Assert.DoesNotContain("<td>", result.Render());
    }

    [Fact]
    public void Build_EmptyData_YieldsTableWithOnlyHeaders()
    {
        // Arrange
        var builder = new TableBuilder<TestEntity>();
        builder.WithRow("Header1", entity => Html.Text(entity.Name));

        // Act
        var result = builder.Build(new List<TestEntity>(), rows => Html.Table(rows));

        // Assert
        Assert.Contains("<thead>", result.Render());
        Assert.Contains("<th>Header1</th>", result.Render());
        Assert.DoesNotContain("<td>", result.Render());
    }

    [Fact]
    public void Build_HandlesSpecialCharactersInData()
    {
        // Arrange
        var builder = new TableBuilder<TestEntity>();
        builder.WithRow("Header", entity => Html.Text(entity.Name));

        var entities = new List<TestEntity>
        {
            new() { Name = "Alice & Bob" },
            new() { Name = "<Test>" }
        };

        // Act
        var result = builder.Build(entities, rows => Html.Table(rows));

        // Assert
        var renderedResult = result.Render();
        Assert.Contains("<td>Alice & Bob</td>", renderedResult);
        Assert.Contains("<td><Test></td>", renderedResult);
    }

    [Fact]
    public void Build_HandlesNullValuesCorrectly()
    {
        // Arrange
        var builder = new TableBuilder<TestEntity>();
        builder.WithRow("Header", entity => Html.Text(entity.Name ?? "N/A"));

        var entities = new List<TestEntity>
        {
            new() { Name = null }
        };

        // Act
        var result = builder.Build(entities, rows => Html.Table(rows));

        // Assert
        Assert.Contains("<td>N/A</td>", result.Render());
    }

    private class TestEntity
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}