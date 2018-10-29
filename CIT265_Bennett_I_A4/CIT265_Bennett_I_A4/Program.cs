using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Bennett_I_A4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();

            p1.NameMe = "Steven";
            p2.NameMe = "Lars";
            p1.Match(p2);
            
        }
    }
}
