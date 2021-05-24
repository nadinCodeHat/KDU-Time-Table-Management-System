using System;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Student_Frm : Form
    {
        public Student_Frm()
        {
            InitializeComponent();
        }

        private void aboutLink_Click(object sender, EventArgs e)
        {
            About aboutFrm = new About();
            aboutFrm.ShowDialog();
        }
        //show a panel like in the recent activity
        // number of students and distribute them into cadets and dayscholar
    }
}
