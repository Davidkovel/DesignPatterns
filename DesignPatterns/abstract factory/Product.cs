using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.abstract_factory
{
    // interfaces
    public interface IChair
    {
        string GetDescription();
    }

    public interface ISofa
    {
        string GetDescription();
    }

    public interface ICoffeeTable
    {
        string GetDescription();
    }

    // abstract from interfaces, Main Product
    public abstract class Chair : IChair
    {
        public abstract string GetDescription();
    }

    public abstract class Sofa : ISofa
    {
        public abstract string GetDescription();
    }

    public abstract class CoffeeTable : ICoffeeTable
    {
        public abstract string GetDescription();
    }

    // Concrete from Product
    public class ModernChair : Chair
    {
        public override string GetDescription()
        {
            return "Modern Chair";
        }
    }

    public class ModernSofa : Sofa
    {
        public override string GetDescription() 
        {

            return "Modern Sofa";
        }
    }

    public class ModernCoffeeTable : CoffeeTable
    {
        public override string GetDescription() 
        {
            return "Modern Coffee Table";
        }
    }

    public class VictorianChair : Chair
    {
        public override string GetDescription() 
        {
            return "Victorian Chair";
        }
    }


    public class VictorianSofa : Sofa
    {
        public override string GetDescription() 
        {
            return "Victorian Sofa";
        }
    }

    public class VictorianCoffeeTable : CoffeeTable
    {
        public override string GetDescription() 
        {
            return "Victorian Coffee Table";
        }
    }
}
