using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation {
    public partial class ESpace : INeoApp {
        bool INeoApp.Is<T>() {
            if (typeof(T) == typeof(INeoApp)) {
                return true;
            }
            return false;
        }
    }
}
