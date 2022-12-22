using AutoMapper;
using HaianhShop.Model.Models;
using HaianhShop.Service;
using HaianhShop.Web.Models;
using System.Web.Mvc;

namespace HaianhShop.Web.Controllers
{
    public class PageController : Controller
    {
        IPageService _pageService;
        public PageController(IPageService pageService)
        {
            this._pageService = pageService;
        }
        // GET: Page
        public ActionResult Index(string alias)
        {
            var page = _pageService.GetByAlias(alias);
            var model = Mapper.Map<Page, PageViewModel>(page);
            return View(model);
        }
    }
}