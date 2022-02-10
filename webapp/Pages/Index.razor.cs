using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Pages;

public partial class Index : ComponentBase
{
    public List<ItemModel> ItemModels { get; set; } = new List<ItemModel>();

    [Inject]
    public HttpClient Http { get; set; }

    public List<string> Categories { get; set; } = new List<string>();



    protected override async Task OnInitializedAsync()
    {
        ItemModels = await Http.GetFromJsonAsync<List<ItemModel>>("data/data.json");
        StateHasChanged();
    }
} 