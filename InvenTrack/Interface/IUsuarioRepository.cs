using System;
using System.Collections.Generic;
using InvenTrack.Entities;

public interface IUsuarioRepository
{
    void Inserir(Usuario usuario);
    List<Usuario> ListarTodos();
    Usuario BuscarUsuarioLogin(string email, string senhaHash);
    bool UsuarioExiste(string email);    
}