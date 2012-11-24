using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGPS.Controllers
{
    public class RelatoriosController : Controller
    {
        SGPS.Models.RelatoriosModel relatorio = new Models.RelatoriosModel();
        SGPS.Models.atendimentoEntities atendimento;
        SGPS.Models.encaminhamentoEntities encaminhamento;
        SGPS.Models.materialEntities material;

        public ActionResult Index()
        {
            return View(relatorio);
        }

        public ActionResult Atendimento(SGPS.Models.RelatoriosModel periodo)
        {
            atendimento = new Models.atendimentoEntities();
            var resultado = (from atend in atendimento.atendimentoes
                             where atend.dtmDataAtendimento >= periodo.DtmDataInicio
                             where atend.dtmDataAtendimento <= periodo.DtmDataFim
                             select atend);
            return View(resultado.ToList());
        }

        public ActionResult Encaminhamento(SGPS.Models.RelatoriosModel periodo)
        {
            encaminhamento = new Models.encaminhamentoEntities();
            var resultado = (from enc in encaminhamento.encaminhamentoes
                             where enc.dtmDataEncaminhamento >= periodo.DtmDataInicio
                             where enc.dtmDataEncaminhamento <= periodo.DtmDataFim
                             select enc);
            return View(resultado.ToList());
        }

        public ActionResult Material(SGPS.Models.RelatoriosModel periodo)
        {
            material = new Models.materialEntities();
            var resultado = (from mat in material.materials
                             select mat);
            return View(resultado.ToList());
        }
    }
}
