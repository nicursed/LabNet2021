using EF.Logic;
using EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCV.Models;
namespace MCV.Controllers
{
    public class TerritoryController : Controller
    {
        TerritoriesLogic logic = new TerritoriesLogic();
        public ActionResult Index()
        {
            List<Territories> territories = logic.GetAll();
            List<TerritoriesView> territoryView = territories.Select(s => new TerritoriesView
            {
                ID = s.TerritoryID,
                regiondId = s.RegionID,
                desc = s.TerritoryDescription
            }).ToList();
            return View(territoryView);
        }

        public ActionResult Insertar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insertar(TerritoriesView territoriesView)
        {
            try {
                var territoryEntity = new Territories
                {
                    RegionID = territoriesView.regiondId,
                    TerritoryID = territoriesView.ID,
                    TerritoryDescription = territoriesView.desc
                };
                logic.Add(territoryEntity);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {

            }

            return View();
        }
        public ActionResult Actualizar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Actualizar(TerritoriesView territoriesView)
        {
            try 
                {
                    var territoryEntity = new Territories
                    {
                        TerritoryID = territoriesView.ID,
                        TerritoryDescription = territoriesView.desc
                    };
                    logic.Update(territoryEntity);
                    return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine("ID inexistente");
            }

            return View();
        }
        public ActionResult Borrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Borrar(string id)
        {
            try
            {
                logic.Delete(id);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                
            }
            return View();
        }
    }
}