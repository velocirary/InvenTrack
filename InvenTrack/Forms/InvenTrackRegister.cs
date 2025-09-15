using InvenTrack.Entities;
using InvenTrack.Helpers;
using System;
using System.Windows.Forms;

namespace InvenTrack.Forms
{
    public partial class InvenTrackRegister : Form
    {
        public InvenTrackRegister()
        {
            InitializeComponent();
        }

        private void rbtCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeCompleto = rtxNomeCompleto.TextValue;
                string email = rtxEmail.TextValue;
                string celular = rtxCelular.TextValue;

                var cargoSelecionado = ((Cargo)rcbCargoAtual.SelectedItem).Nome;                

                var senhaHash = CriptografiaHelper.GerarHash(rtbSenha.TextValue);

                string dataNascimentoTexto = rtxDataNascimento.TextValue;
                DateTime dataNascimento;

                if (!DateTime.TryParse(dataNascimentoTexto, out dataNascimento))
                {
                    MessageBox.Show("Data de nascimento inválida.");
                    return;
                }

                Usuario novoUsuario = new Usuario(
                    id: Guid.NewGuid(),
                    nomeCompleto: nomeCompleto,
                    email: email,
                    celular: celular,
                    dataNascimento: dataNascimento,
                    cargoAtual: cargoSelecionado,
                    senhaHash: senhaHash
                );                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}");
            }
        }

        private void rbtVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                var loginForm = new InvenTrackLogin();
                loginForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir tela de login. Detalhes: {ex.Message}");
            }
        }

        private void InvenTrackRegister_Load(object sender, EventArgs e)
        {
            try
            {
                var cargoRepository = new CargoRepository();
                var listaDeCargos = cargoRepository.ListarTodos();
                rcbCargoAtual.DataSource = listaDeCargos;
                rcbCargoAtual.DisplayMember = "Nome";
                rcbCargoAtual.ValueMember = "Id";
                rcbCargoAtual.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cargos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
