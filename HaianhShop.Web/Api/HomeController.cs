﻿using HaianhShop.Service;
using HaianhShop.Web.Infrastructure.Core;
using System.Web.Mvc;

namespace HaianhShop.Web.Api
{
    [RoutePrefix("api/home")]
    [Authorize]
    public class HomeController : ApiControllerBase
    {
        IErrorService _errorService;
        public HomeController(IErrorService errorService) : base(errorService)
        {
            this._errorService = errorService;
        }

        [HttpGet]
        [Route("TestMethod")]
        public string TestMethod()
        {
            return "Hello, HAIANH Member. ";
        }
    }
}