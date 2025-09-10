using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part3
{
    public class sea
    {
         public string name { get; set; }
       public int height { get; set; }
       public int width { get; set; }

        public sea(string name, int height, int width)
        {
            this.name = name;
            this.height = height;
            this.width = width;
        }
    }
}
