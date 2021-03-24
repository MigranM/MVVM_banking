using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvm_banking.Commands.Base;
using mvvm_banking.models;
using mvvm_banking.viewmodels;

namespace mvvm_banking.Commands
{
    internal class Decrease_account : Command
    {
        public override bool CanExecute(object parameter) => (account.bank_account > 100);
        

        public override void Execute(object parameter)
        {
            account.bank_account -= 100;
            bank_account = account.bank_account.ToString();
        }
    }
}
