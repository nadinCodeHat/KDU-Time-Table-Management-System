using System;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void About_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
