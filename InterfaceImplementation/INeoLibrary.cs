﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation {
    public interface INeoLibrary : IOMLComponent {
        new bool Is<T>();
    }
}