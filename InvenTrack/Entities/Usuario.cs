using LiteDB;
using System;
using System.Text.RegularExpressions;

namespace InvenTrack.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CargoAtual { get; set; }
        public string SenhaHash { get; set; }

        public Usuario() { }

        [BsonCtor]
        public Usuario(
            Guid id,
            string nomeCompleto,
            string email,
            string celular,
            DateTime dataNascimento,
            string cargoAtual,
            string senhaHash)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Email = email;
            Celular = celular;
            DataNascimento = dataNascimento;
            CargoAtual = cargoAtual;
            SenhaHash = senhaHash;

            RealizaValidacoes();
        }

        public void RealizaValidacoes()
        {
            ValidarCamposObrigatorios();
            ValidarEmail();
            ValidarCelular();
        }

        private void ValidarCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(NomeCompleto))
                throw new ArgumentException("O campo NomeCompleto é obrigatório.");

            if (string.IsNullOrWhiteSpace(Email))
                throw new ArgumentException("O campo Email é obrigatório.");

            if (string.IsNullOrWhiteSpace(CargoAtual))
                throw new ArgumentException("O campo CargoAtual é obrigatório.");

            if (DataNascimento == default)
                throw new ArgumentException("O campo DataNascimento é obrigatório.");
        }

        private void ValidarEmail()
        {
            var emailRegex = new Regex(@"^[^@]+@[^@]+\.[^@]+$");
            if (!emailRegex.IsMatch(Email))
                throw new ArgumentException("O campo Email não possui um formato válido.");
        }

        private void ValidarCelular()
        {
            if (string.IsNullOrWhiteSpace(Celular))
                throw new ArgumentException("O campo Celular deve conter um número válido (ex.: +559899999999).");
        }
    }
}
