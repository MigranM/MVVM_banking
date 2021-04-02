using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_banking.models
{
    internal class person : INotifyPropertyChanged
    {

        int _id;
        string _name, _surname, _patronymic;
        private double _bank_account = 1520;

        public string Name 
        { 
            get => _name; 
            set => Set(ref _name, value); 
        }

        public string Surname
        {
            get => _surname;
            set => Set(ref _surname, value);
        }

        public string Patronymic
        {
            get => _patronymic;
            set => Set(ref _patronymic, value);
        }
        
        public double Bank_account
        {
            get => _bank_account;
            set => Set(ref _bank_account, value);
        }





        #region INotifyPropertyChanged_realization
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChandes([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChandes(PropertyName);
            return true;
        }
        #endregion
    }
}
