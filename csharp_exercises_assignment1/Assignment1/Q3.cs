using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    internal class Q3 {
        public String answers() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Managed resources are resources that the .NET garbage collector automatically manages and deallocates, such as objects created with the new keyword.\n");
            sb.Append("Examples include .NET objects like arrays, strings, and class instances.\n");
            sb.Append("Unmanaged resources are resources that the .NET garbage collector does not manage, such as file handles, network connections, and database connections.\n");
            sb.Append("These resources must be explicitly released, typically by implementing the IDisposable interface.");

            return sb.ToString();
        }
    }
}
