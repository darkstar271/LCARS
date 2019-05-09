using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace startrek
{
    public class Logic
    {// make 10 Properties to store variables
        public int butnum { get; set; }
        public string ShieldsUp { get; set; }
        public int randomTwarp { get; set; }
        public int num { get; set; }
        public int btnTag { get; set; }
        public int fire { get; set; } = 6;
        // public int num = 0; // sets a variable to be used in the random number generator
        public int Sboost { get; set; } = 2;

        public int Sdeflect()
        {
            Random random = new Random();
            num = random.Next(1, 7);
            return num;
        }






        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties




        public int TranWarp()
        {
            Random Trandom = new Random();
            randomTwarp = Trandom.Next(0, 11);
            return randomTwarp;

        }

        public void WinLose()
        {

            if (butnum == num)
            {
                Fx.SoundT7();
                //return;
            }


        }
        //public int Test()
        //{

        //    if (mySaw.Block == 0 || (mySaw.Block == 0 && mySaw.UserSpins > 0))
        //    {
        //        SoundPlayer snPlayer = new SoundPlayer(Resources.blood_2);
        //        snPlayer.Play();
        //        MessageBox.Show("you're dead");
        //        ButtonOff();
        //        return;
        //    }

        //    if (mySaw.UserSpins == mySaw.Rnd)

        //    {

        //        SoundPlayer snPlayer = new SoundPlayer(Resources.Gun_Shot2);
        //        snPlayer.Play();
        //        MessageBox.Show("your dead cat");
        //        ButtonOff();
        //        return;
        //    }



        //}






    }
}
