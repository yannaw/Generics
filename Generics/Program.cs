using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Utils.Clamp(1,2,3));
            var pair = new Pair(4,8);

        }
    }
}
