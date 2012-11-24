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
        SGPS.Models.pacienteEntities paciente = new SGPS.Models.pacienteEntities();
        List<SGPS.Models.AtendimentoPaciente> atendimentoPaciente = new List<Models.AtendimentoPaciente>();
        //
        // GET: /Atendimento/
        /// <summary>
        /// Método que exibe um atendimento
        /// </summary>
        /// <returns>view com atendimentos</returns>
        public ActionResult Index()
        {
            RecuperarAtendimento();
            RecuperarPaciente();
            return View(atendimentoPaciente.ToList());
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
            SGPS.Models.pacienteEntities listaPaciente = new SGPS.Models.pacienteEntities();
            ViewData["idPaciente"] = new SelectList(listaPaciente.pacientes.ToList(), "IdPaciente", "strNome");
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
                {
                    return View();
                }
                atendimento.dtmDataAtendimento = DateTime.Now;
                ctx.AddToatendimentoes(atendimento);
                ctx.SaveChanges();
                return Redirect("Index");
            }
            catch
            {
                ViewData["Message"] = "Erro ao tentar cadastrar os dados!";
                return Redirect("Index");
            }
        }

        //
        // GET: /Atendimento/Edit/5
        public ActionResult Edit(int id)
        {
            EditarAtendimento(id);
            return View(atendimentoPaciente.ToList());
        }

        //
        // POST: /Atendimento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Models.AtendimentoPaciente atendimento)
        {
            SGPS.Models.atendimento atendEditado = new Models.atendimento();
            try
            {
                var resultado = (from at in ctx.atendimentoes
                                         where at.idAtendimento == id
                                         select at);
                foreach(var item in resultado)
                {
                    atendEditado = item;
                }
                if (!ModelState.IsValid)
                    return Redirect("Index");
                else
                {
                    if (atendimento.MotivoAtendimento != atendEditado.strMotivoAtendimento)
                    {
                        atendEditado.strMotivoAtendimento = atendimento.MotivoAtendimento;
                    }
                    if (atendimento.ProvidenciaAtendimento != atendEditado.strProvidencias)
                    {
                        atendEditado.strProvidencias = atendimento.ProvidenciaAtendimento;
                    }                    
                }
                var result = (from p in ctx.atendimentoes
                              where p.idAtendimento == id
                              select p).First();
                ctx.ApplyCurrentValues(result.EntityKey.EntitySetName, atendEditado);
                return Redirect("Index");
            }
            catch
            {
                return Redirect("Index");
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


        #region Métodos Privados

        private void RecuperarPaciente()
        {
            foreach (var at in atendimentoPaciente)
            {
                var resultado = (from pacienteSelecionado in paciente.pacientes
                                 where at.IdPaciente == pacienteSelecionado.idPaciente
                                 select pacienteSelecionado.strNome);
                foreach (var item in resultado)
                    at.NomePaciente = item;
            }
        }

        private void RecuperarAtendimento()
        {
            foreach (var p in ctx.atendimentoes)
            {
                atendimentoPaciente.Add(new Models.AtendimentoPaciente(p.idAtendimento, p.idPaciente,
                    p.strMotivoAtendimento, p.strProvidencias, p.dtmDataAtendimento));
            }
        }

        private void EditarAtendimento(int id)
        {
            var resultado = (from at in ctx.atendimentoes
                             where at.idAtendimento == id
                             select at);
            foreach (var p in resultado)
            {
                atendimentoPaciente.Add(new Models.AtendimentoPaciente(p.idAtendimento, p.idPaciente,
                    p.strMotivoAtendimento, p.strProvidencias, p.dtmDataAtendimento));
            }

            RecuperarPaciente();
        }

        #endregion
    }

}

