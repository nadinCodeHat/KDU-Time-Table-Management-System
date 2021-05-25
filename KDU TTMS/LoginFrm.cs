using Guna.UI2.WinForms;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class LoginFrm : Form
    {
        //Connection String 
        string connectionString = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void NewLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
        }

        //@TODO
        //Create different user roles in the database


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
            isEmpty(emailTxt, Color.FromArgb(108, 114, 147), Color.FromArgb(81, 78, 221));
            if (msgTxt.Visible == true)
                msgTxt.Visible = false;
        }

        //When passwordTxt changes
        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            isEmpty(passwordTxt, Color.FromArgb(108, 114, 147), Color.FromArgb(81, 78, 221));
            if (msgTxt.Visible == true)
                msgTxt.Visible = false;
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
            if (isEmpty(emailTxt, Color.Red, Color.FromArgb(81, 78, 221)) == true)
                createMsg("Please enter your email!");
            if (isEmpty(passwordTxt, Color.Red, Color.FromArgb(81, 78, 221)) == true)
                createMsg("Please enter your password!");
            if (isEmpty(emailTxt, Color.Red, Color.FromArgb(81, 78, 221)) == true && isEmpty(passwordTxt, Color.Red, Color.FromArgb(81, 78, 221)) == true)
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
                        string countQuery = "SELECT * FROM Login_Info where email ='" + emailTxt.Text.ToString() + "'";
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
                            msgTxt.Text = "The email or password is incorrect.";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void contactHereLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "123";
            string user_id = "D/BCE/19/0002";
            string email = "123@";
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "INSERT INTO Login_Info (user_id, email, password) values (@user_id, @email, @password)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters["@user_id"].Value = user_id; //check this
            cmd.Parameters["@email"].Value = email;
            cmd.Parameters["@password"].Value = Cryptography.callEncrypt(pass);
            cmd.ExecuteNonQuery();
        }
    }
}
