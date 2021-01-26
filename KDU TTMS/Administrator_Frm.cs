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
        //top part show intake and number of students
        //lecturers show department wise
        //number of modules and department wise
        //intakes and streams

        //Call Open Dashboard Form
        private Form activeFormDashboard = null;
        private void openDashboardForm(Form dashboard_frm)
        {
            if (activeFormDashboard != null) activeFormDashboard.Dispose();
            activeFormDashboard = dashboard_frm;
            dashboard_frm.TopLevel = false;
            dashboard_frm.FormBorderStyle = FormBorderStyle.None;
            dashboard_frm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(dashboard_frm);
            containerPanel.Tag = dashboard_frm;
            dashboard_frm.BringToFront();
            dashboard_frm.Show();
        }

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
            //Show Dashboard
            openDashboardForm(new Administrator_Dashboard_Frm());
        }

        //Call Open Timetable Form
        private Form activeFormTimetable = null;
        private void openTimetableForm(Form timetable_frm)
        {
            if (activeFormTimetable != null) activeFormTimetable.Dispose();
            activeFormTimetable = timetable_frm;
            timetable_frm.TopLevel = false;
            timetable_frm.FormBorderStyle = FormBorderStyle.None;
            timetable_frm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(timetable_frm);
            containerPanel.Tag = timetable_frm;
            timetable_frm.BringToFront();
            timetable_frm.Show();
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
            //Show Timetable
           // openTimetableForm(new Timetable_Frm());
        }

        //Call Open Students Form
        private Form activeFormStudent = null;
        private void openStudentForm(Form student_frm)
        {
            if (activeFormStudent != null) activeFormStudent.Dispose();
            activeFormStudent = student_frm;
            student_frm.TopLevel = false;
            student_frm.FormBorderStyle = FormBorderStyle.None;
            student_frm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(student_frm);
            containerPanel.Tag = student_frm;
            student_frm.BringToFront();
            student_frm.Show();
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
            //Show Students
            //openStudentForm(new Students_Frm());
        }

        //Call Open Lecturers Form
        private Form activeFormLecturers = null;
        private void openLecturersForm(Form lecturers_frm)
        {
            if (activeFormLecturers != null) activeFormLecturers.Dispose();
            activeFormLecturers = lecturers_frm;
            lecturers_frm.TopLevel = false;
            lecturers_frm.FormBorderStyle = FormBorderStyle.None;
            lecturers_frm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(lecturers_frm);
            containerPanel.Tag = lecturers_frm;
            lecturers_frm.BringToFront();
            lecturers_frm.Show();
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
            //Show Lecturers
            //openLecturersForm(new Lecturers_Frm());
        }

        //Call Open Modules Form
        private Form activeFormModules = null;
        private void openModulesForm(Form modules_frm)
        {
            if (activeFormModules != null) activeFormModules.Dispose();
            activeFormModules = modules_frm;
            modules_frm.TopLevel = false;
            modules_frm.FormBorderStyle = FormBorderStyle.None;
            modules_frm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(modules_frm);
            containerPanel.Tag = modules_frm;
            modules_frm.BringToFront();
            modules_frm.Show();
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
            //Show Modules
            //openModulesForm(new Modules_Frm());
        }

        //Call Open Intakes Form
        private Form activeFormIntake = null;
        private void openIntakesForm(Form intakes_frm)
        {
            if (activeFormIntake != null) activeFormIntake.Dispose();
            activeFormIntake = intakes_frm;
            intakes_frm.TopLevel = false;
            intakes_frm.FormBorderStyle = FormBorderStyle.None;
            intakes_frm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(intakes_frm);
            containerPanel.Tag = intakes_frm;
            intakes_frm.BringToFront();
            intakes_frm.Show();
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
            //Show Intakes Form
            //openIntakesForm(new Intakes_Frm());
        }

        //Call Open Assistants Form
        private Form activeFormAssistant = null;
        private void openAssistantForm(Form assistant_frm)
        {
            if (activeFormAssistant != null) activeFormAssistant.Dispose();
            activeFormAssistant = assistant_frm;
            assistant_frm.TopLevel = false;
            assistant_frm.FormBorderStyle = FormBorderStyle.None;
            assistant_frm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(assistant_frm);
            containerPanel.Tag = assistant_frm;
            assistant_frm.BringToFront();
            assistant_frm.Show();
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
           //Show Asssistants From
           //openAssistantForm(new Assistants_Frm());
        }

        //Call Open LectureHalls Form
        private Form activeFormLectureHalls = null;
        private void openLectureHallsForm(Form lecturehalls_frm)
        {
            if (activeFormLectureHalls != null) activeFormLectureHalls.Dispose();
            activeFormLectureHalls = lecturehalls_frm;
            lecturehalls_frm.TopLevel = false;
            lecturehalls_frm.FormBorderStyle = FormBorderStyle.None;
            lecturehalls_frm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(lecturehalls_frm);
            containerPanel.Tag = lecturehalls_frm;
            lecturehalls_frm.BringToFront();
            lecturehalls_frm.Show();
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
            //Show Lecture Halls Form
            //openLectureHallsForm(new LectureHalls_Frm());
        }

        //Call Open Profile Form
        private Form activeFormProfile = null;
        private void openProfileForm(Form profile_frm)
        {
            if (activeFormProfile != null) activeFormProfile.Dispose();
            activeFormProfile = profile_frm;
            profile_frm.TopLevel = false;
            profile_frm.FormBorderStyle = FormBorderStyle.None;
            profile_frm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(profile_frm);
            containerPanel.Tag = profile_frm;
            profile_frm.BringToFront();
            profile_frm.Show();
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
            //Show Profiles Form
            //openProfileForm(new Profile_frm());
        }
    }
}
