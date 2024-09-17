using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Animals
{
    internal class Wolf : Animal
    {
        public string PackName { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Howl");
        }

        public override string Stats()
        {
            return base.Stats() + $"PackName:{PackName};";
        }
    }
}
