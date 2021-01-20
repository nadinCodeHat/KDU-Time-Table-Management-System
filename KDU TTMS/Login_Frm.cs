using Guna.UI2.WinForms;
using KDU_TTMS.Properties;
using System;
using System.Drawing;
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


        //Password hide/reveal
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

        //Check whether fields are empty
        public Boolean isEmpty(Guna2TextBox txt, Color colorB, Color colorFS)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BorderColor = colorB;
                txt.FocusedState.BorderColor = colorFS;
                return true;
            }
            else
            {
                txt.BorderColor = Color.MediumSeaGreen;
                txt.FocusedState.BorderColor = Color.MediumSeaGreen;
                return false;
            }
        }

        //When emailTxt changes
        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            isEmpty(emailTxt, Color.FromArgb(125, 137, 149), Color.FromArgb(55, 81, 228));
            if (msgTxt.Visible == true)
                msgTxt.Visible = false;
        }

        //When passwordTxt changes
        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            isEmpty(passwordTxt, Color.FromArgb(125, 137, 149), Color.FromArgb(55, 81, 228));
            if (msgTxt.Visible == true)
                msgTxt.Visible = false;
        }

        //Lose control when clicked outside the fields
        private void picture_bgrnd_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
        }

        //Create message
        public void createMsg(String txt)
        {
            msgTxt.Text = txt;
            msgTxt.Visible = true;
        }

        //Login Button is Clicked
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty(emailTxt, Color.Red, Color.FromArgb(55, 81, 228)) == true)
                createMsg("Please enter your email!");
            if (isEmpty(passwordTxt, Color.Red, Color.FromArgb(55, 81, 228)) == true)
                createMsg("Please enter your password!");
            else
            {
                //  SqlConnection con = new SqlConnection(Conn);
                string loginQuery = "SELECT email,password from login WHERE email = '" + emailTxt.Text + "' and password ='" + passwordTxt.Text;

            }
        }
    }
}
