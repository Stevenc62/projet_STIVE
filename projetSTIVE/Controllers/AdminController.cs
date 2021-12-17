using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetSTIVE.Models;

namespace projetSTIVE.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FormSupplier()
        {
            return View();
        }

        //Envoi du formulaire en BDD
        public IActionResult SubmitFormSupplier([Bind("Name, Address, Zipcode, City, Email")] Supplier supplier)
        {
            if (supplier.Save())
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("FormSupplier", "Admin", new { error = true, message = "Erreur d'insertion" });
            }
        }

        //Permet la redirection vers la page de login si on est pas connecté
        private IActionResult RedirectToLogin()
        {
            return RedirectToAction("Index", "Login");
        }

    }
}
