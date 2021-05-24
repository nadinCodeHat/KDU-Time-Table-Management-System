
namespace KDU_TTMS
{
    partial class GetCode
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
            this.msgTxt = new System.Windows.Forms.Label();
            this.getCodeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgTxt
            // 
            this.msgTxt.BackColor = System.Drawing.Color.Transparent;
            this.msgTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msgTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgTxt.ForeColor = System.Drawing.Color.Red;
            this.msgTxt.Location = new System.Drawing.Point(45, 276);
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(250, 22);
            this.msgTxt.TabIndex = 56;
            this.msgTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getCodeBtn
            // 
            this.getCodeBtn.BackColor = System.Drawing.Color.Transparent;
            this.getCodeBtn.BorderRadius = 3;
            this.getCodeBtn.CheckedState.Parent = this.getCodeBtn;
            this.getCodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getCodeBtn.CustomImages.Parent = this.getCodeBtn;
            this.getCodeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.getCodeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.getCodeBtn.ForeColor = System.Drawing.Color.White;
            this.getCodeBtn.HoverState.Parent = this.getCodeBtn;
            this.getCodeBtn.Location = new System.Drawing.Point(45, 232);
            this.getCodeBtn.Name = "getCodeBtn";
            this.getCodeBtn.ShadowDecoration.Parent = this.getCodeBtn;
            this.getCodeBtn.Size = new System.Drawing.Size(250, 36);
            this.getCodeBtn.TabIndex = 55;
            this.getCodeBtn.Text = "Get Code";
            this.getCodeBtn.Click += new System.EventHandler(this.getCodeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Reset password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(42, 120);
            this.label1.MaximumSize = new System.Drawing.Size(255, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 30);
            this.label1.TabIndex = 53;
            this.label1.Text = "Enter the email associated with the account and we\'ll send an email with a genera" +
    "ted code.\r\n";
            // 
            // emailTxt
            // 
            this.emailTxt.Animated = true;
            this.emailTxt.BackColor = System.Drawing.Color.White;
            this.emailTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.emailTxt.BorderRadius = 3;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.DefaultText = "";
            this.emailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.DisabledState.Parent = this.emailTxt;
            this.emailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.emailTxt.FocusedState.FillColor = System.Drawing.Color.GhostWhite;
            this.emailTxt.FocusedState.Parent = this.emailTxt;
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.emailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.emailTxt.HoverState.Parent = this.emailTxt;
            this.emailTxt.Location = new System.Drawing.Point(45, 184);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderText = "";
            this.emailTxt.SelectedText = "";
            this.emailTxt.ShadowDecoration.Parent = this.emailTxt;
            this.emailTxt.Size = new System.Drawing.Size(250, 36);
            this.emailTxt.TabIndex = 52;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(81)))));
            this.emailLabel.Location = new System.Drawing.Point(42, 165);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 51;
            this.emailLabel.Text = "Email";
            // 
            // GetCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 381);
            this.Controls.Add(this.msgTxt);
            this.Controls.Add(this.getCodeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.emailLabel);
            this.Name = "GetCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private System.Windows.Forms.Label emailLabel;
        protected internal Guna.UI2.WinForms.Guna2Button getCodeBtn;
    }
}