using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Web.UI.ViewComponents
{
    #region Site Footer

    public class SiteFooterViewComponent : ViewComponent
    {
        //#region Ctor

        //private readonly ISiteService _siteService;

        //public SiteFooterViewComponent(ISiteService siteService)
        //{
        //    _siteService = siteService;
        //}

        //#endregion

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var setting = await _siteService.GetDefaultSiteSetting();
            //ViewBag.Setting = setting != null ? setting : new Setting();

            return View();
        }
    }

    #endregion
}
