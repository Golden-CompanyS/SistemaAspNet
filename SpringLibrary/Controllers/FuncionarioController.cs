﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpringLibrary.Models;
using SpringLibrary.Repositorio;
using System.Web.Mvc;

namespace SpringLibrary.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult FuncionarioView()
        {
            var funcio = new Funcionario();
            return View(funcio);
        }

        Acoes ac = new Acoes();

        [HttpPost]

        public ActionResult FuncionarioView(Funcionario funcio)
        {
            ac.CadastrarFuncionario(funcio);
            return View("Resultado", funcio);
        }
    }
}