using Desafio.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using static Desafio.Models.Api;

namespace Desafio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var url = "https://www.receitaws.com.br/v1/cnpj/27865757000102";
            WebClient wc = new WebClient();
            var dados = wc.DownloadString(url);
            var rs = JsonConvert.DeserializeObject<Root>(dados);

            return View(rs);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}