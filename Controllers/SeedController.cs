
using Business.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;

namespace Controllers
{
    public class SeedController : Controller
    {
        ISeedBusiness SeedBusiness { get; }
        private readonly string currentUserId;
        public SeedController(ISeedBusiness _seedBusiness, IHttpContextAccessor _httpContextAccessor)
        {
            SeedBusiness = _seedBusiness;
            currentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        public ActionResult AddDicoInDB()
        {
            SeedBusiness.AddDicoInDB();
            return View();
        }
    }
}
