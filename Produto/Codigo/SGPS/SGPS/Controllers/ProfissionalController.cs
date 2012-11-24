using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGPS.Controllers
{
    public class ProfissionalController : Controller
    {
        // Representa o modelo de entidade de Profissional
        SGPS.Models.profissionalEntities ctx = new SGPS.Models.profissionalEntities();

        /// <summary> GET: /Profissional/
        /// Método controlador da página principal do sistema.
        /// </summary>
        /// <returns>Lista de cadatro de profissionais</returns>
        public ActionResult Index()
        {
            if (Request.Form["namePesquisa"] == null)
                return View(ctx.profissionals.ToList());
            else
            {
                string name = Request.Form["namePesquisa"];
                var result = (from p in ctx.profissionals
                              where p.strNome.Contains(name)
                              select p);
                return View(result.ToList());
            }

        }

        [HttpGet]
        public ActionResult IncluirProfissional()
        {
            if (ModelState.IsValid)
                return PartialView("IncluirProfissional");
            else return new EmptyResult();
        }

        /// <summary>
        /// Método de inclusão de dados no banco de dados.
        /// </summary>
        /// <param name="novoProfissional">Novo registro</param>
        /// <returns>View principal do controle</returns>
        [HttpPost]
        public ActionResult IncluirProfissional(SGPS.Models.profissional novoProfissional)
        {
            try
            {
                if (!ModelState.IsValid)
                    return RedirectToAction("Index");

                ctx.AddToprofissionals(novoProfissional);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        //
        // GET: /Profissional/Edit/5
        /// <summary>
        /// Método acionado para exibir o formulário de edição dos dados do cadastro de profissional.
        /// </summary>
        /// <param name="id">id correspondente do cadastro a ser editado</param>
        /// <returns>retorna uma View para edição de dados.</returns>
        public ActionResult AlterarProfissional(int id)
        {
            var _profissional = (from prof in ctx.profissionals
                                 where prof.idProfissional == id
                                 select prof).First();
            return View(_profissional);
        }

        //
        // POST: /Profissional/Edit/5
        /// <summary>
        /// Método acionado para efetuar a edição dos dados no banco de dados.
        /// </summary>
        /// <param name="id">id do profissional</param>
        /// <param name="profissional">dados alterados.</param>
        /// <returns>view confirmando edição dos dados.</returns>
        [HttpPost]
        public ActionResult AlterarProfissional(int id, Models.profissional profissional)
        {
            try
            {
                profissional.idProfissional = id;
                var result = (from p in ctx.profissionals
                              where p.idProfissional == id
                              select p).First();

                if (!ModelState.IsValid)
                    return View();

                ctx.ApplyCurrentValues(result.EntityKey.EntitySetName, profissional);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        //
        // GET: /Profissional/Delete/5
        /// <summary>
        /// Método acionado quando o usuário requisita uma exclusão de cadastro
        /// </summary>
        /// <param name="id">id do cadastro correspondente para exclusão</param>
        /// <returns>view confirmando a exclusão </returns>
        public ActionResult ExcluirProfissional(int id)
        {
            var _profissional = (from prof in ctx.profissionals
                                 where prof.idProfissional == id
                                 select prof).First();
            return View(_profissional);
        }

        //
        // POST: /Profissional/Delete/5
        /// <summary>
        /// Método acionado para exclusão do cadastro no banco de dados.
        /// </summary>
        /// <param name="id">id correspondente ao cadastro a ser excluído</param>
        /// <param name="collection">objeto a ser excluído</param>
        /// <returns>view confirmando a exclusão no sistema</returns>
        [HttpPost]
        public ActionResult ExcluirProfissional(int id, FormCollection collection)
        {
            try
            {
                var objDeletado = (from prof in ctx.profissionals
                                   where prof.idProfissional == id
                                   select prof).First();
                if (!ModelState.IsValid)
                    return View();
                ctx.DeleteObject(objDeletado);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
