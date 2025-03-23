using System.Xml.Serialization;

namespace Hypertext.Bootstrap5.Tests;

public class GridTests
{
    [Fact]
    public void Test()
    {
        var grid = Layout.Grid.Containers.Container(
            Layout.Grid.Row(
                Layout.Grid.Column(Html.Text("123"))
            )
        );
        var tt = grid.Render();

        Assert.Equal("<div class=\"container\"><div class=\"row\"><div class=\"col\">123</div></div></div>", tt);
    }

    [Fact]
    public void TableTest()
    {
        var table = Content.Table.Info(new[]
        {
            Html.Tag("tr",
                Html.Tag("td",
                    Html.Text("1")))
        });
        var tt = table.Render();
        Assert.Equal("<table class=\"table table-info\"><tr><td>1</td></tr></table>", tt);
    }

    [Fact]
    public void TableBuilderTest()
    {
        var persons = new List<Person>()
        {
            new() { Name = "Test" }
        };

        var builder = new TableBuilder<Person>();
        builder.WithRow("Name", x => Html.Text(x.Name));
        var table = builder.Build(persons, Content.Table.Default);
        var tt = table.Render();

        Assert.Equal("<table class=\"table\"><thead><tr><th>Name</th></tr></thead><tbody><tr><td>Test</td></tr></tbody></table>", tt);
    }
}

class Person
{
    public string Name { get; set; }
}