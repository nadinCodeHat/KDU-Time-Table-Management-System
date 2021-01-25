using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Administrator_Frm : Form
    {
        public Administrator_Frm()
        {
            InitializeComponent();
        }

        //Change navigation panel text to a lighter color

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(0, 0);
            dashboardBtn.Checked = true;
            timetableBtn.Checked = false;
            studentsBtn.Checked = false;
            lecturersBtn.Checked = false;
            modulesBtn.Checked = false;
            intakesBtn.Checked = false;
            assistantsBtn.Checked = false;
            lecturehallsBtn.Checked = false;
            profileBtn.Checked = false;
        }

        private void timetableBtn_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(0, 40);
            dashboardBtn.Checked = false;
            timetableBtn.Checked = true;
            studentsBtn.Checked = false;
            lecturersBtn.Checked = false;
            modulesBtn.Checked = false;
            intakesBtn.Checked = false;
            assistantsBtn.Checked = false;
            lecturehallsBtn.Checked = false;
            profileBtn.Checked = false;
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(0, 80);
            dashboardBtn.Checked = false;
            timetableBtn.Checked = false;
            studentsBtn.Checked = true;
            lecturersBtn.Checked = false;
            modulesBtn.Checked = false;
            intakesBtn.Checked = false;
            assistantsBtn.Checked = false;
            lecturehallsBtn.Checked = false;
            profileBtn.Checked = false;
        }

        private void lecturersBtn_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(0, 120);
            dashboardBtn.Checked = false;
            timetableBtn.Checked = false;
            studentsBtn.Checked = false;
            lecturersBtn.Checked = true;
            modulesBtn.Checked = false;
            intakesBtn.Checked = false;
            assistantsBtn.Checked = false;
            lecturehallsBtn.Checked = false;
            profileBtn.Checked = false;
        }

        private void modulesBtn_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(0, 160);
            dashboardBtn.Checked = false;
            timetableBtn.Checked = false;
            studentsBtn.Checked = false;
            lecturersBtn.Checked = false;
            modulesBtn.Checked = true;
            intakesBtn.Checked = false;
            assistantsBtn.Checked = false;
            lecturehallsBtn.Checked = false;
            profileBtn.Checked = false;
        }

        private void intakesBtn_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(0, 200);
            dashboardBtn.Checked = false;
            timetableBtn.Checked = false;
            studentsBtn.Checked = false;
            lecturersBtn.Checked = false;
            modulesBtn.Checked = false;
            intakesBtn.Checked = true;
            assistantsBtn.Checked = false;
            lecturehallsBtn.Checked = false;
            profileBtn.Checked = false;
        }

        private void assistantsBtn_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(0, 240);
            dashboardBtn.Checked = false;
            timetableBtn.Checked = false;
            studentsBtn.Checked = false;
            lecturersBtn.Checked = false;
            modulesBtn.Checked = false;
            intakesBtn.Checked = false;
            assistantsBtn.Checked = true;
            lecturehallsBtn.Checked = false;
            profileBtn.Checked = false;
        }

        private void lecturehallsBtn_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(0, 280);
            dashboardBtn.Checked = false;
            timetableBtn.Checked = false;
            studentsBtn.Checked = false;
            lecturersBtn.Checked = false;
            modulesBtn.Checked = false;
            intakesBtn.Checked = false;
            assistantsBtn.Checked = false;
            lecturehallsBtn.Checked = true;
            profileBtn.Checked = false;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(0, 320);
            dashboardBtn.Checked = false;
            timetableBtn.Checked = false;
            studentsBtn.Checked = false;
            lecturersBtn.Checked = false;
            modulesBtn.Checked = false;
            intakesBtn.Checked = false;
            assistantsBtn.Checked = false;
            lecturehallsBtn.Checked = false;
            profileBtn.Checked = true;
        }
    }
}
