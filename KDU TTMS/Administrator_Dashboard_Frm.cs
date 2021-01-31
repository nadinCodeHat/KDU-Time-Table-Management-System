using System.Drawing;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Administrator_Dashboard_Frm : Form
    {
        public Administrator_Dashboard_Frm()
        {
            InitializeComponent();
            createStudentValues();
        }

        private void createStudentValues()
        {
            //create labels for student values
            Label cs = new Label();
            Label se = new Label();
            Label ce = new Label();
            Label it = new Label();
            Label iS = new Label();
            //computer science
            cs.Text = "bfb";
            cs.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            cs.ForeColor = Color.FromArgb(113, 128, 149);
            cs.Location = new Point(125, 75);
           // studentsPanel.Controls.Add(cs);         
            //software engineering
            se.Text = "bn";
            se.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            se.ForeColor = Color.FromArgb(113, 128, 149);
            se.Location = new Point(140, 98);
         //   studentsPanel.Controls.Add(se);
            //computer engineering
            ce.Text = "sdf";
            ce.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            ce.ForeColor = Color.FromArgb(113, 128, 149);
            ce.Location = new Point(148, 121);
          //  studentsPanel.Controls.Add(ce);
            //information technology
            it.Text = "fgfg";
            it.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            it.ForeColor = Color.FromArgb(113, 128, 149);
            it.Location = new Point(155, 144);
           // studentsPanel.Controls.Add(it);
            //information system
            iS.Text = "sd";
            iS.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            iS.ForeColor = Color.FromArgb(113, 128, 149);
            iS.Location = new Point(137, 167);
           // studentsPanel.Controls.Add(iS);
        }
   
        private void createLecturerValues()
        {

        }

        private void createIntakeValues()
        {

        }

        private void createModuleValues()
        {

        }

        private void Administrator_Dashboard_Frm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
