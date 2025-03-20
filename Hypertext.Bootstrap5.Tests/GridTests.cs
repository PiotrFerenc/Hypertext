using System.Xml.Serialization;

namespace Hypertext.Bootstrap5.Tests;

public class GridTests
{
    [Fact]
    public void Test()
    {
        var grid = Layout.Grid.Container(
            Layout.Grid.Row(
                Layout.Grid.Column(Html.Text("123"))
            )
        );
        var tt = grid.Render();

        Assert.Equal("<div class=\"container\"><div class=\"row\"><div class=\"col\">123</div></div></div>", tt);
    }
}