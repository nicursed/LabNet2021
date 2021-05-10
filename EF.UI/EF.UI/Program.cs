using EF.Entities;
using EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.UI
{
    class Program
    {
        static TerritoriesLogic territoriesLogic = new TerritoriesLogic();
        int code;
        string territoryId;
        string territoryDescription;
        int regionId;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ShowMenu();
            program.code = int.Parse(Console.ReadLine());  
        }
        void ShowMenu()
        {
            Console.WriteLine("0 - Para mostrar tabla.");
            Console.WriteLine("1 - Para agregar a la tabla.");
            Console.WriteLine("2 - Para actualizar un item.");
            Console.WriteLine("3 - Para borrar un item.");
            Console.WriteLine("4 - Para salir.");
            selectMethod(int.Parse(Console.ReadLine()));
        }
        void selectMethod(int code)
        {
            switch (code)
            {
                case 0:
                    territoriesLogic.ShowAll();
                    ShowMenu();
                    break;
                case 1:
                    Console.WriteLine("Inserte el TerritoryId");
                    territoryId = Console.ReadLine();
                    Console.WriteLine("Inserte el TerritoryDescription");
                    territoryDescription = Console.ReadLine();
                    Console.WriteLine("Inserte el RegionId");
                    regionId = int.Parse(Console.ReadLine());
                    territoriesLogic.Add(new Territories { TerritoryDescription = territoryDescription, RegionID = regionId, TerritoryID = territoryId });
                    ShowMenu();
                    break;
                case 2:
                    Console.WriteLine("Inserte TerritoryId existente");
                    territoryId = Console.ReadLine();
                    Console.WriteLine("Inserte el TerritoryDescription a modificar");
                    territoryDescription = Console.ReadLine();
                    territoriesLogic.Update(new Territories { TerritoryDescription = territoryDescription, TerritoryID = territoryId });
                    ShowMenu();
                    break;
                case 3:
                    Console.WriteLine("Inserte TerritoryId a borrar");
                    territoryId = Console.ReadLine();
                    territoriesLogic.Delete(territoryId);
                    ShowMenu();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Numero invalido");
                    ShowMenu();
                    break;
            }
        }
    }
}
