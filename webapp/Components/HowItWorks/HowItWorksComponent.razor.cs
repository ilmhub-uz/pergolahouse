using System.ComponentModel;
using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Components.HowItWorks;

public partial class HowItWorksComponent : ComponentBase
{
    protected List<HowItWorksCardComponentModel> Models = new List<HowItWorksCardComponentModel>()
    {
        new HowItWorksCardComponentModel()
        {
            Title = "Коммуникация",
            Description = "Вы найдете нас через социальные сети или наш адрес."
        },
        new HowItWorksCardComponentModel()
        {
            Title = "Мера и дизайн",
            Description = "Мы приедем к вам, замерим и спроектируем."
        },
        new HowItWorksCardComponentModel()
        {
            Title = "Доставка и установка",
            Description = "Мы сами доставим по вашему адресу и бесплатно установим."
        }
    };
}