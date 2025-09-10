using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using part3;
namespace part1
{
   public class Program
    {
        static void Main(string[] args)
        {

            sea[] s = new sea[3];
            s[1] = new sea("fish", 5, 3);
            s[2] = new sea("dolphin", 345, 765);
            s[3] = new sea("shark", 200, 443);

           

            var s2 = from item in s
                     where item.width>100
                     select item;


        }

    }
}
