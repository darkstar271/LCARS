using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startrek
{
    class Logic
    {
        public int num = 0; // sets a variable to be used in the random number generator

        public void Sdeflect()
        {
            Random random = new Random();
            num = random.Next(1, 7);
        }






        public static void TranWarp()
        {
            Random Trandom = new Random();
            int randomTwarp = Trandom.Next(0, 11);

        }
        public string ShieldsUp { get; set; }
    }
}
