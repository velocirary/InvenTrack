namespace InvenTrack.Forms
{
    partial class InvenTrackHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvenTrackHome));
            this.lblOla = new TransparentLabel();
            this.lblBemVindo = new TransparentLabel();
            this.lblNomeExibicao = new TransparentLabel();
            this.lblValorUsuario = new TransparentLabel();
            this.lblCodigoCadastro = new TransparentLabel();
            this.lblLocalizacao = new TransparentLabel();
            this.pcbHomeApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHomeApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOla
            // 
            this.lblOla.AutoSize = true;
            this.lblOla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOla.Location = new System.Drawing.Point(48, 36);
            this.lblOla.Name = "lblOla";
            this.lblOla.Size = new System.Drawing.Size(37, 20);
            this.lblOla.TabIndex = 3;
            this.lblOla.Text = "Olá,";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBemVindo.Location = new System.Drawing.Point(48, 57);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(83, 20);
            this.lblBemVindo.TabIndex = 4;
            this.lblBemVindo.Text = "Bem vindo";
            // 
            // lblNomeExibicao
            // 
            this.lblNomeExibicao.AutoSize = true;
            this.lblNomeExibicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.lblNomeExibicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeExibicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.lblNomeExibicao.Location = new System.Drawing.Point(84, 149);
            this.lblNomeExibicao.Name = "lblNomeExibicao";
            this.lblNomeExibicao.Size = new System.Drawing.Size(110, 20);
            this.lblNomeExibicao.TabIndex = 5;
            this.lblNomeExibicao.Text = "Nome Usuário";
            // 
            // lblValorUsuario
            // 
            this.lblValorUsuario.AutoSize = true;
            this.lblValorUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.lblValorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValorUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.lblValorUsuario.Location = new System.Drawing.Point(92, 197);
            this.lblValorUsuario.Name = "lblValorUsuario";
            this.lblValorUsuario.Size = new System.Drawing.Size(87, 20);
            this.lblValorUsuario.TabIndex = 6;
            this.lblValorUsuario.Text = "R$ 8.00,00";
            // 
            // lblCodigoCadastro
            // 
            this.lblCodigoCadastro.AutoSize = true;
            this.lblCodigoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.lblCodigoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCodigoCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.lblCodigoCadastro.Location = new System.Drawing.Point(91, 304);
            this.lblCodigoCadastro.Name = "lblCodigoCadastro";
            this.lblCodigoCadastro.Size = new System.Drawing.Size(91, 20);
            this.lblCodigoCadastro.TabIndex = 7;
            this.lblCodigoCadastro.Text = "EGB8712C";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.lblLocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocalizacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(157)))), ((int)(((byte)(237)))));
            this.lblLocalizacao.Location = new System.Drawing.Point(82, 361);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(122, 20);
            this.lblLocalizacao.TabIndex = 8;
            this.lblLocalizacao.Text = "Cidade, Estado.";
            // 
            // pcbHomeApp
            // 
            this.pcbHomeApp.Image = ((System.Drawing.Image)(resources.GetObject("pcbHomeApp.Image")));
            this.pcbHomeApp.Location = new System.Drawing.Point(-3, -2);
            this.pcbHomeApp.Name = "pcbHomeApp";
            this.pcbHomeApp.Size = new System.Drawing.Size(256, 539);
            this.pcbHomeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHomeApp.TabIndex = 0;
            this.pcbHomeApp.TabStop = false;
            // 
            // InvenTrackHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(831, 508);
            this.ControlBox = false;
            this.Controls.Add(this.lblLocalizacao);
            this.Controls.Add(this.lblCodigoCadastro);
            this.Controls.Add(this.lblValorUsuario);
            this.Controls.Add(this.lblNomeExibicao);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.lblOla);
            this.Controls.Add(this.pcbHomeApp);
            this.Name = "InvenTrackHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvenTrackForm";            
            ((System.ComponentModel.ISupportInitialize)(this.pcbHomeApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbHomeApp;
        private TransparentLabel lblOla;
        private TransparentLabel lblBemVindo;
        private TransparentLabel lblNomeExibicao;
        private TransparentLabel lblValorUsuario;
        private TransparentLabel lblCodigoCadastro;
        private TransparentLabel lblLocalizacao;
    }
}

