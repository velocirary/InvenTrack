namespace InvenTrack.Forms
{
    partial class InvenTrackLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvenTrackLogin));
            this.pcbLoginApp = new System.Windows.Forms.PictureBox();
            this.lblDontHaveAccount = new TransparentLabel();
            this.rbtLogin = new RoundedButton();
            this.lblForgotPassword = new TransparentLabel();
            this.lblPassword = new TransparentLabel();
            this.lblEmail = new TransparentLabel();
            this.lblAppLogin = new TransparentLabel();
            this.lblBemVindoLogin = new TransparentLabel();
            this.rtbEmailLogin = new RoundedMaskedTextBox();
            this.rtbPasswordLogin = new RoundedMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoginApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLoginApp
            // 
            this.pcbLoginApp.Image = ((System.Drawing.Image)(resources.GetObject("pcbLoginApp.Image")));
            this.pcbLoginApp.Location = new System.Drawing.Point(-6, -9);
            this.pcbLoginApp.Name = "pcbLoginApp";
            this.pcbLoginApp.Size = new System.Drawing.Size(248, 500);
            this.pcbLoginApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLoginApp.TabIndex = 0;
            this.pcbLoginApp.TabStop = false;
            // 
            // lblDontHaveAccount
            // 
            this.lblDontHaveAccount.AutoSize = true;
            this.lblDontHaveAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDontHaveAccount.ForeColor = System.Drawing.Color.White;
            this.lblDontHaveAccount.Location = new System.Drawing.Point(61, 401);
            this.lblDontHaveAccount.Name = "lblDontHaveAccount";
            this.lblDontHaveAccount.Size = new System.Drawing.Size(116, 13);
            this.lblDontHaveAccount.TabIndex = 5;
            this.lblDontHaveAccount.Text = "Don\'t have an account";
            this.lblDontHaveAccount.Click += new System.EventHandler(this.lblDontHaveAccount_Click);
            // 
            // rbtLogin
            // 
            this.rbtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtLogin.BorderRadius = 15;
            this.rbtLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtLogin.ForeColor = System.Drawing.Color.White;
            this.rbtLogin.HoverColor = System.Drawing.Color.LightGray;
            this.rbtLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtLogin.Location = new System.Drawing.Point(30, 333);
            this.rbtLogin.Name = "rbtLogin";
            this.rbtLogin.PressedColor = System.Drawing.Color.Gainsboro;
            this.rbtLogin.Size = new System.Drawing.Size(177, 28);
            this.rbtLogin.TabIndex = 4;
            this.rbtLogin.Text = "Login";
            this.rbtLogin.UseVisualStyleBackColor = false;
            this.rbtLogin.Click += new System.EventHandler(this.rbtLogin_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPassword.Location = new System.Drawing.Point(76, 366);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(92, 13);
            this.lblForgotPassword.TabIndex = 3;
            this.lblForgotPassword.Text = "Forgot Password?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(27, 270);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(24, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail";
            // 
            // lblAppLogin
            // 
            this.lblAppLogin.AutoSize = true;
            this.lblAppLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppLogin.ForeColor = System.Drawing.Color.White;
            this.lblAppLogin.Location = new System.Drawing.Point(90, 110);
            this.lblAppLogin.Name = "lblAppLogin";
            this.lblAppLogin.Size = new System.Drawing.Size(68, 16);
            this.lblAppLogin.TabIndex = 6;
            this.lblAppLogin.Text = "App Login";
            // 
            // lblBemVindoLogin
            // 
            this.lblBemVindoLogin.AutoSize = true;
            this.lblBemVindoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBemVindoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindoLogin.ForeColor = System.Drawing.Color.White;
            this.lblBemVindoLogin.Location = new System.Drawing.Point(80, 164);
            this.lblBemVindoLogin.Name = "lblBemVindoLogin";
            this.lblBemVindoLogin.Size = new System.Drawing.Size(88, 20);
            this.lblBemVindoLogin.TabIndex = 7;
            this.lblBemVindoLogin.Text = "Bem-vindo!";
            // 
            // rtbEmailLogin
            // 
            this.rtbEmailLogin.BackColor = System.Drawing.Color.White;
            this.rtbEmailLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rtbEmailLogin.Location = new System.Drawing.Point(25, 231);
            this.rtbEmailLogin.Mask = "";
            this.rtbEmailLogin.Name = "rtbEmailLogin";
            this.rtbEmailLogin.Padding = new System.Windows.Forms.Padding(10);
            this.rtbEmailLogin.Size = new System.Drawing.Size(187, 30);
            this.rtbEmailLogin.TabIndex = 8;
            this.rtbEmailLogin.TextValue = "";
            // 
            // rtbPasswordLogin
            // 
            this.rtbPasswordLogin.BackColor = System.Drawing.Color.White;
            this.rtbPasswordLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rtbPasswordLogin.Location = new System.Drawing.Point(26, 285);
            this.rtbPasswordLogin.Mask = "";
            this.rtbPasswordLogin.Name = "rtbPasswordLogin";
            this.rtbPasswordLogin.Padding = new System.Windows.Forms.Padding(10);
            this.rtbPasswordLogin.Size = new System.Drawing.Size(187, 30);
            this.rtbPasswordLogin.TabIndex = 9;
            this.rtbPasswordLogin.TextValue = "";
            // 
            // InvenTrackLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(239, 426);
            this.Controls.Add(this.rtbPasswordLogin);
            this.Controls.Add(this.rtbEmailLogin);
            this.Controls.Add(this.lblBemVindoLogin);
            this.Controls.Add(this.lblAppLogin);
            this.Controls.Add(this.lblDontHaveAccount);
            this.Controls.Add(this.rbtLogin);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pcbLoginApp);
            this.MaximizeBox = false;
            this.Name = "InvenTrackLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvenTrackLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoginApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLoginApp;
        private TransparentLabel lblEmail;
        private TransparentLabel lblPassword;
        private TransparentLabel lblForgotPassword;
        private RoundedButton rbtLogin;
        private TransparentLabel lblDontHaveAccount;
        private TransparentLabel lblAppLogin;
        private TransparentLabel lblBemVindoLogin;
        private RoundedMaskedTextBox rtbEmailLogin;
        private RoundedMaskedTextBox rtbPasswordLogin;
    }
}