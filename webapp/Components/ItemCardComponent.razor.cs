using Microsoft.AspNetCore.Components;
using webapp.Model;

namespace webapp.Components;

public partial class ItemCardComponent : ComponentBase
{
    [Parameter]
    public ItemModel ItemModel { get; set; }
}