using InvenTrack.Entities;
using System;
using System.Windows.Forms;

namespace InvenTrack.Forms
{
    public partial class InvenTrackHome : Form
    {
        public InvenTrackHome(Usuario usuarioLogado)
        {
            InitializeComponent();
            AoCarregarFormulario(usuarioLogado);
        }

        private void AoCarregarFormulario(Usuario usuarioLogado)
        {
            try
            {
                lblBemVindo.Text = "Bem-vindo " + usuarioLogado.NomeCompleto.Split(' ')[0];
                lblNomeExibicao.Text = usuarioLogado.NomeCompleto;
                lblValorUsuario.Text = "";
                lblCodigoCadastro.Text = "";
                lblLocalizacao.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar formulário. Detalhes: {ex.Message}");
            }
        }
    }
}
