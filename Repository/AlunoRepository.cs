using Arquitetura.Domain;
using Arquitetura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arquitetura.Repository
{
    class AlunoRepository: IAlunoRepository

    {
       public List<Aluno> Lista ()
        {
            List<Aluno> alunos = new List<Aluno>();

            Aluno aluno = new Aluno();

            aluno.Id = 1;
            aluno.Nome = "Bruna";
            aluno.DataNascimento = new DateTime(1987, 12, 02);
            aluno.Matricula = "ABC123";
            alunos.Add(aluno);

           
            aluno = new Aluno();
            aluno.Id = 2;
            aluno.Nome = "João";
            aluno.DataNascimento = new DateTime(1999, 02, 22);
            aluno.Matricula = "AB321";
            alunos.Add(aluno);

    
            aluno = new Aluno();
            aluno.Id = 3;
            aluno.Nome = "Maria";
            aluno.DataNascimento = new DateTime(2002, 08, 17);
            aluno.Matricula = "MAR765";
            alunos.Add(aluno);

            return alunos;

        }
    }
}
