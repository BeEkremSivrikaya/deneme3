using AspNetCore.Reporting;
using deneme3.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RDLCDesign;
namespace deneme3.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        public ReportController (IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Print()
        {
            Context1 c = new Context1();
            string mimtype = "";
            int extension = 1;
            var path = $"{this.webHostEnvironment.WebRootPath}\\Reports\\Report1.rdlc";
            Dictionary<string,string> parametres=new Dictionary<string,string>();
            //parametres.Add("rp1", "Merhaba MinikodAkademi");
            
            LocalReport localReport = new LocalReport(path);
            //localReport.AddDataSource();
            //localReport.AddDataSource("EntityLayer.Tables.Ogrenci", c.ogrencis);
            var result = localReport.Execute(RenderType.Pdf, extension, parametres,mimtype);
            return File(result.MainStream, "application/pdf");
                }
        
    }
}
