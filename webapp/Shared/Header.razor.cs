using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Shared;

public partial class Header : ComponentBase
{
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    
    [Parameter]
    public List<string> Categories { get; set; } = new List<string>();

    public void Navigate(string category)
    {
        NavigationManager.NavigateTo("/categories/" + category, forceLoad:true);
    }
} 