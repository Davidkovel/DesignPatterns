using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.factory_method
{
    public enum Difficulty
    {
        Easy,
        Normal,
        Hard
    }

    public abstract class Creator
    {
        public abstract Enemy FactoryMethod(Difficulty difficulty);
    
        public void AttackOperation(Difficulty difficulty)
        {
            var product = FactoryMethod(difficulty);
            product.Attack();
        }
    }

    public class ZombieFactory : Creator
    {
        public override Enemy FactoryMethod(Difficulty difficulty)
        {
            return difficulty switch
            {
                Difficulty.Easy => new Zombie(100, 5),
                Difficulty.Normal => new Zombie(100, 27),
                Difficulty.Hard => new Zombie(250, 70),
                _ => throw new Exception("[ERROR] 500 Server error. Incorrect level")
            };
        }
    }


    public class SkeletonFactory : Creator
    {
        public override Enemy FactoryMethod(Difficulty difficulty)
        {
            return difficulty switch
            {
                Difficulty.Easy => new Skeleton(90, 10),
                Difficulty.Normal => new Skeleton(140, 17),
                Difficulty.Hard => new Skeleton(160, 40),
                _ => throw new Exception("[ERROR] 500 Server error. Incorrect level")
            };
        }
    }
}
