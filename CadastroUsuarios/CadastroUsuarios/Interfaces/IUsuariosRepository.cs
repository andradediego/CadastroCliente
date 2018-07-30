using System;
using System.Collections.Generic;
using System.Linq;
using CadastroUsuarios.Entities;

namespace CadastroUsuarios.Interfaces
{
    public interface IUsuariosRepository
    {
        void Adicionar(Usuarios item);
        void Deletar(Guid id);
        IQueryable<Usuarios> RecuperarTodos();
        Usuarios SelecionarSimples(Guid id);
        Usuarios Selecionar(string nome, string cpf);
        bool SalvarAtualizacoes();
        void Atualizar(Usuarios usuario);
    }
}