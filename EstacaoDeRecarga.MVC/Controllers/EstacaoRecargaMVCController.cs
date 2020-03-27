using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacaoDeRecarga.Aplicacao.ViewModel;
using EstacoesDeRecarga.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstacaoDeRecarga.MVC.Controllers
{
    public class EstacaoRecargaMVCController : Controller
    {
        private readonly IAppEstacaoRecarga _appEstacaoRecarga;

        public EstacaoRecargaMVCController(IAppEstacaoRecarga appEstacaoRecarga)
        {
            _appEstacaoRecarga = appEstacaoRecarga;
        }

        // GET: EstacaoRecargaMVC
        public ActionResult Index()
        {
            var produtos = _appEstacaoRecarga.Listar();
            return View(produtos);
        }

        // GET: EstacaoRecargaMVC/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_appEstacaoRecarga.RecuperarPorId(id));
        }

        // GET: EstacaoRecargaMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstacaoRecargaMVC/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstacaoRecargaViewModel estacaoRecargaMV)
        {
            try
            {
                estacaoRecargaMV.Id = Guid.NewGuid();
                _appEstacaoRecarga.Adicionar(estacaoRecargaMV);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: EstacaoRecargaMVC/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_appEstacaoRecarga.RecuperarPorId(id));
        }

        // POST: EstacaoRecargaMVC/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstacaoRecargaViewModel estacaoRecargaMV)
        {
            try
            {
                _appEstacaoRecarga.Atualizar(estacaoRecargaMV);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstacaoRecargaMVC/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_appEstacaoRecarga.RecuperarPorId(id));
        }

        // POST: EstacaoRecargaMVC/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EstacaoRecargaViewModel estacaoRecargaMV)
        {
            try
            {
                _appEstacaoRecarga.Excluir(estacaoRecargaMV);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}