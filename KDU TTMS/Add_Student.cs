using Guna.UI2.WinForms;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Add_Student : Form
    {
        //Connection String 
        string connectionString = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;

        public Add_Student()
        {
            InitializeComponent();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
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

        //Add new Student
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
                string degreeProgramme = degProgCombo.SelectedItem.ToString();
                string intake = intakeCombo.SelectedItem.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        int degProgID;
                        int intakeID;
                        con.Open();
                        string selectdegProgQuery = "SELECT id FROM degree_programme_info where degree_programme = '" + degreeProgramme + "'";
                        using (SqlCommand cmd = new SqlCommand(selectdegProgQuery, con))
                        {
                            degProgID = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string selectIntakeQuery = "SELECT id FROM Intakes where intake = '" + intake + "'";
                        using (SqlCommand cmd = new SqlCommand(selectIntakeQuery, con))
                        {
                            intakeID = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        //Insert student info
                        string insertQuery = "INSERT INTO Student_info(reg_no,name,email,mobile,degree_programme_id,d_or_c,intake_id) VALUES (@reg_no,@name,@email,@mobile,@degree_programme_id,@d_or_c,@intake_id)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@reg_no", regNoTxt.Text.ToString());
                            cmd.Parameters.AddWithValue("@name", nameTxt.Text.ToString());
                            cmd.Parameters.AddWithValue("@email", emailTxt.Text.ToString());
                            cmd.Parameters.AddWithValue("@mobile", mobileTxt.Text.ToString());
                            cmd.Parameters.AddWithValue("@degree_programme_id", degProgID);
                            string dayScholarOrCadet;
                            if (dayScholarRadioButton.Checked == true)
                            {
                                dayScholarOrCadet = "Day Scholar";
                            }
                            else
                            {
                                dayScholarOrCadet = "Cadet";
                            }
                            cmd.Parameters.AddWithValue("@d_or_c", dayScholarOrCadet);
                            cmd.Parameters.AddWithValue("@intake_id", intakeID);
                            cmd.ExecuteNonQuery();
                        }
                        //Insert student login info
                        string insertLoginQuery = "INSERT INTO Login_Info(email, password) VALUES (@email,@password)";
                        using (SqlCommand cmd = new SqlCommand(insertLoginQuery, con))
                        {
                            //Generate a random 8 characters password and encrypt
                            //@Todo send email with login_info
                            byte[] password = Cryptography.callEncrypt(Cryptography.generateRandom());
                            cmd.Parameters.AddWithValue("@email", emailTxt.Text.ToString());
                            cmd.Parameters.AddWithValue("@password", password);
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
                    createMessage("Inserted Sucessfully!", Color.Green);
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
