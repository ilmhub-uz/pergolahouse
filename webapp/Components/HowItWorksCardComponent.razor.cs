using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Components;

public partial class HowItWorksCardComponent : ComponentBase
{

    [Parameter]
    public int Index { get; set; }
    
    [Parameter]
    public HowItWorksCardComponentModel Model { get; set; }
}