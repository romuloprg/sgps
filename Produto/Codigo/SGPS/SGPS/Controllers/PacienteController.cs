using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace SGPS.Controllers
{
    public class PacienteController : Controller
    {
        private SGPS.Models.pacienteEntities ctx = new SGPS.Models.pacienteEntities();

        public ActionResult LerXml()
        {
            try
            {
                XmlReader reader = XmlReader.Create(@"C:\Exemplo.xml");

                while (reader.Read()) /// Enquanto houver elementos a serem lidos. Cada iteração corresponde ao registro de um paciente.
                {
                    SGPS.Models.paciente registro = new SGPS.Models.paciente();

                    /// Ao chegar no elemento "nome" (primeiro atributo de um paciente), iniciar a leitura dos dados para gravação no BD
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "nome"))
                    {                        
                        registro.strNome = reader.ReadString();
                        reader.Read();
                        reader.Read();
                        registro.strCategoria = reader.ReadString();
                        reader.Read();
                        reader.Read();
                        registro.strDataDeNascimento = reader.ReadString();
                        reader.Read();
                        reader.Read();
                        registro.strCpf = reader.ReadString();
                        reader.Read();
                        reader.Read();
                        registro.strEndereco = reader.ReadString();
                        reader.Read();
                        reader.Read();
                        registro.strTelefone = reader.ReadString();

                        //registro.strDataDeNascimento = DateTime.Parse(strDataDeNascimento.ToString(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat));

                        /// Adicionar o registro lido ao BD
                        ctx.AddTopacientes(registro);
                        ctx.SaveChanges(); /// Commit
                    }
                }

                ViewData["Message"] = "Arquivo carregado com sucesso!";
                return Redirect("Index");
            }
            catch (Exception e)
            {
                ViewData["Message"] = e.Message.ToString();
                return Redirect("Index");
            }
        }

        /// Mensagem de sucesso ao ler o arquivo XML
        public ActionResult SucessoXML()
        {
            return View();
        }

        //
        // GET: /Paciente/

        public ActionResult Index()
        {
            return View(ctx.pacientes.ToList());
        }

        //
        // GET: /Paciente/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Paciente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Paciente/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Paciente/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Paciente/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Paciente/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Paciente/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
