using DesignPatterns.factory_method;

namespace PatternsUnitTest
{
    [TestClass]
    public class FabricMethodUnitTest
    {
        [TestMethod]
        public void TestZombieFactory_EasyDifficulty()
        {
            var zombieFactory = new ZombieFactory();

            var zombie = zombieFactory.FactoryMethod(Difficulty.Easy);

            Assert.AreEqual(100, zombie.Health);
            Assert.AreEqual(5, zombie.Damage);
        }
    }
}