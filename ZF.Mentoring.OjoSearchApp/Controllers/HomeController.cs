using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using ZF.Mentoring.OjoSearchApp.Data;
using ZF.Mentoring.OjoSearchApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ZF.Mentoring.OjoSearchApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public List<SearchResults> GetLocalResults (string searchText)
        {
            return dbContext.SearchResults.FromSqlRaw("SearchResults {0}", searchText).ToList();
        }

        [HttpPost]
        public void UpdateLocalResults([FromBody] UpdateSearchResults results)
        {
            string goodsXML = ToXml(results, false);
            dbContext.Database.ExecuteSqlRaw("UpsertResults {0}", goodsXML);
        }

        public static string ToXml(Object objToXml, bool includeNameSpace)
        {
            string buffer;
            System.IO.StringWriter stWriter = null;

            try
            {
                stWriter = new System.IO.StringWriter();
                var xmlSerializer = new System.Xml.Serialization.XmlSerializer(objToXml.GetType());
                if (!includeNameSpace)
                {
                    var xs = new System.Xml.Serialization.XmlSerializerNamespaces();

                    //To remove namespace and any other inline information tag
                    xs.Add("", "");
                    xmlSerializer.Serialize(stWriter, objToXml, xs);
                }
                else
                {
                    xmlSerializer.Serialize(stWriter, objToXml);
                }
                buffer = stWriter.ToString();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (stWriter != null) stWriter.Close();
            }
            return buffer;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
