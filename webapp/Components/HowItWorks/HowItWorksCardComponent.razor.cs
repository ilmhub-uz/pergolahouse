using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Components.HowItWorks;

public partial class HowItWorksCardComponent : ComponentBase
{

    [Parameter]
    public int Index { get; set; }
    
    [Parameter]
    public HowItWorksCardComponentModel Model { get; set; }
}