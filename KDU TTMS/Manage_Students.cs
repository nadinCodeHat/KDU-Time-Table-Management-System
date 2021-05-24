using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Manage_Students : Form
    {
        //Connection String 
        string connectionString = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;

        public Manage_Students()
        {
            InitializeComponent();
        }

        private void LoadStudents()
        {
            //student_info_table.Columns.Clear();
            //student_info_table.DataSource = null;
            //student_info_table.Rows.Clear();
            //student_info_table.Refresh();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT student_info.reg_no,student_info.name,degree_programme_info.degree_programme,student_info.email,student_info.mobile,student_info.d_or_c,intakes.intake from student_info inner join intakes on intakes.id = student_info.intake_id inner join degree_programme_info on degree_programme_info.id = student_info.degree_programme_id order by intakes.intake";
                conn.Open();

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //student_info_table.DataSource = dt;
                }
            }
            //student_info_table.Columns[0].Name = "registration_no";
            //student_info_table.Columns[1].Name = "student_name";
            //student_info_table.Columns[2].Name = "course_stream";
            //student_info_table.Columns[3].Name = "email";
            //student_info_table.Columns[4].Name = "mobile_no";
            //student_info_table.Columns[5].Name = "d_or_c";
            //student_info_table.Columns[6].Name = "intake";

            //student_info_table.Columns[0].HeaderText = "Reg. Number";
            //student_info_table.Columns[1].HeaderText = "Name";
            //student_info_table.Columns[2].HeaderText = "Course Stream";
            //student_info_table.Columns[3].HeaderText = "Email";
            //student_info_table.Columns[4].HeaderText = "Mobile No.";
            //student_info_table.Columns[5].HeaderText = "Day Scholar/Cadet";
            //student_info_table.Columns[6].HeaderText = "Intake";

            DataGridViewImageColumn viewBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
            viewBtn.Name = "view_btn";
            viewBtn.HeaderText = "View";
            //viewBtn.Image = Resources.edit_btn;
            viewBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //student_info_table.Columns.Insert(6, viewBtn);

            deleteBtn.Name = "delete_btn";
            deleteBtn.HeaderText = "Delete";
            // deleteBtn.Image = Resources.delete;
            deleteBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //student_info_table.Columns.Insert(7, deleteBtn);


            //Set Column Width
            for (int i = 0; i <= 8; i++)
            {
                //DataGridViewColumn tt_id_col = student_info_table.Columns[i];
                //if (i == 0)
                //{
                //    tt_id_col.Width = 150;
                //}
                //else if (i == 1)
                //{
                //    tt_id_col.Width = 220;
                //}
                //else if (i == 2)
                //{
                //    tt_id_col.Width = 200;
                //}
                //else if (i == 3)
                //{
                //    tt_id_col.Width = 180;
                //}
                //else if (i == 4)
                //{
                //    tt_id_col.Width = 100;
                //}
                //else if (i == 5)
                //{
                //    tt_id_col.Width = 80;
                //}
                //else if (i == 6)
                //{
                //    tt_id_col.Width = 50;
                //}
                //else if (i == 7)
                //{
                //    tt_id_col.Width = 50;
                //}
                //else if (i == 8)
                //{
                //    tt_id_col.Width = 50;
                //}
            }
        }

        private void Manage_Students_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)

                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "C:";
            sfd.Title = "Save as Excel File";
            sfd.Filter = "Excel Files(2003)|*.xls";
            sfd.FileName = "";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");

                // ToCsV(student_info_table, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }
    }
}
