using DesignPatterns.factory_method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.abstract_factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new ClientCode();
            client.execute();
        }
    }

    public class ClientCode
    {
        public void execute()
        {
            AbstractFurnitureFactory modernFactory = new ModernFurnitureFactory();
            AbstractFurnitureFactory victorianFactory = new VictorianFurnitureFactory();

            var modernShop = new FurnitureShop(modernFactory);
            var victorianShop = new FurnitureShop(victorianFactory);

            Console.WriteLine("Modern Furniture Collections:");
            modernShop.ShowFurnitureCollection();
            Console.WriteLine("\nVictorian Furniture Collections:");
            victorianShop.ShowFurnitureCollection();
        }

    }

    public class FurnitureShop
    {
        private AbstractFurnitureFactory _FurnitureFactory { get; set; }

        public FurnitureShop(AbstractFurnitureFactory furnitureFactory)
        {
            _FurnitureFactory = furnitureFactory;
        }

        public void ShowFurnitureCollection()
        {
            var chair = _FurnitureFactory.CreateChair();
            var sofa = _FurnitureFactory.CreateSofa();
            var coffeeTable = _FurnitureFactory.CreateCoffeeTable();
            Console.WriteLine(chair.GetDescription());
            Console.WriteLine(sofa.GetDescription());
            Console.WriteLine(coffeeTable.GetDescription());
        }
    }
}