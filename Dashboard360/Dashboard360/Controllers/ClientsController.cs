﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dashboard360.Controllers
{
    public class ClientsController : Controller
    {   
        //Get:      

        // GET: /Clients/
        public ActionResult List()
        {
            return View();
        }

    }
}
