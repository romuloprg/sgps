using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGPS.Controllers
{
    /// <summary>
    /// Classe de controle da entidade Hospital
    /// Programdor responsável: Lorena Adrian
    /// </summary>
    public class HospitalController : Controller
    {
        // Recupera o modelo de dados de hospital
        private SGPS.Models.hospitalEntities ctx = new SGPS.Models.hospitalEntities();

        /// <summary>GET: /Hospital/
        /// Método que exibe a página principal do módulo de hospital
        /// </summary>
        /// <returns>Lista de hospitais cadastrados</returns>
        public ActionResult Index()
        {
            string name = Request.Form["namePesquisa"];
            if (name == null)
            {
                return View(ctx.hospitals.ToList());
            }
            else
            {
                var result = (from p in ctx.hospitals
                              where p.strRazaoSocial.Contains(name)
                              select p);
                return View(result.ToList());
            }
        }

        /// <summary>
        /// Método de requisição da View para inclusão de cadastro de hospital
        /// </summary>
        /// <returns>view parcial para inclusão de dados</returns>
        [HttpGet]
        public ActionResult IncluirHospital()
        {
            if (ModelState.IsValid)
                return PartialView("IncluirHospital");
            else return new EmptyResult();
        }

        /// <summary>
        /// Método de inclusão de dados no banco de dados.
        /// </summary>
        /// <param name="novoHospital">Novo registro</param>
        /// <returns>View principal do controle</returns>
        [HttpPost]
        public ActionResult IncluirHospital(SGPS.Models.hospital novoHospital)
        {
            try
            {
                if (!ModelState.IsValid)
                    return RedirectToAction("Index");

                ctx.AddTohospitals(novoHospital);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        //
        // GET: /Hospital/Edit/5
        /// <summary>
        /// Método acionado para edição de dados
        /// </summary>
        /// <param name="id">id do cadastro a ser editado</param>
        /// <returns>view com campos para edição de dados</returns>
        public ActionResult AlterarHospital(int id)
        {
            var result = (from h in ctx.hospitals
                          where h.idHospital == id
                          select h).First();
            return View(result);
        }

        //
        // POST: /Hospital/Edit/5
        /// <summary>
        /// Método acionado para efetuar atualização de dados no banco de dados
        /// </summary>
        /// <param name="id">id do cadastro a ser alterado</param>
        /// <param name="hospital">ojeto a ser alterado</param>
        /// <returns>confirmação da alteração do registro</returns>
        [HttpPost]
        public ActionResult AlterarHospital(int id, Models.hospital hospital)
        {
            hospital.idHospital = id;
            try
            {
                var result = (from h in ctx.hospitals
                              where h.idHospital == hospital.idHospital
                              select h).First();

                if (!ModelState.IsValid)
                    return View();

                ctx.ApplyCurrentValues(result.EntityKey.EntitySetName, hospital);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        //
        // GET: /Hospital/Delete/5
        /// <summary>
        /// Método acinado para exclusão de cadastro.
        /// </summary>
        /// <param name="id">identificação do registro a ser excluído</param>
        /// <returns>view solicitando confirmação de exclusão</returns>
        public ActionResult ExcluirHospital(int id)
        {
            var result = (from h in ctx.hospitals
                          where h.idHospital == id
                          select h).First();
            return View(result);
        }

        //
        // POST: /Hospital/Delete/5
        /// <summary>
        /// Método acionado para exclusão de registro no banco de dados
        /// </summary>
        /// <param name="id">identificão do registro</param>
        /// <param name="collection">registro a ser excluído</param>
        /// <returns>confirmação da exclusão do registro</returns>
        [HttpPost]
        public ActionResult ExcluirHospital(int id, FormCollection collection)
        {
            try
            {
                var result = (from h in ctx.hospitals
                              where h.idHospital == id
                              select h).First();
                if (!ModelState.IsValid)
                    return View();
                ctx.DeleteObject(result);
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
