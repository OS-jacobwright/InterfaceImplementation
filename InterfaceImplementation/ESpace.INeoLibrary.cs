using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation {
    public partial class ESpace : INeoLibrary {
        bool INeoLibrary.Is<T>() {
            if (typeof(T) == typeof(INeoLibrary)) {
                return true;
            }
            return false;
        }
    }
}
