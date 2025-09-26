using InvenTrack.Configuration;
using InvenTrack.Repositories;
using System;
using System.Net;
using System.Net.Mail;

public class RecuperacaoSenhaService
{
    private readonly RecuperacaoSenhaRepository _repo = new RecuperacaoSenhaRepository();
    private readonly Config _config;

    public RecuperacaoSenhaService()
    {
        _config = Config.Load();
    }

    public void EnviarCodigoEmail(string emailDestino)
    {
        var codigo = GerarCodigo();
        _repo.SalvarCodigo(emailDestino, codigo);

        MailAddress remetente = new MailAddress(_config.SmtpEmail, "InvenTrack");
        MailAddress destinatario = new MailAddress(emailDestino);

        string assunto = "Recuperação de senha - InvenTrack";
        string corpo = $@"
                    <html>
                      <body style='font-family: Arial, sans-serif; color: #333;'>
                        <div style='max-width: 500px; margin: auto; padding: 20px; border: 1px solid #ddd; border-radius: 8px; background-color: #f9f9f9;'>
                          <h2 style='color: #2c3e50;'>Recuperação de Senha - InvenTrack</h2>
                          <p>Olá,</p>
                          <p>Recebemos uma solicitação para redefinir sua senha. Use o código abaixo para continuar:</p>
                          <p style='font-size: 20px; font-weight: bold; color: #BC9DED; text-align: center; margin: 20px 0;'>{codigo}</p>
                          <p>Este código expira em <strong>10 minutos</strong>.</p>
                          <p><i>Se você não solicitou a recuperação, pode ignorar este e-mail com segurança.</i></p>
                          <br>
                          <p>Atenciosamente,<br><strong>Equipe InvenTrack</strong></p>
                        </div>
                      </body>
                    </html>";

        var smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(remetente.Address, _config.SmtpPassword)
        };

        using (var mensagem = new MailMessage(remetente, destinatario)
        {
            Subject = assunto,
            Body = corpo,
            IsBodyHtml = true
        })
        {
            smtp.Send(mensagem);
        }
    }

    private string GerarCodigo()
    {
        var random = new Random();
        return random.Next(100000, 999999).ToString();
    }

    public bool ValidarCodigo(string email, string codigoDigitado)
    {
        return _repo.ValidarCodigo(email, codigoDigitado);
    }
}
