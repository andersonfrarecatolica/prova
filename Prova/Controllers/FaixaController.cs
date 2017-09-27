//Anderson Frare
using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prova.Controllers
{
    public class FaixaController : Controller
    {
        private ApplicationDbContext _context;

        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Aluno
        public ActionResult Index()
        {
            var faixas = _context.Faixas.ToList();

            return View(faixas);

        }


        public ActionResult Details(int id)
        {

            var faixa = _context.Faixas.SingleOrDefault(f => f.Id == id);

            if (faixa == null)
            {
                return HttpNotFound();
            }

            return View(faixa);
        }
    }
}