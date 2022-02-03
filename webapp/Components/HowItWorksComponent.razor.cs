using System.ComponentModel;
using Microsoft.AspNetCore.Components;
using webapp.Models;

namespace webapp.Components;

public partial class HowItWorksComponent : ComponentBase
{
    protected List<HowItWorksCardComponentModel> Models = new List<HowItWorksCardComponentModel>()
    {
        new HowItWorksCardComponentModel()
        {
            Title = "Aloqa o'rnatish",
            Description = "Bizni ijtimoiy tarmoqlar yoki manzilimiz orqali topasiz."
        },
        new HowItWorksCardComponentModel()
        {
            Title = "O'lchov va dizayn",
            Description = "Manzilingizga borib o'lchaymiz va dizayn yaratamiz."
        },
        new HowItWorksCardComponentModel()
        {
            Title = "Yetkazish va o'rnatish",
            Description = "O'zimiz manzilingizga yetkazib beramiz va bepul o'rnatib beramiz."
        }
    };
}