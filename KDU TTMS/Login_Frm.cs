using Guna.UI2.WinForms;
using KDU_TTMS.Properties;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
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
        private Boolean isEmpty(Guna2TextBox txt, Color colorB, Color colorFS)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BorderColor = colorB;
                txt.FocusedState.BorderColor = colorFS;
                return true;
            }
            else
            {
                txt.BorderColor = Color.Green;
                txt.FocusedState.BorderColor = Color.Green;
                return false;
            }
        }

        //When emailTxt changes
        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            isEmpty(emailTxt, Color.FromArgb(125, 137, 149), Color.FromArgb(86, 69, 254));
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
        private void createMsg(String txt)
        {
            msgTxt.Text = txt;
            msgTxt.Visible = true;
        }

        //Login Button is Clicked
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty(emailTxt, Color.Red, Color.FromArgb(86, 69, 254)) == true)
                createMsg("Please enter your email!");
            if (isEmpty(passwordTxt, Color.Red, Color.FromArgb(86, 69, 254)) == true)
                createMsg("Please enter your password!");
            if (isEmpty(emailTxt, Color.Red, Color.FromArgb(86, 69, 254)) == true && isEmpty(passwordTxt, Color.Red, Color.FromArgb(86, 69, 254)) == true)
                createMsg("Please enter your email and password!");
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    try
                    {
                        bool IsExist = false;
                        byte[] password = new byte[64];
                        string countQuery = "SELECT * FROM Login_Info where email ='"+ emailTxt.Text.ToString() + "'";
                        using (SqlCommand cmd = new SqlCommand(countQuery, con))
                        {
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                if (sdr.Read())
                                {
                                    //Fetch password
                                    password = (byte[])sdr[2];
                                    IsExist = true;
                                }
                            }
                        }
                        //@TODO select * then get password then decrypt password and confirm then check user role
                        if (IsExist)
                        {
                            //Decrypt fetched password and check if equal
                            if (Cryptography.callDecrypt(password).Equals(passwordTxt.Text))
                            {
                                //MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Form1 frm1 = new Form1();
                                // frm1.ShowDialog();
                            }
                        }
                        else
                        {
                            msgTxt.Text = "Please enter the valid credentials";
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
