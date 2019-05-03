using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startrek
{
    public class Logic
    {// make 10 Properties to store variables

        public string ShieldsUp { get; set; }
        public int randomTwarp { get; set; }
        public int num { get; set; }

        public int fire { get; set; } = 6;
        // public int num = 0; // sets a variable to be used in the random number generator
        public int Sboost { get; set; } = 2;

        public int Sdeflect()
        {
            Random random = new Random();
            num = random.Next(1, 7);
            return num;
        }

        // Make a method with a  switch to check if (num and Fakelcars) are the same.
        public void EndCheck(string end)
        {
            switch (num)
            {
                case :
                    1

            }


        }




        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties




        public int TranWarp()
        {
            Random Trandom = new Random();
            randomTwarp = Trandom.Next(0, 11);
            return randomTwarp;

        }

    }
}
