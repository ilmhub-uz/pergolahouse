using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Shared;

public partial class Header : ComponentBase
{
    [Parameter]
    public List<string> Categories { get; set; } = new List<string>();
}