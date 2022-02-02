using Microsoft.AspNetCore.Components;
using webapp.Model;

namespace webapp.Components;

public partial class ItemsGridComponent : ComponentBase
{
    public List<ItemModel> ItemModels = new List<ItemModel>
    {
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Real Estate",
            Title = "Amazing Room for Rent",
            Description = "Uzskdlsdkclsdc scdklsdc slk dck dsds ls kds d ddsdssdsdc sdscs.",
            Likes = 20,
            Cost = 300
        },
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Real Estate",
            Title = "Amazing Room for Rent",
            Description = "Uzskdlsdkclsdc scdklsdc slk dck dsds ls kds d ddsdssdsdc sdscs.",
            Likes = 20,
            Cost = 300
        },
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Real Estate",
            Title = "Amazing Room for Rent",
            Description = "Uzskdlsdkclsdc scdklsdc slk dck dsds ls kds d ddsdssdsdc sdscs.",
            Likes = 20,
            Cost = 300
        },
        new ItemModel()
        {
            DetailImage = "assets/images/items-grid/img2.jpg",
            Tag = "Real Estate",
            Title = "Amazing Room for Rent",
            Description = "Uzskdlsdkclsdc scdklsdc slk dck dsds ls kds d ddsdssdsdc sdscs.",
            Likes = 20,
            Cost = 300
        }
    };
}