using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGPS.Controllers
{
    public class EncaminhamentoController : Controller
    {
        SGPS.Models.encaminhamentoEntities ctx = new Models.encaminhamentoEntities();
        SGPS.Models.pacienteEntities paciente = new SGPS.Models.pacienteEntities();
        SGPS.Models.hospitalEntities hospital = new SGPS.Models.hospitalEntities();
        List<SGPS.Models.EncaminhamentoRelacionado> encaminhamentos = new List<Models.EncaminhamentoRelacionado>();


        public ActionResult Index()
        {
            RelacionarEncaminhamento();
            return View(encaminhamentos.ToList());
        }

        public ActionResult Create()
        {
            ViewData["idPaciente"] = new SelectList(paciente.pacientes.ToList(), "IdPaciente", "strNome");
            ViewData["idHospital"] = new SelectList(hospital.hospitals.ToList(), "IdHospital", "strRazaoSocial");
            return View();
        } 

        //
        // POST: /Encaminhamento/Create

        [HttpPost]
        public ActionResult Create(Models.encaminhamento encaminhamento)
        {
            try
            {
                encaminhamento.dtmDataEncaminhamento = DateTime.Now;
                ctx.AddToencaminhamentoes(encaminhamento);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Encaminhamento/Edit/5
 
        public ActionResult Edit(int id)
        {
            var result = (from enc in ctx.encaminhamentoes
                          where enc.idEncaminhamento == id
                          select enc);
            SGPS.Models.encaminhamento editarCampos = new Models.encaminhamento();
            foreach (var item in result)
            {
                editarCampos = item;
            }

            ViewData["idPaciente"] = new SelectList(paciente.pacientes.ToList(), "IdPaciente", "strNome", editarCampos.idPaciente);
            ViewData["idHospital"] = new SelectList(hospital.hospitals.ToList(), "IdHospital", "strRazaoSocial", editarCampos.idHospital);
            return View(result.ToList());            
        }

        //
        // POST: /Encaminhamento/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Models.encaminhamento encaminhamentoEditado)
        {            
            SGPS.Models.encaminhamento encEditado = new Models.encaminhamento();
            encaminhamentoEditado.idEncaminhamento = id;
            encaminhamentoEditado.idHospital = Convert.ToInt32(Request.Form["item.idHospital"]);
            encaminhamentoEditado.idPaciente = Convert.ToInt32(Request.Form["item.idPaciente"]);
            encaminhamentoEditado.strMotivo = Request.Form["item.strMotivo"];
            encaminhamentoEditado.strSituacaoAtual = Request.Form["item.strSituacaoAtual"];
            try
            {
                var result = (from enc in ctx.encaminhamentoes
                              where enc.idEncaminhamento == id
                              select enc);

                foreach (var item in result)
                {
                    encEditado = item;
                }
                if (!ModelState.IsValid)
                    return Redirect("Index");
                else
                {
                    if (encEditado.idPaciente != encaminhamentoEditado.idPaciente)
                    {
                        encEditado.idPaciente = encaminhamentoEditado.idPaciente;
                    }
                    if (encEditado.strMotivo != encaminhamentoEditado.strMotivo)
                    {
                        encaminhamentoEditado.strMotivo = encaminhamentoEditado.strMotivo;
                    }
                    if (encEditado.strSituacaoAtual != encaminhamentoEditado.strSituacaoAtual)
                    {
                        encEditado.strSituacaoAtual = encaminhamentoEditado.strSituacaoAtual;
                    }
                    if (encEditado.idHospital != encaminhamentoEditado.idHospital)
                    {
                        encEditado.idHospital = encaminhamentoEditado.idHospital;
                    }
                }
                var resultado = (from enc in ctx.encaminhamentoes
                              where enc.idEncaminhamento == id
                              select enc).First();
                ctx.ApplyCurrentValues(resultado.EntityKey.EntitySetName, encEditado);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        //
        // GET: /Encaminhamento/Delete/5
 
        public ActionResult Delete(int id)
        {
            RelacionarEncaminhamento(id);
            return View(encaminhamentos.ToList());
        }

        //
        // POST: /Encaminhamento/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var resultado = (from enc in ctx.encaminhamentoes
                                 where enc.idEncaminhamento == id
                                 select enc).First();
                if (!ModelState.IsValid)
                    return View();
                ctx.DeleteObject(resultado);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ListaAtendimento(Models.paciente paciente)
        {
            if (ModelState.IsValid)
            {
                var result = (from r in ctx.encaminhamentoes
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

        public ActionResult ListaHospital(Models.hospital hospital)
        {
            if (ModelState.IsValid)
            {
                var result = (from r in ctx.encaminhamentoes
                              where r.idHospital == hospital.idHospital
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

        private void RelacionarEncaminhamento()
        {
            foreach (var enc in ctx.encaminhamentoes)
            {
                encaminhamentos.Add(new SGPS.Models.EncaminhamentoRelacionado(enc.idEncaminhamento,
                    enc.idHospital, enc.idPaciente, enc.strMotivo, enc.strSituacaoAtual, enc.dtmDataEncaminhamento));
            }
            RecuperarHospital();
            RecuperarPaciente();
        }

        private void RelacionarEncaminhamento(int id)
        {
            var resultado = (from enc in ctx.encaminhamentoes
                             where enc.idEncaminhamento == id
                             select enc);
            foreach (var item in resultado)
            {
                encaminhamentos.Add(new SGPS.Models.EncaminhamentoRelacionado(item.idEncaminhamento, item.idHospital, 
                    item.idPaciente, item.strMotivo, item.strSituacaoAtual, item.dtmDataEncaminhamento));
            }
            RecuperarHospital();
            RecuperarPaciente();
        }

        private void RecuperarPaciente()
        {
            foreach (var enc in encaminhamentos)
            {
                var resultado = (from pac in paciente.pacientes
                                 where enc.IdPaciente == pac.idPaciente
                                 select pac.strNome);
                foreach (var item in resultado)
                {
                    enc.NomePaciente = item;
                }
            }
        }

        private void RecuperarHospital()
        {
            foreach (var enc in encaminhamentos)
            {
                var resultado = (from hosp in hospital.hospitals
                                 where enc.IdHospital == hosp.idHospital
                                 select hosp.strRazaoSocial);
                foreach (var item in resultado)
                {
                    enc.NomeHospital = item;
                }
            }
        }

        #endregion
    }
}
// protected IQueryable listarProfissionais()
//        {
//            var context = new SGPSEntities();

//            var resultado = (from item in context.Profissional
//                             orderby item.Nome
//                             select new { Text = item.Nome, Value = item.Cpf });

//            List<SelectListItem> lista = new List<SelectListItem>();

//            return resultado;
//        }
//tem assim tbm: ViewBag.CPF_PACIENTE = new SelectList(db.Paciente, "Cpf", "Nome", encaminhamento.CpfPaciente);