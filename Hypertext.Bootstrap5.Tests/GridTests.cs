using System.Xml.Serialization;

namespace Hypertext.Bootstrap5.Tests;

public class GridTests
{
    [Fact]
    public void ShouldRenderGrid()
    {
        var grid = Layout.Grid.Containers.Container(
            Layout.Grid.Row(
                Layout.Grid.Column(Html.Text("123"))
            )
        );
        var tt = grid.Render();

        Assert.Equal("<div class=\"container\"><div class=\"row\"><div class=\"col\">123</div></div></div>", tt);
    }
}
