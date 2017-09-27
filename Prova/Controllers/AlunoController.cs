//Anderson Frare
using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Prova.Controllers
{
    public class AlunoController : Controller
    {

        private ApplicationDbContext _context;

        public AlunoController()
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
            var alunos = _context.Alunos.Include(f => f.Faixa).Include(t => t.TipoDeAssociacao).ToList();

            return View(alunos);

        }


        public ActionResult Details(int id)
        {

            var alunos = _context.Alunos.Include(f => f.Faixa).Include(t => t.TipoDeAssociacao).SingleOrDefault(a => a.Id == id);

            if (alunos == null)
            {
                return HttpNotFound();
            }

            return View(alunos);
        }
    }
}