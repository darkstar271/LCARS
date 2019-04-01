using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
namespace startrek
{
    static class Fx
    {

        public static void SoundT1()
        {
            SoundPlayer snPlayer = new SoundPlayer(Resource1._002
            );

            snPlayer.Play();
        }

        public static void SoundT2()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._330);
            sn2Player.Play();


        }

        public static void SoundT3()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._020);
            sn2Player.Play();


        }
        public static void SoundT4()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._072);
            sn2Player.Play();


        }
        public static void SoundT5()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._097);
            sn2Player.Play();


        }
        public static void SoundT6()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._099);
            sn2Player.Play();


        }
        public static void SoundT7()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1.Red_Alert);
            sn2Player.Play();


        }
    }
}
