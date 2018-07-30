using CadastroUsuarios.Entities;
using CadastroUsuarios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarios.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private AppDbContext _context;

        public UsuariosRepository(AppDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Usuarios> RecuperarTodos()
        {
            return this._context.Usuarios;
        }

        public Usuarios SelecionarSimples(Guid id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public Usuarios Selecionar(string nome, string cpf)
        {
            return _context.Usuarios.FirstOrDefault(x => 
              x.Nome.Contains(nome) || x.CPF.Contains(cpf)
            );
        }

        public void Adicionar(Usuarios item)
        {
            this._context.Usuarios.Add(item);
        }

        public void Deletar(Guid id)
        {
            Usuarios usuario = SelecionarSimples(id);
            this._context.Usuarios.Remove(usuario);
        }

        public void Atualizar(Usuarios usuario)
        {
            this._context.Usuarios.Update(usuario);
        }

        public bool SalvarAtualizacoes()
        {
            return this._context.SaveChanges() >= 0;
        }
    }
}
