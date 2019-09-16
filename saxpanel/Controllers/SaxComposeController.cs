using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using saxpanel.Data;
using saxpanel.Helper;
using saxpanel.Models;

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
            var composes = _context.SaxComposes.ToList();

            return View(composes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SaxCompose saxcompose)
        {
            try
            {
                _context.SaxComposes.Add(saxcompose);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}