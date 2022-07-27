using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation {
    public partial class ESpace : IESpace {

        public string HelloWorld() {
            return "Hello World!";
        }

        public bool Is<T>() {
            return false;
        }
    }
}
