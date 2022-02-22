using Microsoft.AspNetCore.Components;

namespace webapp.Components.WhyChooseUs;

public partial class WhyChooseUsCardComponent : ComponentBase
{
    [Parameter]
    public CardComponentModel ItemModel { get; set; }
}