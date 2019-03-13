﻿// -----------------------------------------------------------------------
//  <copyright file="AdminApiController.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:50</last-date>
// -----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

using OSharp.AspNetCore.Mvc;
using OSharp.Core;


namespace Kira.LaconicInvoicing.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [RoleLimit]
    public abstract class AdminApiController : AreaApiController
    { }
}