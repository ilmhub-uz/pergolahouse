using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Components;

public partial class ItemsGridComponent : ComponentBase
{
    public List<ItemModel> ItemModels = new List<ItemModel>
    {
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Недвижимость",
            Title = "Потрясающая комната для аренды",
            Description = "Потрясающая квартира только для вас с современным  ремонтом, имеется много новых и развитие вещей и т.д.",
            Likes = 20,
            Cost = 300
        },
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Недвижимость",
            Title = "Потрясающая комната для аренды",
            Description = "Потрясающая квартира только для вас с современным  ремонтом, имеется много новых и развитие вещей и т.д.",
            Likes = 20,
            Cost = 300
        },
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Недвижимость",
            Title = "Потрясающая комната для аренды",
            Description = "Потрясающая квартира только для вас с современным ремонтом, имеется много новых и развитие вещей и т.д.",
            Likes = 20,
            Cost = 300
        },
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Недвижимость",
            Title = "Потрясающая комната для аренды",
            Description = "Потрясающая квартира только для вас с современным  ремонтом, имеется много новых и развитие вещей и т.д.",
            Likes = 20,
            Cost = 300
        }
    };
}