using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Components;

public partial class ItemsGridComponent : ComponentBase
{
    public List<ItemModel> SelectedModels { get; set; } = new List<ItemModel>();
    
    public string SelectedTag { get; set; } = string.Empty;
    
    public string SelectedCategory { get; set; } = string.Empty;

    public List<string> Categories { get; set; }
    
    public List<string> Tags { get; set; }

    public List<ItemModel> ItemModels = new List<ItemModel>
    {
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Sometag",
            Title = "Потрясающая комната для аренды",
            Description = "Потрясающая квартира только для вас с современным  ремонтом, имеется много новых и развитие вещей и т.д.",
            Likes = 10,
            Cost = 600,
            Category = "Pergola"
        },
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Недвижимость",
            Title = "Потрясающая комната для аренды",
            Description = "Потрясающая квартира только для вас с современным  ремонтом, имеется много новых и развитие вещей и т.д.",
            Likes = 20,
            Cost = 300,
            Category = "Landshaft"
        },
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Sometag",
            Title = "Потрясающая комната для аренды",
            Description = "Потрясающая квартира только для вас с современным ремонтом, имеется много новых и развитие вещей и т.д.",
            Likes = 20,
            Cost = 300,
            Category = "Markiza"
        },
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Недвижимость",
            Title = "Потрясающая комната для аренды",
            Description = "Потрясающая квартира только для вас с современным  ремонтом, имеется много новых и развитие вещей и т.д.",
            Likes = 20,
            Cost = 300,
            Category = "Pergola",
        }
    };

    public void ChangeTag(ChangeEventArgs e)
    {
        SelectedTag = e.Value.ToString();
        if(SelectedTag != string.Empty)
        {
            if(SelectedCategory != string.Empty)
            {
                SelectedModels = ItemModels.Where(i => i.Category == SelectedCategory).Where(i => i.Tag == SelectedTag).ToList();
            }
            else
            {
                SelectedModels = ItemModels.Where(i => i.Tag == SelectedTag).ToList();
            }
        }
        else
        {
            if(SelectedCategory != string.Empty)
            {
                SelectedModels = ItemModels.Where(i => i.Category == SelectedCategory).ToList();
            }
            else
            {
                SelectedModels = ItemModels;
            }
        }
        StateHasChanged();
    }

    public void ChangeCategory(ChangeEventArgs e)
    {
        SelectedCategory = e.Value.ToString();
        if(SelectedTag != string.Empty)
        {
            if(SelectedCategory != string.Empty)
            {
                SelectedModels = ItemModels.Where(i => i.Category == SelectedCategory).Where(i => i.Tag == SelectedTag).ToList();
            }
            else
            {
                SelectedModels = ItemModels.Where(i => i.Tag == SelectedTag).ToList();
            }
        }
        else
        {
            if(SelectedCategory != string.Empty)
            {
                SelectedModels = ItemModels.Where(i => i.Category == SelectedCategory).ToList();
            }
            else
            {
                SelectedModels = ItemModels;
            }
        }
        StateHasChanged();
    }

    protected override void OnInitialized()
    {
        Categories = ItemModels.Select(i => i.Category).Distinct().ToList();
        Tags = ItemModels.Select(i => i.Tag).Distinct().ToList();

        TakeQuery();

        StateHasChanged();
    }

    public void TakeQuery()
    {
        // query category
        if(SelectedCategory == string.Empty)
        {
            SelectedModels = ItemModels;
        }
        else
        {
            SelectedModels = ItemModels.Where(i => i.Category == SelectedCategory).ToList();
        }

        // query tag
        if(SelectedTag != string.Empty)
        {
            SelectedModels = SelectedModels.Where(i => i.Tag == SelectedTag).ToList();
        }
    }
}