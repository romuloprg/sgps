using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGPS.Controllers
{
    /// <summary>
    /// Classe de controle da entidade Material para atendimento.
    /// </summary>
    public class MaterialAtendimentoController : Controller
    {
        private SGPS.Models.materialEntities ctx = new Models.materialEntities();
        //
        // GET: /MaterialAtendimento/
        /// <summary>
        /// Método invocado para exibição da tela principal do módulo de Gerenciar materiais
        /// </summary>
        /// <returns>view de gerenciar materiais</returns>
        public ActionResult Index()
        {
            if (Request.Form["namePesquisa"] == null)
                return View(ctx.materials.ToList());
            else
            {
                string name = Request.Form["namePesquisa"];

                var result = (from p in ctx.materials
                              where p.strDesMat.Contains(name)
                              select p);
                return View(result.ToList());
            }
        }

        /// <summary>
        /// Exibe lista de cadastros com possibilidade de edição.
        /// </summary>
        /// <returns>view com link para edição</returns>
        public ActionResult Index2()
        {
            if (Request.Form["namePesquisa"] == null)
                return View();
            else
            {
                string name = Request.Form["namePesquisa"];
                var result = (from m in ctx.materials
                              where m.strDesMat.Contains(name)
                              select m);
                return View(result.ToList());
            }
        }
        //
        // GET: /MaterialAtendimento/Details/5

        public ActionResult Details(int id)
        {
            var result = (from m in ctx.materials where m.idMaterial == id select m).First();
            return View(result);

        }

        //
        // GET: /MaterialAtendimento/Create
        /// <summary>
        /// Método invocado para criar novo registro de material.
        /// </summary>
        /// <returns>view contendo o formulário de cadastro</returns>
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /MaterialAtendimento/Create
       /// <summary>
        /// Método invocado para inserir novo registro de material em banco
        /// </summary>
        /// <param name="material">objeto de inserção</param>
        /// <returns>confirmação da inserção do registro</returns>
        [HttpPost]
        public ActionResult Create(Models.material material)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                ctx.AddTomaterials(material);
                ctx.SaveChanges();
                ViewData["Message"] = "Dados cadastrados com sucesso!";
                return View(material);
            }
            catch
            {
                ViewData["Message"] = "Erro ao tentar cadastrar os dados!";
                return View();
            }
        }
        
        //
        // GET: /MaterialAtendimento/Edit/5
        /// <summary>
        /// Método invocado para exibir formulário para edição de um registro
        /// </summary>
        /// <param name="id">identificado do registro</param>
        /// <returns>view contendo formulário de edição</returns>
        public ActionResult Edit(int id)
        {
            var result = (from m in ctx.materials
                          where m.idMaterial == id
                          select m).First();
            return View(result);
        }

        //
        // POST: /MaterialAtendimento/Edit/5
        /// <summary>
        /// Método invocado para efetuar a edição do registro no banco de dados
        /// </summary>
        /// <param name="id">identificador do registro para atualização</param>
        /// <param name="material">informações editadas</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(int id, Models.material material)
        {
             material.idMaterial = id;
            try
            {
                var result = (from m in ctx.materials
                              where m.idMaterial == material.idMaterial
                              select m).First();

                if (!ModelState.IsValid)
                    return View();

                ctx.ApplyCurrentValues(result.EntityKey.EntitySetName, material);
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
        // GET: /MaterialAtendimento/Delete/5
        /// <summary>
        /// Método invocado para exclusão de registro no sistema.
        /// </summary>
        /// <param name="id">identificador do registro</param>
        /// <returns>view de confirmação da exclusão</returns>
        public ActionResult Delete(int id)
        {
            var result = (from m in ctx.materials
                          where m.idMaterial == id
                          select m).First();
            return View(result);
        }

        //
        // POST: /MaterialAtendimento/Delete/5
        /// <summary>
        /// Metodo invocado para efetuar a exclusão do registro no banco de dados
        /// </summary>
        /// <param name="id">identificador do registro</param>
        /// <param name="collection">objeto registro a ser excluído</param>
        /// <returns>confirmaçao da exclusão do registro</returns>
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var result = (from m in ctx.materials
                              where m.idMaterial == id
                              select m).First();
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
    }
}
