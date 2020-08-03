using Arquitetura.Domain;
using Arquitetura.Interface;
using Arquitetura.Repository;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Arquitetura.Service
{
    class AlunoService
    {
        public IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public List<Aluno> Lista()
        {
            

            var alunos = _alunoRepository.Lista();

            foreach (var aluno in alunos)
            {
                aluno.Idade = CalculateAge(aluno.DataNascimento);
            }

            return alunos;
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;
            return age;
        }
    }

}