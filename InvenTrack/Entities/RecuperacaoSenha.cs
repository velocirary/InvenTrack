using System;

namespace InvenTrack.Entities
{
    public class RecuperacaoSenha
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Codigo { get; set; }
        public DateTime ExpiraEm { get; set; }
        public bool Usado { get; set; }
    }
}