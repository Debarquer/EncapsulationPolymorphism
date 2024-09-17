using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Errors;

internal class OutOfBoundsError : UserError
{
    public override string UEMessage()
    {
        return "Out of bounds error: The selected index was out of bounds.";
    }
}
