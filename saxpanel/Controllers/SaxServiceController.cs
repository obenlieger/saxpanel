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
    public class SaxServiceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SaxServiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var composes = _context.SaxComposes.ToList();

            ViewBag.composes = composes;

            return View();
        }
    }
}