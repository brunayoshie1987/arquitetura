using Arquitetura.Domain;
using Arquitetura.Repository;
using Arquitetura.Service;
using System;

namespace Arquitetura
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoService alunoService = new AlunoService(new AlunoRepository());

            var alunos = alunoService.Lista();

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Alunos: {aluno.Nome} ::: Matricula: {aluno.Matricula} ::: {aluno.Idade}");
            }

            SalaService salaService = new SalaService();
            MateriaService materiaService = new MateriaService();
        }
    }
}
