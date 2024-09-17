using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Errors;

internal class InvalidIntegerError : UserError
{
    public override string UEMessage()
    {
        return "Invalid integer error: The selected integer was invalid.";
    }
}
