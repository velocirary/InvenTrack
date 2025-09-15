using System.Drawing;

namespace InvenTrack.Forms
{
    partial class InvenTrackRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvenTrackRegister));
            this.pcbCadastroApp = new System.Windows.Forms.PictureBox();
            this.rbtVoltar = new RoundedButton();
            this.rbtCadastrar = new RoundedButton();
            this.rcbCargoAtual = new RoundedComboBox();
            this.lblCargoAtual = new TransparentLabel();
            this.rtxDataNascimento = new RoundedMaskedTextBox();
            this.lblDataNascimento = new TransparentLabel();
            this.rtxCelular = new RoundedMaskedTextBox();
            this.rtxEmail = new RoundedMaskedTextBox();
            this.rtxNomeCompleto = new RoundedMaskedTextBox();
            this.lblCelular = new TransparentLabel();
            this.lblEmail = new TransparentLabel();
            this.lblNomeCompleto = new TransparentLabel();
            this.lblCadastroApp = new TransparentLabel();
            this.rtbSenha = new RoundedMaskedTextBox();
            this.lblSenha = new TransparentLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadastroApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCadastroApp
            // 
            this.pcbCadastroApp.Image = ((System.Drawing.Image)(resources.GetObject("pcbCadastroApp.Image")));
            this.pcbCadastroApp.Location = new System.Drawing.Point(-6, 0);
            this.pcbCadastroApp.Name = "pcbCadastroApp";
            this.pcbCadastroApp.Size = new System.Drawing.Size(246, 473);
            this.pcbCadastroApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCadastroApp.TabIndex = 0;
            this.pcbCadastroApp.TabStop = false;
            // 
            // rbtVoltar
            // 
            this.rbtVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtVoltar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtVoltar.BorderRadius = 15;
            this.rbtVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbtVoltar.ForeColor = System.Drawing.Color.White;
            this.rbtVoltar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(167)))), ((int)(((byte)(245)))));
            this.rbtVoltar.Location = new System.Drawing.Point(-2, -2);
            this.rbtVoltar.Name = "rbtVoltar";
            this.rbtVoltar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(167)))), ((int)(((byte)(245)))));
            this.rbtVoltar.Size = new System.Drawing.Size(35, 30);
            this.rbtVoltar.TabIndex = 21;
            this.rbtVoltar.Text = "←";
            this.rbtVoltar.UseVisualStyleBackColor = false;
            this.rbtVoltar.Click += new System.EventHandler(this.rbtVoltar_Click);
            // 
            // rbtCadastrar
            // 
            this.rbtCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtCadastrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rbtCadastrar.BorderRadius = 15;
            this.rbtCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbtCadastrar.ForeColor = System.Drawing.Color.White;
            this.rbtCadastrar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(167)))), ((int)(((byte)(245)))));
            this.rbtCadastrar.Location = new System.Drawing.Point(20, 403);
            this.rbtCadastrar.Name = "rbtCadastrar";
            this.rbtCadastrar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(167)))), ((int)(((byte)(245)))));
            this.rbtCadastrar.Size = new System.Drawing.Size(200, 30);
            this.rbtCadastrar.TabIndex = 20;
            this.rbtCadastrar.Text = "Cadastrar";
            this.rbtCadastrar.UseVisualStyleBackColor = false;
            this.rbtCadastrar.Click += new System.EventHandler(this.rbtCadastrar_Click);
            // 
            // rcbCargoAtual
            // 
            this.rcbCargoAtual.BackColor = System.Drawing.Color.White;
            this.rcbCargoAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rcbCargoAtual.Location = new System.Drawing.Point(17, 364);
            this.rcbCargoAtual.Name = "rcbCargoAtual";
            this.rcbCargoAtual.Padding = new System.Windows.Forms.Padding(5);
            this.rcbCargoAtual.SelectedIndex = -1;
            this.rcbCargoAtual.SelectedItem = null;
            this.rcbCargoAtual.Size = new System.Drawing.Size(200, 30);
            this.rcbCargoAtual.TabIndex = 19;
            // 
            // lblCargoAtual
            // 
            this.lblCargoAtual.AutoSize = true;
            this.lblCargoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoAtual.ForeColor = System.Drawing.Color.White;
            this.lblCargoAtual.Location = new System.Drawing.Point(17, 345);
            this.lblCargoAtual.Name = "lblCargoAtual";
            this.lblCargoAtual.Size = new System.Drawing.Size(76, 16);
            this.lblCargoAtual.TabIndex = 18;
            this.lblCargoAtual.Text = "Cargo atual";
            // 
            // rtxDataNascimento
            // 
            this.rtxDataNascimento.BackColor = System.Drawing.Color.White;
            this.rtxDataNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rtxDataNascimento.Location = new System.Drawing.Point(130, 255);
            this.rtxDataNascimento.Mask = "00/00/0000";
            this.rtxDataNascimento.Name = "rtxDataNascimento";
            this.rtxDataNascimento.Padding = new System.Windows.Forms.Padding(10);
            this.rtxDataNascimento.Size = new System.Drawing.Size(87, 30);
            this.rtxDataNascimento.TabIndex = 16;
            this.rtxDataNascimento.TextValue = "  /  /";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.White;
            this.lblDataNascimento.Location = new System.Drawing.Point(134, 236);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(79, 16);
            this.lblDataNascimento.TabIndex = 15;
            this.lblDataNascimento.Text = "Nascimento";
            // 
            // rtxCelular
            // 
            this.rtxCelular.BackColor = System.Drawing.Color.White;
            this.rtxCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rtxCelular.Location = new System.Drawing.Point(17, 255);
            this.rtxCelular.Mask = "(00) 00000-0000";
            this.rtxCelular.Name = "rtxCelular";
            this.rtxCelular.Padding = new System.Windows.Forms.Padding(10);
            this.rtxCelular.Size = new System.Drawing.Size(107, 30);
            this.rtxCelular.TabIndex = 14;
            this.rtxCelular.TextValue = "(  )      -";
            // 
            // rtxEmail
            // 
            this.rtxEmail.BackColor = System.Drawing.Color.White;
            this.rtxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rtxEmail.Location = new System.Drawing.Point(17, 199);
            this.rtxEmail.Mask = "";
            this.rtxEmail.Name = "rtxEmail";
            this.rtxEmail.Padding = new System.Windows.Forms.Padding(10);
            this.rtxEmail.Size = new System.Drawing.Size(200, 30);
            this.rtxEmail.TabIndex = 13;
            this.rtxEmail.TextValue = "";
            // 
            // rtxNomeCompleto
            // 
            this.rtxNomeCompleto.BackColor = System.Drawing.Color.White;
            this.rtxNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rtxNomeCompleto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtxNomeCompleto.Location = new System.Drawing.Point(17, 145);
            this.rtxNomeCompleto.Mask = "";
            this.rtxNomeCompleto.Name = "rtxNomeCompleto";
            this.rtxNomeCompleto.Padding = new System.Windows.Forms.Padding(10);
            this.rtxNomeCompleto.Size = new System.Drawing.Size(200, 30);
            this.rtxNomeCompleto.TabIndex = 12;
            this.rtxNomeCompleto.TextValue = "";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.White;
            this.lblCelular.Location = new System.Drawing.Point(14, 236);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(49, 16);
            this.lblCelular.TabIndex = 11;
            this.lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(21, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.White;
            this.lblNomeCompleto.Location = new System.Drawing.Point(21, 124);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(103, 16);
            this.lblNomeCompleto.TabIndex = 7;
            this.lblNomeCompleto.Text = "Nome completo";
            // 
            // lblCadastroApp
            // 
            this.lblCadastroApp.AutoSize = true;
            this.lblCadastroApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroApp.ForeColor = System.Drawing.Color.White;
            this.lblCadastroApp.Location = new System.Drawing.Point(75, 98);
            this.lblCadastroApp.Name = "lblCadastroApp";
            this.lblCadastroApp.Size = new System.Drawing.Size(90, 16);
            this.lblCadastroApp.TabIndex = 1;
            this.lblCadastroApp.Text = "Cadastro App";
            // 
            // rtbSenha
            // 
            this.rtbSenha.BackColor = System.Drawing.Color.White;
            this.rtbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.rtbSenha.Location = new System.Drawing.Point(15, 310);
            this.rtbSenha.Mask = "";
            this.rtbSenha.Name = "rtbSenha";
            this.rtbSenha.Padding = new System.Windows.Forms.Padding(10);
            this.rtbSenha.Size = new System.Drawing.Size(200, 30);
            this.rtbSenha.TabIndex = 23;
            this.rtbSenha.TextValue = "";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(19, 291);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 16);
            this.lblSenha.TabIndex = 22;
            this.lblSenha.Text = "Senha";
            // 
            // InvenTrackRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 461);
            this.Controls.Add(this.rtbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.rbtVoltar);
            this.Controls.Add(this.rbtCadastrar);
            this.Controls.Add(this.rcbCargoAtual);
            this.Controls.Add(this.lblCargoAtual);
            this.Controls.Add(this.rtxDataNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.rtxCelular);
            this.Controls.Add(this.rtxEmail);
            this.Controls.Add(this.rtxNomeCompleto);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblCadastroApp);
            this.Controls.Add(this.pcbCadastroApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InvenTrackRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvenTrackRegister";
            this.Load += new System.EventHandler(this.InvenTrackRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadastroApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCadastroApp;
        private TransparentLabel lblCadastroApp;
        private TransparentLabel lblNomeCompleto;
        private TransparentLabel lblEmail;
        private TransparentLabel lblCelular;
        private RoundedMaskedTextBox rtxNomeCompleto;
        private RoundedMaskedTextBox rtxEmail;
        private RoundedMaskedTextBox rtxCelular;
        private TransparentLabel lblDataNascimento;
        private RoundedMaskedTextBox rtxDataNascimento;
        private TransparentLabel lblCargoAtual;
        private RoundedComboBox rcbCargoAtual;
        private RoundedButton rbtCadastrar;
        private RoundedButton rbtVoltar;
        private RoundedMaskedTextBox rtbSenha;
        private TransparentLabel lblSenha;
    }
}