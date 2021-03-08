using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Add_Assistant : Form
    {
        //Connection String 
        string connectionString = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;

        public Add_Assistant()
        {
            InitializeComponent();
        }

        private void regNoTxt_TextChanged(object sender, EventArgs e)
        {
            isEmpty(regNoTxt, Color.FromArgb(125, 137, 149), Color.FromArgb(86, 69, 254));
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            isEmpty(nameTxt, Color.FromArgb(125, 137, 149), Color.FromArgb(86, 69, 254));
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            isEmpty(emailTxt, Color.FromArgb(125, 137, 149), Color.FromArgb(86, 69, 254));
        }

        private void mobileTxt_TextChanged(object sender, EventArgs e)
        {
            isEmpty(mobileTxt, Color.FromArgb(125, 137, 149), Color.FromArgb(86, 69, 254));
        }

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

        private void createMessage(string msg, Color bckGrndColor)
        {
            msgPanel.BackColor = bckGrndColor;
            msgPanel.Visible = true;
            msgLabel.Text = msg;
            timer1.Start();
        }

        //Add new Assistant
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty(regNoTxt, Color.Red, Color.FromArgb(86, 69, 254)) == true)
                createMessage("Incomplete Fields!", Color.Red);
            if (isEmpty(nameTxt, Color.Red, Color.FromArgb(86, 69, 254)) == true)
                createMessage("Incomplete Fields!", Color.Red);
            if (isEmpty(emailTxt, Color.Red, Color.FromArgb(86, 69, 254)) == true)
                createMessage("Incomplete Fields!", Color.Red);
            if (isEmpty(mobileTxt, Color.Red, Color.FromArgb(86, 69, 254)) == true)
                createMessage("Incomplete Fields!", Color.Red);
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string insertQuery = "INSERT INTO Assistant_Info(reg_no,name,email,mobile,admin_priviledge) values (@reg_no,@name,@email,@mobile,@admin_priviledge)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@reg_no", regNoTxt.Text.ToString());
                            cmd.Parameters.AddWithValue("@name", nameTxt.Text.ToString());
                            cmd.Parameters.AddWithValue("@email", emailTxt.Text.ToString());
                            cmd.Parameters.AddWithValue("@mobile", mobileTxt.Text.ToString());
                            if (enableAdminCheckBox.Checked == true)
                            {
                                cmd.Parameters.AddWithValue("@admin_priviledge", true);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@admin_priviledge", false);
                            }
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    string msg = "Insert Error:";
                    msg += ex.Message;
                }
                finally
                {
                    createMessage("Inserted Suceesfully!", Color.Green);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            msgPanel.Visible = false;
        }

        //lose control on MouseDown
        private void Add_Student_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
        }
    }
}
