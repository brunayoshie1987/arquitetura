using System;
using System.Collections.Generic;
using System.Text;

namespace Arquitetura.Domain
{
    class Aluno
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento {get;set;}
        public string Matricula { get; set; }

        public int Idade { get; set; }
    }
}
