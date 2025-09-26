using InvenTrack.Entities;
using LiteDB;
using System.Collections.Generic;
using System.Linq;

public class CargoRepository : ICargoRepository
{
    private const string DatabasePath = @"InvenTrack.db";
    private const string ColecaoCargos = "cargo";

    public static void InicializarCargos()
    {
        using var dbLite = new LiteDatabase(DatabasePath);
        var cargos = dbLite.GetCollection<Cargo>(ColecaoCargos);

        if (!cargos.FindAll().Any())
        {
            var lista = new List<Cargo>
        {
            new Cargo { Nome = "Administrador" },
            new Cargo { Nome = "Estoquista" },
            new Cargo { Nome = "Financeiro" },
            new Cargo { Nome = "Gerente" },
            new Cargo { Nome = "Vendedor" }
        };

            cargos.InsertBulk(lista);
        }
    }

    public List<Cargo> ListarTodos()
    {
        using var db = new LiteDatabase(DatabasePath);
        var cargos = db.GetCollection<Cargo>(ColecaoCargos);
        return cargos.FindAll().ToList();
    }
}