using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation {
    public partial class ESpace : IOMLComponent {
        bool IOMLComponent.Is<T>() {
            if (typeof(T) == typeof(IOMLComponent)) {
                return true;
            }
            return false;
        }

    }
}
