using BtkAkademi.Web.Models;
using BtkAkademi.Web.Services.IServices;
using BtkAkademi.Web.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Reflection;

namespace BtkAkademi.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YoneticiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Git()
        {
            return View();
        }

        public IActionResult AdminLogout()
        {
            return SignOut("Cookies", "oidc");
        }


    }
}
