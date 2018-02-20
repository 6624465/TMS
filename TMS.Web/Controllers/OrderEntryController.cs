using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TMS.Web.Controllers
{
    public class OrderEntryController : Controller
    {
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}