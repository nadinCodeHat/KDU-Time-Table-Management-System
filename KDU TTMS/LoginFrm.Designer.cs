
namespace KDU_TTMS
{
    partial class LoginFrm
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.remMeCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.contactHereLink = new System.Windows.Forms.LinkLabel();
            this.msgTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(81)))));
            this.emailLabel.Location = new System.Drawing.Point(66, 145);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(81)))));
            this.passwordLabel.Location = new System.Drawing.Point(66, 212);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 16;
            this.passwordLabel.Text = "Password";
            // 
            // remMeCheckBox
            // 
            this.remMeCheckBox.Animated = true;
            this.remMeCheckBox.AutoSize = true;
            this.remMeCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.remMeCheckBox.CheckedState.BorderRadius = 2;
            this.remMeCheckBox.CheckedState.BorderThickness = 1;
            this.remMeCheckBox.CheckedState.FillColor = System.Drawing.Color.White;
            this.remMeCheckBox.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.remMeCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.remMeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.remMeCheckBox.Location = new System.Drawing.Point(69, 334);
            this.remMeCheckBox.Name = "remMeCheckBox";
            this.remMeCheckBox.Size = new System.Drawing.Size(104, 19);
            this.remMeCheckBox.TabIndex = 12;
            this.remMeCheckBox.Text = "Remember Me";
            this.remMeCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.remMeCheckBox.UncheckedState.BorderRadius = 2;
            this.remMeCheckBox.UncheckedState.BorderThickness = 1;
            this.remMeCheckBox.UncheckedState.FillColor = System.Drawing.Color.White;
            this.remMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BorderRadius = 3;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(69, 283);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(250, 36);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KDU_TTMS.Properties.Resources.kdu_logo;
            this.pictureBox2.Location = new System.Drawing.Point(160, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
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
            this.emailTxt.Location = new System.Drawing.Point(69, 164);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderText = "";
            this.emailTxt.SelectedText = "";
            this.emailTxt.ShadowDecoration.Parent = this.emailTxt;
            this.emailTxt.Size = new System.Drawing.Size(250, 36);
            this.emailTxt.TabIndex = 18;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Animated = true;
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.passwordTxt.BorderRadius = 3;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.DisabledState.Parent = this.passwordTxt;
            this.passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.passwordTxt.FocusedState.FillColor = System.Drawing.Color.GhostWhite;
            this.passwordTxt.FocusedState.Parent = this.passwordTxt;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.passwordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.passwordTxt.HoverState.Parent = this.passwordTxt;
            this.passwordTxt.Location = new System.Drawing.Point(69, 231);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.PlaceholderText = "";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.ShadowDecoration.Parent = this.passwordTxt;
            this.passwordTxt.Size = new System.Drawing.Size(250, 36);
            this.passwordTxt.TabIndex = 19;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(121, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Need Help?";
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(226)))));
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.forgotPasswordLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.forgotPasswordLink.Location = new System.Drawing.Point(219, 335);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(100, 15);
            this.forgotPasswordLink.TabIndex = 23;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forgot Password?";
            this.forgotPasswordLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.forgotPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLink_LinkClicked);
            // 
            // contactHereLink
            // 
            this.contactHereLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(105)))), ((int)(((byte)(226)))));
            this.contactHereLink.AutoSize = true;
            this.contactHereLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contactHereLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.contactHereLink.Location = new System.Drawing.Point(187, 390);
            this.contactHereLink.Name = "contactHereLink";
            this.contactHereLink.Size = new System.Drawing.Size(77, 15);
            this.contactHereLink.TabIndex = 24;
            this.contactHereLink.TabStop = true;
            this.contactHereLink.Text = "Contact Here";
            this.contactHereLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.contactHereLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contactHereLink_LinkClicked);
            // 
            // msgTxt
            // 
            this.msgTxt.BackColor = System.Drawing.Color.Transparent;
            this.msgTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msgTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgTxt.ForeColor = System.Drawing.Color.Red;
            this.msgTxt.Location = new System.Drawing.Point(69, 356);
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(250, 22);
            this.msgTxt.TabIndex = 49;
            this.msgTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msgTxt);
            this.Controls.Add(this.contactHereLink);
            this.Controls.Add(this.forgotPasswordLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.remMeCheckBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "LoginFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private Guna.UI2.WinForms.Guna2CheckBox remMeCheckBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel forgotPasswordLink;
        private System.Windows.Forms.LinkLabel contactHereLink;
        private System.Windows.Forms.Label msgTxt;
        private System.Windows.Forms.Button button1;
    }
}