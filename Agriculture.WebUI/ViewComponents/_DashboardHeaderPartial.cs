﻿using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.ViewComponents
{
    public class _DashboardHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
