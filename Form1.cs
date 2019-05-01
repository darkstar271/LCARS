using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using startrek.Properties;

// LCARS font added to winform, this is the font used on Startrek movies and tv shows, it's the computer interface (Library Computer Access/Retrieval System)
namespace startrek
{

    public partial class Form1 : Form

    {
        Logic myLogic = new Logic();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse



        );
        public Form1()
        {




            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            // this set's the media player to not show controls, it has to be set here as a defult.
            axWindowsMediaPlayer1.uiMode = "none";
            //- Fx.SoundT7();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Button fakeLcars = (Button)sender;

            //if (fakeLcars.Click)
            //{
            //ShieldsUpText = 
            ShieldsUp(fakeLcars.Name);
            //}


            // Fx.SoundT1();
        }

        public void ShieldsUp(string shieldsDir)
        {

            {
                switch (shieldsDir)
                {
                    case "btnBow":
                        //Fx.SoundT2();
                        // this just tests the random gen in Logic.cs and prints the value to screen
                        myLogic.Sdeflect(); // random method
                        MessageBox.Show(myLogic.num.ToString()); // print to screen the random value
                        myLogic.ShieldsUp = "Bow";
                        break;
                    case "btnStern":
                        Fx.SoundT1();
                        myLogic.ShieldsUp = "Stern";
                        break;
                    case "btnPort":
                        Fx.SoundT3();
                        myLogic.ShieldsUp = "Port";
                        break;
                    case "btnStarboard":
                        Fx.SoundT4();
                        myLogic.ShieldsUp = "Starboard";
                        break;
                    case "btnTop":
                        Fx.SoundT5();
                        myLogic.ShieldsUp = "Top";
                        break;
                    case "btnBottom":
                        Fx.SoundT6();
                        myLogic.ShieldsUp = "Bottom";
                        break;
                    case "btnShields":
                        Fx.SoundT7();
                        myLogic.ShieldsUp = "Shields";
                        break;
                    case "":
                        Fx.SoundT1();
                        myLogic.ShieldsUp = "";
                        break;



















                }



















                Text = myLogic.ShieldsUp;
            }


        }

        public void BntAlert_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.URL = @"G:\Doubleback.mp4";

            // axWindowsMediaPlayer1.URL = @"c:\mediafile.wmv";
            // G:\Visual Studio 2019 Files\startrek\Resources
            //BtnVisBol();
            //Fx.SoundT6();
        }

        private void BtnVisBol()
        {
            bntAlert.Visible = false;
        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        //private static void SoundT1()
        //{
        //    SoundPlayer snPlayer = new SoundPlayer(Resource1._002
        //    );

        //    snPlayer.Play();
        //}
    }
}
