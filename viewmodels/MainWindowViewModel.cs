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
using System.Numerics;
using System.Collections.ObjectModel;

namespace mvvm_banking.viewmodels
{
    struct point
    {
        
    }

    internal class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<account> Accounts;
        

        public string _bank_account;

        public ICommand Dcr { get; }
        public bool CanExecute(object parameter) => (Accounts[0].bank_account > 100);


        public void Execute(object parameter)
        {
            point p = new point();
            Accounts[0].bank_account -= 100;
            parameter = bank_account;
            
            bank_account = Accounts[0].bank_account.ToString();
        }

        public MainWindowViewModel()
        {
            Accounts = new ObservableCollection<account>();
            Accounts.Add(new account());
            Dcr = new ActionCommand(Execute, CanExecute);
           
        }

        public string bank_account
        {
            get => Accounts[0].bank_account.ToString() + '₽';
            set => Set(ref _bank_account, value);
        }
    }
}
