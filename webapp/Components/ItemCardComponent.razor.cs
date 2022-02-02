using Microsoft.AspNetCore.Components;

namespace webapp.Components;
public partial class ItemCardComponent : ComponentBase
{
    [Parameter]
    public string DetailImage { get; set; }

    [Parameter]
    public string Tag { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Description { get; set; }
    
    [Parameter]
    public int Likes { get; set; }

    [Parameter]
    public double Cost { get; set; }
}