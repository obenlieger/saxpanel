using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using saxpanel.Data;
using saxpanel.Helper;

namespace saxpanel.Controllers
{
    public class SaxComposeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SaxComposeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}