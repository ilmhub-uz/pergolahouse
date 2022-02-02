using Microsoft.AspNetCore.Components;

namespace webapp.Components;

public partial class WhyChooseUsCardComponent : ComponentBase
{
    [Parameter]
    public CardComponentModel ItemModel { get; set; }
}