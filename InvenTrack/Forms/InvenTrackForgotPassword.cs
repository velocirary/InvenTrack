using InvenTrack.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InvenTrack.Forms
{
    public partial class InvenTrackForgotPassword : Form
    {
        public InvenTrackForgotPassword()
        {
            InitializeComponent();
        }

        private void rbtEnviarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                string email = rtbEmailLogin.TextValue;

                if (string.IsNullOrEmpty(email)){
                    MessageBox.Show("Digite um e-mail para prosseguir.", "Falha na recuperação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsuarioRepository usuarioRepo = new UsuarioRepository();
                if (!usuarioRepo.UsuarioExiste(email))
                {
                    MessageBox.Show("E-mail não cadastrado no sistema.", "Falha na recuperação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ControlaVisibilidadeComponentes();

                RecuperacaoSenhaService service = new RecuperacaoSenhaService();
                service.EnviarCodigoEmail(email);

                MessageBox.Show("Código enviado! Verifique seu e-mail.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar código. Detalhes: {ex.Message}");
            }
        }

        private void ControlaVisibilidadeComponentes()
        {
            lblCodigo.Visible = true;
            rtxtCodigoVerificacao.Visible = true;            
            rtbEmailLogin.Enabled = false;
            rtbEmailLogin.BackColor = SystemColors.Control;
            rbtEnviarCodigo.Visible = false;
            rbtnConfirmarCodigo.Visible = true;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            try
            {
                InvenTrackLogin loginForm = new InvenTrackLogin();
                loginForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir tela de login. Detalhes: {ex.Message}");
            }
        }

        private void rbtnConfirmarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                string email = rtbEmailLogin.TextValue;
                string codigoDigitado = rtxtCodigoVerificacao.TextValue;

                if (string.IsNullOrEmpty(codigoDigitado))
                {
                    MessageBox.Show("Digite o código enviado por e-mail.", "Falha na recuperação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RecuperacaoSenhaService service = new RecuperacaoSenhaService();
                bool valido = service.ValidarCodigo(email, codigoDigitado);

                if (valido)
                {
                    MessageBox.Show("Código válido! Agora você pode redefinir sua senha.");
                    ControlaVisibilidadeComponentesNovaSenha();
                }

                else
                    MessageBox.Show("Código inválido ou expirado.", "Falha na validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao validar código. Detalhes: {ex.Message}");
            }
        }

        private void ControlaVisibilidadeComponentesNovaSenha()
        {
            lblCodigo.Text = "Nova Senha";
            rbtnConfirmarCodigo.Visible = false;
            rbtnNovaSenha.Visible = true;
            rtxtNovaSenha.Visible = true;
            rtxtCodigoVerificacao.Visible = false;
        }

        private void rbtnNovaSenha_Click(object sender, EventArgs e)
        {
            try
            {
                string email = rtbEmailLogin.TextValue;
                string novaSenha = rtxtNovaSenha.TextValue;

                if (string.IsNullOrEmpty(novaSenha))
                {
                    MessageBox.Show("Digite uma nova senha.", "Falha na redefinição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                string novaSenhaHash = CriptografiaHelper.GerarHash(novaSenha);

                UsuarioRepository repo = new UsuarioRepository();
                bool sucesso = repo.AtualizarSenha(email, novaSenhaHash);

                if (sucesso)
                {
                    MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else                
                    MessageBox.Show("Erro ao atualizar a senha. Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar senha. Detalhes: {ex.Message}");
            }
        }

    }
}
