using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class NewLoginForm : Form
    {
        //Connection String 
        string connectionString = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;
        
        public NewLoginForm()
        {
            InitializeComponent();
        }

        //tell users if capslock is on
        //let users see their password


        //Check whether fields are empty
        private int isEmpty(TextBox emailTxt, TextBox passTxt)
        {
            if (string.IsNullOrEmpty(emailTxt.Text) && string.IsNullOrEmpty(passwrdTxt.Text))
            {
                return 1;
            }
            else if (string.IsNullOrEmpty(emailTxt.Text))
            {
                return 2;
            }
            else if(string.IsNullOrEmpty(passwrdTxt.Text))
            {
                return 3;
            }        
            else
            {
                return 0;
            }
        }

        private void createErroMsgEmail(string showMsg, int x, int y)
        {

            errorMsg.Text = showMsg;
            errorMsg.ForeColor = Color.Red;
            errorMsg.AutoSize = true;
            errorMsg.Location = new Point(x, y);
            this.Controls.Add(errorMsg);
        }
        private void 
        
        private string errorMsgEmail = "The email field is required.";
        private string errorMsgPassword = "The password field is required.";

        private void loginBtn_Click(object sender, EventArgs e)
        {
            int returnVal = isEmpty(emailTxt, passwrdTxt);
            if (returnVal == 1)
                createErroMsg(errorMsgEmail);
                createErroMsg(errorMsgPassword);
            if(returnVal == 2)
                createErroMsg(errorMsgEmail);
            if (returnVal == 3)
                createErroMsg(errorMsgPassword);
            else
            {
                //this.Controls.Remove(errorMsg);
            }
        }
    }
}
