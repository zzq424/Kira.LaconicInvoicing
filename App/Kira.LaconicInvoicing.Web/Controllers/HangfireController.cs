﻿
using System.ComponentModel;

using Microsoft.AspNetCore.Mvc;

using OSharp.Core.Modules;


namespace Kira.LaconicInvoicing.Web.Controllers
{
    [Description("网站-Hangfire后台任务")]
    [ModuleInfo(Order = 4)]
    public class Hangfire3Controller : BaseApiController
    {
        [HttpGet]
        [Description("Hangfire首页")]
        public IActionResult Index()
        {
            return Redirect("/hangfire2");
        }
    }
}
