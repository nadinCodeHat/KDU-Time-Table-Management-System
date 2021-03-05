
namespace KDU_TTMS
{
    partial class Manage_Students
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.student_info_table = new System.Windows.Forms.DataGridView();
            this.search_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.exportBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_info_table)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.student_info_table);
            this.guna2Panel1.Controls.Add(this.search_textbox);
            this.guna2Panel1.Controls.Add(this.button1);
            this.guna2Panel1.Controls.Add(this.exportBtn);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton2);
            this.guna2Panel1.Controls.Add(this.label22);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.guna2Panel1.Location = new System.Drawing.Point(23, 23);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1108, 669);
            this.guna2Panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(863, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 105;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.label22.Location = new System.Drawing.Point(28, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 21);
            this.label22.TabIndex = 18;
            this.label22.Text = "Students";
            // 
            // student_info_table
            // 
            this.student_info_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_info_table.Location = new System.Drawing.Point(32, 57);
            this.student_info_table.Name = "student_info_table";
            this.student_info_table.Size = new System.Drawing.Size(1020, 586);
            this.student_info_table.TabIndex = 107;
            // 
            // search_textbox
            // 
            this.search_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_textbox.DefaultText = "";
            this.search_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_textbox.DisabledState.Parent = this.search_textbox;
            this.search_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_textbox.FocusedState.Parent = this.search_textbox;
            this.search_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_textbox.HoverState.Parent = this.search_textbox;
            this.search_textbox.IconLeft = global::KDU_TTMS.Properties.Resources.search_50px;
            this.search_textbox.Location = new System.Drawing.Point(606, 21);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.PasswordChar = '\0';
            this.search_textbox.PlaceholderText = "";
            this.search_textbox.SelectedText = "";
            this.search_textbox.ShadowDecoration.Parent = this.search_textbox;
            this.search_textbox.Size = new System.Drawing.Size(251, 30);
            this.search_textbox.TabIndex = 106;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(210)))), ((int)(((byte)(158)))));
            this.exportBtn.CheckedState.Parent = this.exportBtn;
            this.exportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportBtn.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.exportBtn.HoverState.Parent = this.exportBtn;
            this.exportBtn.Image = global::KDU_TTMS.Properties.Resources.export_xls_50px;
            this.exportBtn.Location = new System.Drawing.Point(976, 21);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.PressedState.Parent = this.exportBtn;
            this.exportBtn.Size = new System.Drawing.Size(30, 30);
            this.exportBtn.TabIndex = 27;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = global::KDU_TTMS.Properties.Resources.add_50px;
            this.guna2ImageButton2.Location = new System.Drawing.Point(1022, 21);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.TabIndex = 26;
            // 
            // Manage_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1156, 717);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Students";
            this.Load += new System.EventHandler(this.Manage_Students_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_info_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2ImageButton exportBtn;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox search_textbox;
        private System.Windows.Forms.DataGridView student_info_table;
    }
}