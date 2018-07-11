using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wakalyze.Web.Models;

namespace Wakalyze.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ImportByJson()
        {
            ViewData["Message"] = "Import by json";

            return View();
        }

        [HttpPost]
        public IActionResult ImportByJson(IFormFile file)
        {
            if (file.Length > 0 && file.ContentType == "application/json")
            {
                MemoryStream memory = new MemoryStream();
                using (Stream stream = file.OpenReadStream())
                {
                    stream.CopyTo(memory);
                }
                memory.Position = 0;
                ImportedJsonModel imported = JsonConvert.DeserializeObject<ImportedJsonModel>(Encoding.Default.GetString(memory.ToArray()));
            }

            ViewData["Message"] = "Imported.";

            return View();
        }

        public IActionResult ImportByApi()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
