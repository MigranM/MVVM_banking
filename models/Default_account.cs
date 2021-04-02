using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_banking.models
{
    abstract class Default_account: INotifyPropertyChanged
    {
        double Amount { get; set; }

        abstract internal void Decrease(double p);

        abstract internal void Increase(double p);

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

    }
}
