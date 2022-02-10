using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using webapp.Models;
using Blazored.LocalStorage;

namespace webapp.Components;

public partial class ItemCardComponent : ComponentBase
{
    [Parameter]
    public ItemModel ItemModel { get; set; }

    [Inject]
    public ISyncLocalStorageService LocalStorageService { get; set; }

    const string LocalTableName = "Liked";

    public void ChangeToLike(string id)
    {
        LocalStorageService.SetItem(id, ItemModel.ToString());
    }
    public void ChangeToUnlike(string id)
    {
        LocalStorageService.RemoveItem(id);
    }
} 