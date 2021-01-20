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

        // TODO
        // if fields are empty turn border to red and show error provider

        // Create message
        public void createMsg(String passTxt,Color passColor)
        {
            msgTxt.Text = passTxt;
            msgTxt.ForeColor = passColor;
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

        // Check field empty
        public void isEmpty(Guna2TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BorderColor = Color.FromArgb(213, 218, 223);
                txt.FocusedState.BorderColor = Color.FromArgb(55, 81, 228);
            }
            else
            {
                txt.BorderColor = Color.MediumSeaGreen;
                txt.FocusedState.BorderColor = Color.MediumSeaGreen;
            }            
        }

        // When emailTxt changes
        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            isEmpty(emailTxt);
        }

        // When passwordTxt changes
        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            isEmpty(passwordTxt);
        }

        // Lose control when clicked outside the fields
        private void picture_bgrnd_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
        }

       
    }
}
