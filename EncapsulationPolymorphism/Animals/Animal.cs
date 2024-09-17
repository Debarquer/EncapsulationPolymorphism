using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Animals
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Age { get; set; }

        public Animal()
        {

        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name:{Name};Weight:{Weight};Age:{Age};";
        }
    }
}
