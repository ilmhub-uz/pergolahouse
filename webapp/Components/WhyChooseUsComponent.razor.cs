using Microsoft.AspNetCore.Components;

namespace webapp.Components;

public partial class WhyChooseUsComponent : ComponentBase
{
    [Parameter]
    public List<CardComponentModel> CardComponentModels { get; set; } = new List<CardComponentModel>()
    {
        new CardComponentModel()
        {
            Icon = "far fa-handshake",
            Title = "Честная сделка",
            Description = "Мы предоставляем все наши услуги на основе честного и законного договора."
        },
        new CardComponentModel()
        {
            Icon = "fas fa-check-square",
            Title = "Качественная продукция",
            Description = "Мы даем гарантию на все товары, которые мы продаем, и услуги, которые мы предоставляем."
        },
        new CardComponentModel()
        {
            Icon = "far fa-clock",
            Title = "Пунктуальность",
            Description = "Выполним работу вовремя, в оговоренные сроки."
        },
        new CardComponentModel()
        {
            Icon = "fas fa-tools",
            Title = "Сервисные услуги",
            Description = "Всегда готовы предоставить необходимую помощь."
        },
        new CardComponentModel()
        {
            Icon = "fab fa-connectdevelop",
            Title = "Инновационные изделия",
            Description = "Мы используем новейшие, инновационные разработки."
        },
        new CardComponentModel()
        {
            Icon = "fas fa-donate",
            Title = "Бесплатные Бонусы",
            Description = "Замер, дизайн, доставка и установка бесплатно."
        }
    };

}