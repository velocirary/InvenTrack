using InvenTrack.Entities;
using InvenTrack.Helpers;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;

public class UsuarioRepository : IUsuarioRepository
{
    private const string DatabasePath = @"InvenTrack.db";
    private const string ColecaoUsuarios = "usuarios";

    public static void InicializarBanco()
    {
        using var db = new LiteDatabase(DatabasePath);
        var usuarios = db.GetCollection<Usuario>("usuarios");

        string emailAdm = "admin1@inventrack.com";

        if (!usuarios.Exists(u => u.Email == emailAdm))        
            usuarios.Insert(CriarUsuarioAdminstrador(emailAdm));
    }

    private static Usuario CriarUsuarioAdminstrador(string emailAdm)
    {        
        var senhaHash = CriptografiaHelper.GerarHash("admin123");

        return new Usuario
        {
            Id = Guid.NewGuid(),
            NomeCompleto = "Admin",
            Email = emailAdm,
            Celular = "11999999999",
            DataNascimento = new DateTime(1990, 1, 1),
            CargoAtual = "Administrador",
            SenhaHash = CriptografiaHelper.GerarHash(senhaHash)
        };
    }

    public Usuario BuscarUsuarioLogin(string email, string senhaHash)
    {
        using var dbLite = new LiteDatabase(DatabasePath);
        var usuarios = dbLite.GetCollection<Usuario>(ColecaoUsuarios);

        return usuarios.FindOne(u => u.Email == email && u.SenhaHash == senhaHash);
    }

    public void Inserir(Usuario usuario)
    {
        using var dbLite = new LiteDatabase(DatabasePath);
        var colecao = dbLite.GetCollection<Usuario>(ColecaoUsuarios);
        colecao.Insert(usuario);
    }

    public List<Usuario> ListarTodos()
    {
        using var dbLite = new LiteDatabase(DatabasePath);
        var colecao = dbLite.GetCollection<Usuario>(ColecaoUsuarios);
        return colecao.FindAll().ToList();
    }

    public bool UsuarioExiste(string email)
    {
        throw new NotImplementedException();
    }
}