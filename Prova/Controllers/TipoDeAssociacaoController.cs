//Anderson Frare
using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prova.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        private ApplicationDbContext _context;

        public TipoDeAssociacaoController()
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
            var tiposDeAssociacao = _context.TiposDeAssociacao.ToList();

            return View(tiposDeAssociacao);

        }


        public ActionResult Details(int id)
        {

            var tiposDeAssociacao = _context.TiposDeAssociacao.SingleOrDefault(t => t.Id == id);

            if (tiposDeAssociacao == null)
            {
                return HttpNotFound();
            }

            return View(tiposDeAssociacao);
        }
    }
}