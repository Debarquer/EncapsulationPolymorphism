using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Animals
{
    internal class Horse : Animal
    {
        public double HorsePower => 15;
        public DateTime LastReshoe {  get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Neight");
        }
    }
}
