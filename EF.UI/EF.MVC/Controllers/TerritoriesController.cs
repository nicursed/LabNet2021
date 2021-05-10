using EF.Logic;
using EF.Entities;
using EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        TerritoriesLogic logic = new TerritoriesLogic();

        // GET: Territories
        public ActionResult Index()
        {
            var logic = new TerritoriesLogic();

            List<EF.Entities.Territories> territories = logic.GetAll();

            List<TerritoriesView> territoriesViews = territories.Select(s => new TerritoriesView
            {
                Id = s.TerritoryID,
                Descripcion = s.TerritoryDescription,
                RegionId = s.RegionID

            }).ToList();

            return View(territoriesViews);
        }

        public ActionResult Insert()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Insert(TerritoriesView territoriesView)
        {
            try
            {
                var territoryEntity = new Territories { TerritoryDescription = territoriesView.Descripcion, TerritoryID = territoriesView.Id, RegionID = territoriesView.RegionId};

                logic.Add(territoryEntity);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(TerritoriesView territoriesView) 
        {
            try
            {
                var territoryEntity = new Territories
                {
                    TerritoryID = territoriesView.Id,
                    TerritoryDescription = territoriesView.Descripcion
                };

                logic.Update(territoryEntity);

                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try 
            {
               logic.Delete(id);

               return RedirectToAction("Index");
            }
            catch (Exception)
            {
               return RedirectToAction("Index", "Error");
            }
        }

    }
}