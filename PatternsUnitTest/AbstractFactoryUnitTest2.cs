using DesignPatterns.abstract_factory;

namespace PatternsUnitTest
{
    [TestClass]
    public class AbstractFactoryUnitTest
    {
        [TestMethod]
        public void TestModernFurnitureFactory_CreatesModernChair()
        {
            AbstractFurnitureFactory factory = new ModernFurnitureFactory();

            IChair chair = factory.CreateChair();

            Assert.IsNotNull(chair);
            Assert.AreEqual("Modern Chair", chair.GetDescription());
        }

        [TestMethod]
        public void TestModernFurnitureFactory_CreatesModernSofa()
        {
            AbstractFurnitureFactory factory = new ModernFurnitureFactory();

            ISofa sofa = factory.CreateSofa();

            Assert.IsNotNull(sofa);
            Assert.AreEqual("Modern Sofa", sofa.GetDescription());
        }

        [TestMethod]
        public void TestModernFurnitureFactory_CreatesModernCoffeeTable()
        {
            AbstractFurnitureFactory factory = new ModernFurnitureFactory();

            ICoffeeTable coffeeTable = factory.CreateCoffeeTable();

            Assert.IsNotNull(coffeeTable);
            Assert.AreEqual("Modern Coffee Table", coffeeTable.GetDescription());
        }

        [TestMethod]
        public void TestVictorianFurnitureFactory_CreatesVictorianChair()
        {
            AbstractFurnitureFactory factory = new VictorianFurnitureFactory();

            IChair chair = factory.CreateChair();

            Assert.IsNotNull(chair);
            Assert.AreEqual("Victorian Chair", chair.GetDescription());
        }

        [TestMethod]
        public void TestVictorianFurnitureFactory_CreatesVictorianSofa()
        {
            AbstractFurnitureFactory factory = new VictorianFurnitureFactory();

            ISofa sofa = factory.CreateSofa();

            Assert.IsNotNull(sofa);
            Assert.AreEqual("Victorian Sofa", sofa.GetDescription());
        }

        [TestMethod]
        public void TestVictorianFurnitureFactory_CreatesVictorianCoffeeTable()
        {
            AbstractFurnitureFactory factory = new VictorianFurnitureFactory();

            ICoffeeTable coffeeTable = factory.CreateCoffeeTable();

            Assert.IsNotNull(coffeeTable);
            Assert.AreEqual("Victorian Coffee Table", coffeeTable.GetDescription());
        }
    }
}
