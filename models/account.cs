using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_banking.models
{
    interface account
    {
        double Amount { get; set; }
        double Transaction { get; set; }

    }
}
