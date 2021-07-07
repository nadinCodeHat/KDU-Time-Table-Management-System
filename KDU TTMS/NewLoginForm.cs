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
            if (string.IsNullOrEmpty(emailTxt.Text))
            {
                return 2;
            }
            if(string.IsNullOrEmpty(passwrdTxt.Text))
            {
                return 3;
            }        
            else
            {
                return 0;
            }
        }
        
        private Label errorMsg = new Label();
        private void createErroMsg(string showMsg)
        {
            errorMsg.Text = showMsg;
            errorMsg.ForeColor = Color.Red;
            errorMsg.AutoSize = true;
            errorMsg.TextAlign = ContentAlignment.MiddleCenter;
            int y = (this.Height / 2) - (errorMsg.Height / 2);
            int x = (this.Width / 2) - (errorMsg.Width / 2);
            errorMsg.Location = new Point(x, 337);
            
            //errorMsg.Dock = DockStyle.Fill;
            this.Controls.Add(errorMsg);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            int returnVal = isEmpty(emailTxt, passwrdTxt);
            if (returnVal == 1)
                createErroMsg("Please enter your Email / Password.");
            if (returnVal == 2)
                createErroMsg("Email field is empty!");
            if(returnVal == 3)
                createErroMsg("Password field is empty!");

            else
            {

            }
        }
    }
}
