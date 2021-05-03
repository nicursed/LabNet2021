using EF.Data;
using EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF.Logic
{
    public class TerritoriesLogic : BaseLogic
    {
        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }

        public void Add(string id, string description, int regionId)
        {
            try
            {
                context.Territories.Add(new Territories
                {
                    TerritoryID = id,
                    TerritoryDescription = description,
                    RegionID = regionId
                });
                context.SaveChanges();
                ShowAll();
            }catch(Exception e)
            {
                Console.WriteLine("ID existente");
            }
           
        }

        public void Delete(string id)
        {
            var territorioAEliminar = context.Territories.Find(id);
            try
            {
                context.Territories.Remove(territorioAEliminar);
                context.SaveChanges();
                ShowAll();
            } catch(Exception e)
            {
                Console.WriteLine("ID inexistente");
            }


        }

        public void Update(string id, string description)
        {
            var update = context.Territories.Find(id);
            try
            {
                update.TerritoryDescription = description;
                context.SaveChanges();
                ShowAll();
            }
            catch(Exception e)
            {
                Console.WriteLine("ID inexistente");
            }
        }

        public void ShowAll()
        {
            foreach (var item in GetAll())
            {
                Console.WriteLine($"{item.TerritoryID} - {item.TerritoryDescription} - {item.RegionID}");
            }
        }
    }
}
