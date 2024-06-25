using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    internal class Q4 {
        public String answers() {
            StringBuilder sb = new StringBuilder();
            sb.Append("The purpose of the Garbage Collector (GC) in .NET is to automatically manage memory allocation and deallocation for managed objects.\n");
            sb.Append("The GC keeps track of objects that are no longer in use and releases the memory they occupy, preventing memory leaks and improving performance.\n");

            return sb.ToString();
        }
    }
}
