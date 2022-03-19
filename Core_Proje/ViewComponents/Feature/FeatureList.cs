using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
