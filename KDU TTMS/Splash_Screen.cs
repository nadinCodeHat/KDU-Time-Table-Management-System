using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        struct DataParameter
        {
            public int Process;
            public int Delay;
        }

        private DataParameter _inputParameter;

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                _inputParameter.Delay = 1;
                _inputParameter.Process = 1200;
                backgroundWorker.RunWorkerAsync(_inputParameter);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            guna2ProgressBar1.Value = e.ProgressPercentage;
            guna2ProgressBar1.Update();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParameter)e.Argument).Process;
            int delay = ((DataParameter)e.Argument).Delay;
            int index = 1;
            try
            {
                for(int i = 0; i < process; i++)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, string.Format("Process data {0}", i));
                        Thread.Sleep(delay);
                    }
                }
            }catch(Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.ToString());
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
