using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using mvvm_banking.viewmodels.Base;
using mvvm_banking.models;
using mvvm_banking.Commands;
using System.Windows.Input;
using System.Windows;

namespace mvvm_banking.viewmodels
{
    internal class MainWindowViewModel : BaseViewModel
    {

        public string _bank_account;

        public ICommand Dcr { get; }
        public bool CanExecute(object parameter) => (account.bank_account > 100);


        public void Execute(object parameter)
        {
            account.bank_account -= 100;
            
            bank_account = account.bank_account.ToString();
        }

        public MainWindowViewModel()
        {
            Dcr = new ActionCommand(Execute,CanExecute); 
        }

        public string bank_account
        {
            get => account.bank_account.ToString() + '₽';
            set => Set(ref _bank_account, value);
        }
    }
}
