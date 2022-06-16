using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System_unit su = new System_unit(true);
            Skreen s = new Skreen(true);
            Keyboard k = new Keyboard(true);
            Mouse m = new Mouse(true);

            PC pc = new PC(s, k, m, su);
            pc.Turn_on();
            pc.Turn_off();

            System_unit su1 = new System_unit(true);
            Skreen s1 = new Skreen(true);
            Keyboard k1 = new Keyboard(true);
            Mouse m1 = new Mouse(false);

            PC pc1 = new PC(s1, k1, m1, su1);
            pc1.Turn_on();
            pc1.Turn_off();

            Console.Read();
        }
    }
}
