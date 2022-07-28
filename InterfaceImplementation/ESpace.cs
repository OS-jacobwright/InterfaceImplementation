using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation {
    public partial class ESpace : IESpace, INeoApp, INeoLibrary {

        private readonly ESpaceKind kind;

        private ESpace(ESpaceKind kind) => this.kind = kind;

        private static Dictionary<Type, ESpaceKind> typeToKind = new Dictionary<Type, ESpaceKind>() {
            {  typeof(IESpace), ESpaceKind.O11 },
            {  typeof(INeoApp), ESpaceKind.NeoApp },
            {  typeof(INeoLibrary), ESpaceKind.NeoLibrary },
        };

        public static T Create<T>() where T : IOMLComponent => (T)(object)new ESpace(typeToKind[typeof(T)]);

        public string HelloWorld() {
            return "Hello World!";
        }

        public bool Is<T>() => kind switch {
            ESpaceKind.O11 => typeof(IESpace).IsAssignableFrom(typeof(T)),
            ESpaceKind.NeoApp => typeof(INeoApp).IsAssignableFrom(typeof(T)),
            ESpaceKind.NeoLibrary => typeof(INeoLibrary).IsAssignableFrom(typeof(T)),
            _ => throw new InvalidOperationException($"Missing case for kind {kind}")
        };
    }
}
