using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Components;

public partial class ItemCardComponent : ComponentBase
{
    [Parameter]
    public ItemModel ItemModel { get; set; }
}