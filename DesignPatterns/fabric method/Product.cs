using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.factory_method
{
    public interface IEnemy
    {
        int Health { get; set; }
        int Damage { get; set; }

        void Attack();
    }

    public abstract class Enemy : IEnemy
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public abstract void Attack();
    }

    class Zombie : Enemy
    {
        public Zombie(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }
        public override void Attack()
        {
            Console.WriteLine($"Zombie attacks with {Damage} damage!");
        }
    }

    class Skeleton : Enemy
    {
        public Skeleton(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public override void Attack()
        {
            Console.WriteLine($"Skeleton attacks with {Damage} damage!");
        }
    }
}
