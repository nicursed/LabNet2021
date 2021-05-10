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

        public void Add(Territories territories)
        {
            try
            {
                context.Territories.Add(new Territories
                {
                    TerritoryID = territories.TerritoryID,
                    TerritoryDescription = territories.TerritoryDescription,
                    RegionID = territories.RegionID
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

        public void Update(Territories territories)
        {
            var update = context.Territories.Find(territories.TerritoryID);
            try
            {
                update.TerritoryDescription = territories.TerritoryDescription;
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
