using InvenTrack.Helpers;
using System;
using System.Windows.Forms;

namespace InvenTrack.Forms
{
    public partial class InvenTrackLogin : Form
    {
        public InvenTrackLogin()
        {
            InitializeComponent();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                InvenTrackForgotPassword forgotPasswordForm = new InvenTrackForgotPassword();
                forgotPasswordForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir tela de registro. Detalhes: {ex.Message}");
            }
        }

        private void lblDontHaveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                InvenTrackRegister registerForm = new InvenTrackRegister();
                registerForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir tela de registro. Detalhes: {ex.Message}");
            }
        }

        private async void rbtLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = rtbEmailLogin.TextValue;
                string senhaHash = CriptografiaHelper.GerarHash(rtbPasswordLogin.TextValue);

                rbtLogin.Enabled = false;

                UsuarioRepository usuarioRepo = new UsuarioRepository();
                var usuarioLogado = usuarioRepo.BuscarUsuarioLogin(email, senhaHash);

                if (usuarioLogado is null)
                {
                    MessageBox.Show("Email ou senha inválidos.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Bem-vindo, {usuarioLogado.NomeCompleto}!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InvenTrackHome home = new InvenTrackHome(usuarioLogado);
                home.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"\"Erro ao realizar login. Detalhes:: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            finally
            {                
                rbtLogin.Enabled = true;
            }
        }
    }
}