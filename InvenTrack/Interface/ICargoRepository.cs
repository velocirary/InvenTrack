using System;
using System.Collections.Generic;
using InvenTrack.Entities;

public interface ICargoRepository
{
    List<Cargo> ListarTodos();
}