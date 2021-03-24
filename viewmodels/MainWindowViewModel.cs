using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvm_banking.viewmodels.Base;
using mvvm_banking.Commands;
using System.Windows.Input;

namespace mvvm_banking.viewmodels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private string _bank_account = "10";

        public ICommand Decrease_account { get; }

        private bool CanDecrease_account(object p)
        {
            return true;
        }

        private void OnDecrease_account(object p)
        {

        }

        public string bank_account
        {
            get => _bank_account + '₽';
            set => Set(ref _bank_account, value);
        }
    }
}
