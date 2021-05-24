using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class GetCode : Form
    {
        //Connection String 
        string connectionString = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;

        public GetCode()
        {
            InitializeComponent();
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
            isEmpty(emailTxt, Color.FromArgb(108, 114, 147), Color.FromArgb(81, 78, 221));
            if (msgTxt.Visible == true)
                msgTxt.Visible = false;
        }

        //Create message
        private void createMsg(String txt)
        {
            msgTxt.Text = txt;
            msgTxt.Visible = true;
        }

        //GetCode Button is Clicked
        private void getCodeBtn_Click(object sender, EventArgs e)
        {
            //if (isEmpty(emailTxt, Color.Red, Color.FromArgb(81, 78, 221)) == true)
            //    createMsg("Please enter your email!");
            //else
            //{
            //    using (SqlConnection con = new SqlConnection(connectionString))
            //    {
            //        con.Open();
            //        try
            //        {
            //            bool IsExist = false;
            //            byte[] password = new byte[64];
            //            string countQuery = "SELECT * FROM Login_Info where email ='" + emailTxt.Text.ToString() + "'";
            //            using (SqlCommand cmd = new SqlCommand(countQuery, con))
            //            {
            //                using (SqlDataReader sdr = cmd.ExecuteReader())
            //                {
            //                    if (sdr.Read())
            //                    {
            //                        //Fetch password
            //                        password = (byte[])sdr[2];
            //                        IsExist = true;
            //                    }
            //                }
            //            }
            //            //@TODO select * then get password then decrypt password and confirm then check user role
            //            if (IsExist)
            //            {
                           
            //            }
            //            else
            //            {
            //                msgTxt.Text = "The email you entered does not exist in the records.";
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.ToString());
            //        }
            //    }
            //}
        }
    }
}
