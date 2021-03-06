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
                txt.BorderColor = Color.MediumSeaGreen;
                txt.FocusedState.BorderColor = Color.MediumSeaGreen;
                return false;
            }
        }

        private void createMessage(string msg, Color bckGrndColor)
        {
            Panel pnl = new Panel();
            pnl.Dock = DockStyle.Bottom;
            pnl.Size = new Size(374, 30);
            pnl.BackColor = bckGrndColor;

            Label msgLb= new Label();
            msgLb.Text = msg;
            msgLb.Font = new Font("Segoe UI", 9);
            msgLb.ForeColor = Color.White;
            msgLb.Anchor = AnchorStyles.Left;
            msgLb.Anchor = AnchorStyles.Right;
            msgLb.AutoSize = false;
            msgLb.TextAlign = ContentAlignment.MiddleCenter;

            int x = (pnl.Size.Width - msgLb.Size.Width) / 2;
            msgLb.Location = new Point(x, msgLb.Location.Y);

            Controls.Add(pnl);
            pnl.Controls.Add(msgLb);
        }
        
        //Add new Student
        private void addBtn_Click(object sender, EventArgs e)
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

                    string selectIntakeQuery = "SELECT id FROM Intakes where intake = '" + intake+"'";
                    using (SqlCommand cmd = new SqlCommand(selectIntakeQuery, con))
                    {
                        intakeID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string insertQuery = "INSERT INTO Student_info(reg_no,name,email,mobile,degree_programme_id,d_or_c,intake_id) values (@reg_no,@name,@email,@mobile,@degree_programme_id,@d_or_c,@intake_id)";
                    using(SqlCommand cmd = new SqlCommand(insertQuery, con))
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
                }
            }catch(SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
            }
            
        }
    }
}
