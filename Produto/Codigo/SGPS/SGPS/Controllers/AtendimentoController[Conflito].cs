using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;

namespace SGPS.Controllers
{
    public class AtendimentoController : Controller
    {
        SGPS.Models.atendimentoEntities ctx = new SGPS.Models.atendimentoEntities();
        //
        // GET: /Atendimento/
        /// <summary>
        /// Método que exibe um atendimento
        /// </summary>
        /// <returns>view com atendimentos</returns>
        public ActionResult Index()
        {

            var paciente = new SGPS.Models.pacienteEntities();
            string name = Request.Form["namePesquisa"];
            if (Request.Form["namePesquisa"] == null)
            {
                ViewData["SelectList"] = new SelectList(paciente.pacientes, "IdPaciente", "strNome");
                return View();
            }
            else
            {
                var pacienteSelecionado = (from p in paciente.pacientes
                                           where p.strNome.Contains(name)
                                           select p).First();

                var result = (from at in ctx.atendimentoes
                              where at.idPaciente == pacienteSelecionado.idPaciente
                              select at).First();
                return View(result);
            }
        }

        /// <summary>
        /// Método para exibição de pesquisa para exclusão de registro.
        /// </summary>
        /// <returns>view com registros</returns>
        public ActionResult Index2()
        {
            if (Request.Form["namePesquisa"] == null)
                return View(ctx.atendimentoes.ToList());
            else
            {
                string name = Request.Form["namePesquisa"];
                var paciente = new SGPS.Models.pacienteEntities();
                var pacienteSelecionado = (from p in paciente.pacientes
                                           where p.strNome.Contains(name)
                                           select p).First();

                var result = (from at in ctx.atendimentoes
                              where at.idPaciente == pacienteSelecionado.idPaciente
                              select at).First();
                return View(result);
            }
        }


        //
        // GET: /Atendimento/Details/5

        public ActionResult Details(int id)
        {
            var result = (from at in ctx.atendimentoes where at.idAtendimento == id select at).First();
            return View(result);
        }

        //
        // GET: /Atendimento/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Atendimento/Create

        [HttpPost]
        public ActionResult Create(Models.atendimento atendimento)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                ctx.AddToatendimentoes(atendimento);
                ctx.SaveChanges();
                ViewData["Message"] = "Dados cadastrados com sucesso!";
                return View(atendimento);
            }
            catch
            {
                ViewData["Message"] = "Erro ao tentar cadastrar os dados!";
                return View();
            }
        }

        //
        // GET: /Atendimento/Edit/5

        public ActionResult Edit(int id)
        {
            var result = (from at in ctx.atendimentoes
                          where at.idAtendimento == id
                          select at).First();
            return View(result);
        }

        //
        // POST: /Atendimento/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Models.atendimento atendimento)
        {
            atendimento.idAtendimento = id;
            try
            {
                var result = (from at in ctx.atendimentoes
                              where at.idAtendimento == atendimento.idAtendimento
                              select at).First();

                if (!ModelState.IsValid)
                    return View();

                ctx.ApplyCurrentValues(result.EntityKey.EntitySetName, atendimento);
                ctx.SaveChanges();
                ViewData["Message"] = "Dados alterados com sucesso!";
                return View(result);
            }
            catch
            {
                ViewData["Message"] = "Erro ao tentar alterar os dados!";
                return View();
            }
        }

        //
        // GET: /Atendimento/Delete/5

        public ActionResult Delete(int id)
        {
            var result = (from at in ctx.atendimentoes
                          where at.idAtendimento == id
                          select at).First();
            return View(result);
        }

        //
        // POST: /Atendimento/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var result = (from at in ctx.atendimentoes
                              where at.idAtendimento == id
                              select at).First();
                if (!ModelState.IsValid)
                    return View();
                ctx.DeleteObject(result);
                ctx.SaveChanges();
                ViewData["Message"] = "Dados excluídos com sucesso!";
                return View();
            }
            catch
            {
                ViewData["Message"] = "Erro ao tentar excluir os dados";
                return View();
            }
        }

        public ActionResult ListaAtendimento(Models.paciente paciente)
        {
            if (ModelState.IsValid)
            {
                var result = (from r in ctx.atendimentoes
                              where r.idPaciente == paciente.idPaciente
                              select r);
                if (result != null)
                {
                    return PartialView(result);
                }
                else return View();
            }
            else
                return View();
        }
    }
}
