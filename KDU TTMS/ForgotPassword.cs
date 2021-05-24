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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            GetCode getCodeFrm = new GetCode()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            getCodeFrm.FormBorderStyle = FormBorderStyle.None;
            this.panelContainer.Controls.Add(getCodeFrm);
            getCodeFrm.Show();

            //getCodeFrm.getCodeBtn
        }
    }
}
