using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Login_Frm : Form
    {
        public Login_Frm()
        {
            InitializeComponent();
        }
    

        // TODO when user clicks on the txt and types turn border green and right corner show a tick image 
        // do the above for password txt as well.
        // if fields are empty turn border to red and show error provider
        // Caps on/off
        // show/hide password

        public void createMsg(String passTxt,Color passColor)
        {
            msgTxt.Text = passTxt;
            msgTxt.ForeColor = passColor;
        }

    }
}
