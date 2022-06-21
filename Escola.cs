using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_13_recursos_de_colecao
{
    internal class Escola
    {
        public Dictionary<int, Alunos> Matriculados = new Dictionary<int, Alunos>();



        public object Cadastrar(int matricula, string nome, string sobrenome, string telefone)
        {
            Alunos novoAluno = new Alunos();
            novoAluno.Nome = nome;
            novoAluno.Matricula = matricula;
            novoAluno.Sobrenome = sobrenome;
            novoAluno.Telefone = telefone;
            Matriculados.Add(matricula, novoAluno);
            return novoAluno;

        }

        public void Lista()
        {
            foreach(var matricula in Matriculados)
            {
                Console.WriteLine($"{matricula}");
            }
        }


}
}
