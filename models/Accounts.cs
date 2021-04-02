using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_banking.models
{
    internal class Happy_mortgage : Default_account //ипотечный кредит
    {
        private double _amount;
        internal double Amount
        {
            get => _amount;
            set => Set(ref _amount, value);
        }
        
        internal override void Decrease(double p)
        {
            Amount -= p;
        }

        internal override void Increase(double p)
        {
            Amount += p;
        }    
    }
    internal class Cash_404 : Default_account //дебетовая карта
    {
        private double _amount;
        internal double Amount
        {
            get => _amount;
            set => Set(ref _amount, value);
        }

        internal override void Decrease(double p)
        {
            if (p > 10000)
            {
                Amount -= p * 1.005;
            }
        }

        internal override void Increase(double p)
        {
            Amount += p;
        }
    }

}
