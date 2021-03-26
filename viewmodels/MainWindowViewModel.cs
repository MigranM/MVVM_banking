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
        internal string notification_ico => "M38.5 28.2427L36.5295 26.261C36.0432 25.7752 35.6575 25.1979 35.395 24.5625C35.1327 23.927 34.9982 23.2461 35 22.5585V15.75C35 12.037 33.5249 8.47602 30.8996 5.85051C28.274 3.22499 24.713 1.75 21 1.75C17.287 1.75 13.726 3.22499 11.1005 5.85051C8.47499 8.47602 7 12.037 7 15.75V22.5585C7.00165 23.2461 6.86737 23.9274 6.60489 24.5628C6.3424 25.1984 5.95688 25.7757 5.4705 26.2619L3.5 28.2427V35H14.0875C14.2912 36.69 15.1071 38.2469 16.3808 39.3762C17.6543 40.5057 19.2978 41.1292 21 41.1292C22.7022 41.1292 24.3456 40.5057 25.6193 39.3762C26.893 38.2469 27.7088 36.69 27.9125 35H38.5V28.2427ZM21 37.625C20.2242 37.6241 19.4708 37.366 18.8575 36.8909C18.2443 36.4159 17.8059 35.7509 17.6111 35H24.3889C24.1941 35.7509 23.7557 36.4159 23.1425 36.8909C22.5292 37.366 21.7758 37.6241 21 37.625ZM35 31.5H7V29.6872L7.95183 28.7304C8.7622 27.9202 9.40448 26.9579 9.84179 25.8988C10.2791 24.8397 10.5028 23.7045 10.5 22.5585V15.75C10.5 12.9652 11.6062 10.2945 13.5754 8.32538C15.5445 6.35625 18.2152 5.25 21 5.25C23.7848 5.25 26.4554 6.35625 28.4245 8.32538C30.3938 10.2945 31.5 12.9652 31.5 15.75V22.5585C31.497 23.7043 31.7207 24.8393 32.158 25.8983C32.5953 26.9572 33.2378 27.9191 34.0482 28.729L35 29.6867V31.5Z";


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
