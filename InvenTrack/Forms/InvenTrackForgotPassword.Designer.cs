namespace InvenTrack.Forms
{
    partial class InvenTrackForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvenTrackForgotPassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnNovaSenha = new RoundedButton();
            this.rtxtNovaSenha = new RoundedMaskedTextBox();
            this.rbtnConfirmarCodigo = new RoundedButton();
            this.voltar = new RoundedButton();
            this.rbtEnviarCodigo = new RoundedButton();
            this.rtxtCodigoVerificacao = new RoundedMaskedTextBox();
            this.lblCodigo = new TransparentLabel();
            this.rtbEmailLogin = new RoundedMaskedTextBox();
            this.lblEmail = new TransparentLabel();
            this.lblAppSenha = new TransparentLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-41, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnNovaSenha
            // 
            this.rbtnNovaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtnNovaSenha.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtnNovaSenha.BorderRadius = 15;
            this.rbtnNovaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnNovaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnNovaSenha.ForeColor = System.Drawing.Color.White;
            this.rbtnNovaSenha.HoverColor = System.Drawing.Color.LightGray;
            this.rbtnNovaSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnNovaSenha.Location = new System.Drawing.Point(36, 273);
            this.rbtnNovaSenha.Name = "rbtnNovaSenha";
            this.rbtnNovaSenha.PressedColor = System.Drawing.Color.Gainsboro;
            this.rbtnNovaSenha.Size = new System.Drawing.Size(177, 28);
            this.rbtnNovaSenha.TabIndex = 17;
            this.rbtnNovaSenha.Text = "Salvar nova Senha";
            this.rbtnNovaSenha.UseVisualStyleBackColor = false;
            this.rbtnNovaSenha.Visible = false;
            this.rbtnNovaSenha.Click += new System.EventHandler(this.rbtnNovaSenha_Click);
            // 
            // rtxtNovaSenha
            // 
            this.rtxtNovaSenha.BackColor = System.Drawing.Color.White;
            this.rtxtNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rtxtNovaSenha.Location = new System.Drawing.Point(31, 234);
            this.rtxtNovaSenha.Mask = "";
            this.rtxtNovaSenha.Name = "rtxtNovaSenha";
            this.rtxtNovaSenha.Padding = new System.Windows.Forms.Padding(10);
            this.rtxtNovaSenha.Size = new System.Drawing.Size(187, 30);
            this.rtxtNovaSenha.TabIndex = 16;
            this.rtxtNovaSenha.TextValue = "";
            this.rtxtNovaSenha.Visible = false;
            // 
            // rbtnConfirmarCodigo
            // 
            this.rbtnConfirmarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtnConfirmarCodigo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtnConfirmarCodigo.BorderRadius = 15;
            this.rbtnConfirmarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnConfirmarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnConfirmarCodigo.ForeColor = System.Drawing.Color.White;
            this.rbtnConfirmarCodigo.HoverColor = System.Drawing.Color.LightGray;
            this.rbtnConfirmarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnConfirmarCodigo.Location = new System.Drawing.Point(36, 273);
            this.rbtnConfirmarCodigo.Name = "rbtnConfirmarCodigo";
            this.rbtnConfirmarCodigo.PressedColor = System.Drawing.Color.Gainsboro;
            this.rbtnConfirmarCodigo.Size = new System.Drawing.Size(177, 28);
            this.rbtnConfirmarCodigo.TabIndex = 15;
            this.rbtnConfirmarCodigo.Text = "Confirmar Código";
            this.rbtnConfirmarCodigo.UseVisualStyleBackColor = false;
            this.rbtnConfirmarCodigo.Visible = false;
            this.rbtnConfirmarCodigo.Click += new System.EventHandler(this.rbtnConfirmarCodigo_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.White;
            this.voltar.BackgroundColor = System.Drawing.Color.White;
            this.voltar.BorderRadius = 15;
            this.voltar.FlatAppearance.BorderSize = 0;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.ForeColor = System.Drawing.Color.Black;
            this.voltar.HoverColor = System.Drawing.Color.LightGray;
            this.voltar.Location = new System.Drawing.Point(112, 369);
            this.voltar.Name = "voltar";
            this.voltar.PressedColor = System.Drawing.Color.Gainsboro;
            this.voltar.Size = new System.Drawing.Size(120, 30);
            this.voltar.TabIndex = 14;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // rbtEnviarCodigo
            // 
            this.rbtEnviarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtEnviarCodigo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtEnviarCodigo.BorderRadius = 15;
            this.rbtEnviarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtEnviarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtEnviarCodigo.ForeColor = System.Drawing.Color.White;
            this.rbtEnviarCodigo.HoverColor = System.Drawing.Color.LightGray;
            this.rbtEnviarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtEnviarCodigo.Location = new System.Drawing.Point(36, 218);
            this.rbtEnviarCodigo.Name = "rbtEnviarCodigo";
            this.rbtEnviarCodigo.PressedColor = System.Drawing.Color.Gainsboro;
            this.rbtEnviarCodigo.Size = new System.Drawing.Size(177, 28);
            this.rbtEnviarCodigo.TabIndex = 13;
            this.rbtEnviarCodigo.Text = "Enviar código";
            this.rbtEnviarCodigo.UseVisualStyleBackColor = false;
            this.rbtEnviarCodigo.Click += new System.EventHandler(this.rbtEnviarCodigo_Click);
            // 
            // rtxtCodigoVerificacao
            // 
            this.rtxtCodigoVerificacao.BackColor = System.Drawing.Color.White;
            this.rtxtCodigoVerificacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rtxtCodigoVerificacao.Location = new System.Drawing.Point(31, 234);
            this.rtxtCodigoVerificacao.Mask = "";
            this.rtxtCodigoVerificacao.Name = "rtxtCodigoVerificacao";
            this.rtxtCodigoVerificacao.Padding = new System.Windows.Forms.Padding(10);
            this.rtxtCodigoVerificacao.Size = new System.Drawing.Size(187, 30);
            this.rtxtCodigoVerificacao.TabIndex = 12;
            this.rtxtCodigoVerificacao.TextValue = "";
            this.rtxtCodigoVerificacao.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(33, 218);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(103, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código recuperação";
            this.lblCodigo.Visible = false;
            // 
            // rtbEmailLogin
            // 
            this.rtbEmailLogin.BackColor = System.Drawing.Color.White;
            this.rtbEmailLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rtbEmailLogin.Location = new System.Drawing.Point(31, 171);
            this.rtbEmailLogin.Mask = "";
            this.rtbEmailLogin.Name = "rtbEmailLogin";
            this.rtbEmailLogin.Padding = new System.Windows.Forms.Padding(10);
            this.rtbEmailLogin.Size = new System.Drawing.Size(187, 30);
            this.rtbEmailLogin.TabIndex = 10;
            this.rtbEmailLogin.TextValue = "";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(30, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // lblAppSenha
            // 
            this.lblAppSenha.AutoSize = true;
            this.lblAppSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppSenha.ForeColor = System.Drawing.Color.White;
            this.lblAppSenha.Location = new System.Drawing.Point(54, 102);
            this.lblAppSenha.Name = "lblAppSenha";
            this.lblAppSenha.Size = new System.Drawing.Size(149, 16);
            this.lblAppSenha.TabIndex = 7;
            this.lblAppSenha.Text = "Recuperação de senha";
            // 
            // InvenTrackForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 411);
            this.Controls.Add(this.rbtnNovaSenha);
            this.Controls.Add(this.rtxtNovaSenha);
            this.Controls.Add(this.rbtnConfirmarCodigo);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.rbtEnviarCodigo);
            this.Controls.Add(this.rtxtCodigoVerificacao);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.rtbEmailLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAppSenha);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InvenTrackForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvenTrackForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private TransparentLabel lblAppSenha;
        private RoundedMaskedTextBox rtbEmailLogin;
        private TransparentLabel lblEmail;
        private RoundedMaskedTextBox rtxtCodigoVerificacao;
        private TransparentLabel lblCodigo;
        private RoundedButton rbtEnviarCodigo;
        private RoundedButton voltar;
        private RoundedButton rbtnConfirmarCodigo;
        private RoundedMaskedTextBox rtxtNovaSenha;
        private RoundedButton rbtnNovaSenha;
    }
}