using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PoolSaison2019.Controllers
{
    public class SignaturesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //GET:Signatures/SignaturesRecente/5
        public async Task<IActionResult> SignatureRecente(int? id = -1, string? nomDeFamille = " ", string? villeEquipe = " ")
        {
            ViewData["id"] = id;
            ViewData["nomDeFamille"] = nomDeFamille;
            ViewData["villeEquipe"] = villeEquipe;

            return View();
        }
    }
}