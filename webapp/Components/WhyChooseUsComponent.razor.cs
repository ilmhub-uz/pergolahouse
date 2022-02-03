using Microsoft.AspNetCore.Components;

namespace webapp.Components;

public partial class WhyChooseUsComponent : ComponentBase
{
    [Parameter]
    public List<CardComponentModel> CardComponentModels { get; set; } = new List<CardComponentModel>()
    {
        new CardComponentModel()
        {
            Title = "Полностью задокументировано",
            Description = "Покупайте и продавайте все, от подержанных автомобилей до мобильных телефонов и компьютеров или ищите недвижимость."
        },
        new CardComponentModel()
        {
            Title = "Чисто & Современные дизайн",
            Description = "Покупайте и продавайте все, от подержанных автомобилей до мобильных телефонов и компьютеров или ищите недвижимость."
        },
        new CardComponentModel()
        {
            Title = "Полностью настраиваемый",
            Description = "Покупайте и продавайте все, от подержанных автомобилей до мобильных телефонов и компьютеров или ищите недвижимость."
        },
        new CardComponentModel()
        {
            Title = "Дружественный интерфейс",
            Description = "Покупайте и продавайте все, от подержанных автомобилей до мобильных телефонов и компьютеров или ищите недвижимость."
        },
        new CardComponentModel()
        {
            Title = "Удивительный макет",
            Description = "Покупайте и продавайте все, от подержанных автомобилей до мобильных телефонов и компьютеров или ищите недвижимость."
        },
        new CardComponentModel()
        {
            Title = "Полностью отзывчивый",
            Description = "Покупайте и продавайте все, от подержанных автомобилей до мобильных телефонов и компьютеров или ищите недвижимость."
        },
    };

}