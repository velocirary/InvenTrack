using LiteDB;
using InvenTrack.Entities;
using System;
using System.Linq;

namespace InvenTrack.Repositories
{
    public class RecuperacaoSenhaRepository
    {
        private readonly string _dbPath = @"InvenTrack.db";
        
        public void SalvarCodigo(string email, string codigo)
        {
            using (var db = new LiteDatabase(_dbPath))
            {
                var col = db.GetCollection<RecuperacaoSenha>("RecuperacaoSenha");
                
                var antigos = col.Find(x => x.Email == email && !x.Usado);
                foreach (var item in antigos)
                {
                    item.Usado = true;
                    col.Update(item);
                }

                var novo = new RecuperacaoSenha
                {
                    Email = email,
                    Codigo = codigo,
                    ExpiraEm = DateTime.Now.AddMinutes(10),
                    Usado = false
                };

                col.Insert(novo);
            }
        }

        public bool ValidarCodigo(string email, string codigo)
        {
            using (var db = new LiteDatabase(_dbPath))
            {
                var col = db.GetCollection<RecuperacaoSenha>("RecuperacaoSenha");

                var registro = col.Find(x => x.Email == email && x.Codigo == codigo && !x.Usado)
                                  .FirstOrDefault();

                if (registro == null) 
                    return false;

                if (registro.ExpiraEm < DateTime.Now) 
                    return false;

                registro.Usado = true;
                col.Update(registro);

                return true;
            }
        }
    }
}
