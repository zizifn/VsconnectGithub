using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows8SelectPhone.Libary
{
    public class Phone:INotifyPropertyChanged
    {
        public string PhoneNumber { set; get; }
        public string PhoneLocation { set; get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
