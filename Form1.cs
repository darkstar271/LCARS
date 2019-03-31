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
            //  Fx.SoundT2();
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
                        Fx.SoundT2();
                        myLogic.ShieldsUp = "Bow";
                        break;
                    case "btnStern":
                        Fx.SoundT1();
                        myLogic.ShieldsUp = "Stern";
                        break;
                }

                Text = myLogic.ShieldsUp;
            }


        }

        //private static void SoundT1()
        //{
        //    SoundPlayer snPlayer = new SoundPlayer(Resource1._002
        //    );

        //    snPlayer.Play();
        //}
    }
}
