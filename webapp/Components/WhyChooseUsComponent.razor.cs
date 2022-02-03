using Microsoft.AspNetCore.Components;

namespace webapp.Components;

public partial class WhyChooseUsComponent : ComponentBase
{
    [Parameter]
    public List<CardComponentModel> CardComponentModels { get; set; } = new List<CardComponentModel>()
    {
        new CardComponentModel()
        {
            Title = "Честная сделка",
            Description = "Мы предоставляем все наши услуги на основе честного и законного договора."
        },
        new CardComponentModel()
        {
            Title = "Качественная продукция",
            Description = "Мы даем гарантию на все товары, которые мы продаем, и услуги, которые мы предоставляем."
        },
        new CardComponentModel()
        {
            Title = "Пунктуальность",
            Description = "Выполним работу вовремя, в оговоренные сроки."
        },
        new CardComponentModel()
        {
            Title = "Сервисные услуги",
            Description = "Всегда готовы предоставить необходимую помощь."
        },
        new CardComponentModel()
        {
            Title = "Инновационные изделия",
            Description = "Мы используем новейшие, инновационные разработки."
        },
        new CardComponentModel()
        {
            Title = "Бесплатные Бонусы",
            Description = "Замер, дизайн, доставка и установка бесплатно."
        },
    };

}