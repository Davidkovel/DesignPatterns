using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.abstract_factory
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }

    public abstract class AbstractFurnitureFactory : IFurnitureFactory
    {
        public abstract IChair CreateChair();

        public abstract ICoffeeTable CreateCoffeeTable();
        public abstract ISofa CreateSofa();
    }


    public class ModernFurnitureFactory : AbstractFurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new ModernChair();
        }

        public override ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public override ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }

    public class VictorianFurnitureFactory : AbstractFurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new VictorianChair();
        }

        public override ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable(); 
        }

        public override ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }



}
