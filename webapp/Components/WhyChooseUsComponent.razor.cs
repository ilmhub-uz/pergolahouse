using Microsoft.AspNetCore.Components;

namespace webapp.Components;

public partial class WhyChooseUsComponent : ComponentBase
{
    [Parameter]
    public List<CardComponentModel> CardComponentModels { get; set; } = new List<CardComponentModel>()
    {
        new CardComponentModel()
        {
            Title = "Fully Documented",
            Description = "Buy and sell everything from used cars to mobile phones and computer or search for property."
        },
        new CardComponentModel()
        {
            Title = "Clean & Modern Design",
            Description = "Buy and sell everything from used cars to mobile phones and computer or search for property."
        },
        new CardComponentModel()
        {
            Title = "Completely Customizable",
            Description = "Buy and sell everything from used cars to mobile phones and computer or search for property."
        },
        new CardComponentModel()
        {
            Title = "User Friendly",
            Description = "Buy and sell everything from used cars to mobile phones and computer or search for property."
        },
        new CardComponentModel()
        {
            Title = "Awesome Layout",
            Description = "Buy and sell everything from used cars to mobile phones and computer or search for property."
        },
        new CardComponentModel()
        {
            Title = "Fully Responsive",
            Description = "Buy and sell everything from used cars to mobile phones and computer or search for property."
        },
    };

}