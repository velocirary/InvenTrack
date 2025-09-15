using LiteDB;
using System;
using System.Text.RegularExpressions;

namespace InvenTrack.Entities
{
    public class Cargo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public Cargo() { }

        [BsonCtor]
        public Cargo(
            Guid id,
            string nome)
        {
            Id = id;
            Nome = nome;            
        }
    }
}
