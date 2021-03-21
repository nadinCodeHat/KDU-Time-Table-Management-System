using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Splash_Screen : Form
    {
        Thread th;
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int step = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (step)
            {
                case 0:
                    timer1.Interval = 2000;
                    break;
                case 1:
                    loading_txt.Text = "Initializing Modules...100%";
                    break;
                case 2:
                    loading_txt.Text = "Initializing UI...100%";
                    break;
                case 3:
                    loading_txt.Text = "Initializing Packages...100%";
                    break;
                case 4:
                    loading_txt.Text = "Loading...";
                    break;
                case 5:
                    this.Close();
                    th = new Thread(openLoginFrm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    break;
            }
            step++;
        }

        private void openLoginFrm(object obj)
        {
            Application.Run(new Login_Frm());
        }    
    }
}
