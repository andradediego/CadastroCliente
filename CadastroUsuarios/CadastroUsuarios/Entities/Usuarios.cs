using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarios.Entities
{
    public class Usuarios
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
    }
}
