using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Components;

public partial class ItemsGridComponent : ComponentBase
{
    [Parameter]
    public List<ItemModel> ItemModels { get; set; }
}