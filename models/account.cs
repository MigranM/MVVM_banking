using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_banking.models
{
    internal static class account
    {
        private static double _bank_account=1520;

        public static double bank_account
        {
            get => _bank_account;
            set => _bank_account = value;
        }
    }
}
