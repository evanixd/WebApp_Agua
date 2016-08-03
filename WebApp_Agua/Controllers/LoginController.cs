using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_Agua.Models;

namespace WebApp_Agua.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult login(loginModel usuario)
        {
            if (ModelState.IsValid)
            {
                using (BDAguaEntities dc = new BDAguaEntities())
                {


                    var user = dc.Usuarios.Where(a => a.usuario1.Equals(usuario.Username) && a.password.Equals(usuario.Password)).FirstOrDefault();
                    if (user != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Msg = "Usuario o Contraseña Incorrectos";
                        return View();
                    }
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Usuario y contraseña obligatorios");
            }
            return View();
        }

    }

   
}