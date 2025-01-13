using DesignPatterns.factory_method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.fabric_method
{
    internal class Program
    {
        static void Main(string[] args) { 
            var client = new ClientCode(); 
            client.execute(); 
        }
    }

    public class ClientCode
    {
        public void execute()
        {
            var zombie = new ZombieFactory();
            Console.WriteLine("[DEBUG] Zombie created");
            ClientMethod(zombie);

            var skeleton = new SkeletonFactory();
            Console.WriteLine("[DEBUG] Skeleton created");
            ClientMethod(skeleton);
        }

        public void ClientMethod(Creator creator)
        {
            creator.AttackOperation(Difficulty.Normal);
            Console.WriteLine("Success");
        }
    }
}
