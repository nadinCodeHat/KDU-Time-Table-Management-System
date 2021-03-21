
namespace KDU_TTMS
{
    partial class Splash_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loading_txt = new System.Windows.Forms.Label();
            this.cpy_yr_txt = new System.Windows.Forms.Label();
            this.kdu_logo = new System.Windows.Forms.PictureBox();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.kdu_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // loading_txt
            // 
            this.loading_txt.AutoSize = true;
            this.loading_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_txt.ForeColor = System.Drawing.Color.DimGray;
            this.loading_txt.Location = new System.Drawing.Point(12, 229);
            this.loading_txt.Name = "loading_txt";
            this.loading_txt.Size = new System.Drawing.Size(59, 15);
            this.loading_txt.TabIndex = 0;
            this.loading_txt.Text = "Loading...";
            // 
            // cpy_yr_txt
            // 
            this.cpy_yr_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpy_yr_txt.AutoSize = true;
            this.cpy_yr_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpy_yr_txt.ForeColor = System.Drawing.Color.DimGray;
            this.cpy_yr_txt.Location = new System.Drawing.Point(352, 229);
            this.cpy_yr_txt.Name = "cpy_yr_txt";
            this.cpy_yr_txt.Size = new System.Drawing.Size(71, 15);
            this.cpy_yr_txt.TabIndex = 1;
            this.cpy_yr_txt.Text = "© 2020 KDU";
            // 
            // kdu_logo
            // 
            this.kdu_logo.Image = global::KDU_TTMS.Properties.Resources.kdu_logo;
            this.kdu_logo.Location = new System.Drawing.Point(157, 67);
            this.kdu_logo.Name = "kdu_logo";
            this.kdu_logo.Size = new System.Drawing.Size(120, 120);
            this.kdu_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kdu_logo.TabIndex = 2;
            this.kdu_logo.TabStop = false;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(0, 250);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(435, 5);
            this.guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.guna2ProgressBar1.TabIndex = 3;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 255);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.kdu_logo);
            this.Controls.Add(this.cpy_yr_txt);
            this.Controls.Add(this.loading_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdu_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loading_txt;
        private System.Windows.Forms.Label cpy_yr_txt;
        private System.Windows.Forms.PictureBox kdu_logo;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

