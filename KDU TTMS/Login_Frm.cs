using Guna.UI2.WinForms;
using KDU_TTMS.Properties;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Login_Frm : Form
    {
        //Connection String 
        string connectionString = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;

        public Login_Frm()
        {
            InitializeComponent();
        }

        //@TODO
        //Create different user roles in the database

        private void Login_Frm_Load(object sender, EventArgs e)
        {

        }

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
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        string loginQuery = "SELECT email,password,usertype from login_info WHERE email = '" + emailTxt.Text.ToString() + "' AND password = '" + passwordTxt.Text.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(loginQuery, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.GetString(2) == "Student")
                                {
                                    MessageBox.Show("Hello");
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                } 
            }
        }
    }
}
