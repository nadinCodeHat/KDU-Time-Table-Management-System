using Guna.UI2.WinForms;
using KDU_TTMS.Properties;
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
       
        // Create message
        public void createMsg(String passTxt,Color passColor)
        {
            msgTxt.Text = passTxt;
            msgTxt.ForeColor = passColor;
        }

        // Detect casplock
        private void Login_Frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                msgTxt.Visible = true;
                createMsg("Capslock is turned ON!", Color.Yellow);
            }
            else
            {
                msgTxt.Visible = false;
            }
        }

        // Password hide/reveal
        private bool isPassHidden = false;
        private void passwordTxt_IconRightClick(object sender, EventArgs e)
        {
            if (isPassHidden == false)
            {
                passwordTxt.IconRight = Resources.toggle_off_30px;
                isPassHidden = true;
            }
            else
            {
                passwordTxt.IconRight = Resources.toggle_on_30px;
                isPassHidden = false;
            }
            passwordTxt.PasswordChar = isPassHidden ? '\0' : '●';
        }

        // Leaving email
        private void emailTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTxt.Text))
            {
                emailTxt.BorderColor = Color.Red;
            }
            else
            {
                emailTxt.BorderColor = Color.MediumSeaGreen;
            }
        }

        private void emailTxt_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTxt.Text))
            {
                emailTxt.BorderColor = Color.Red;
            }
            else
            {
                emailTxt.BorderColor = Color.MediumSeaGreen;
            }
        }
    }
}
