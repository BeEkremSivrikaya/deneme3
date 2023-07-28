
using deneme3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace deneme3.Controllers
{
    public class AramaController : Controller
    {
        Context1 c = new Context1();

        public IActionResult Index()
        {

            var tableNames = c.Model.GetEntityTypes()
    .Select(t => t.GetTableName())
    .Distinct()
    .ToList();
            var list=new List<KeyValuePair<int,string>>();

            for (int i = 0; i < tableNames.Count; i++)
            {
               
                list.Add(new KeyValuePair<int, string>(i, tableNames[i]));
            }
            //list[0].
            //List<SelectListItem> selectListItems = (from x in tableNames select new SelectListItem { Text = x, Value = tableNames.FindIndex(a => a.Contains(x)).ToString()}).ToList();
            //ViewBag.dgr = selectListItems;
            //    return View(list);
            return View();

        }
        public IActionResult SutunLarıgetir()
        {

            var tableNames = c.Model.GetEntityTypes()
    .Select(t => t.GetTableName())
    .Distinct()
    .ToList();
            List<SelectListItem> selectListItems = (from x in tableNames select new SelectListItem { Text = x, Value = tableNames.FindIndex(a => a.Contains(x)).ToString() }).ToList();
            ViewBag.dgr = selectListItems;
            return View(selectListItems);


        }
    }
}