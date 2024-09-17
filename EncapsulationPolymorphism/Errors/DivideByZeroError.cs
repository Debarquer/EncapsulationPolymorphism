using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Errors;

internal class DivideByZeroError : UserError
{
    public override string UEMessage()
    {
        return "Divide by zero error: You attempted to divide by zero.";
    }
}
