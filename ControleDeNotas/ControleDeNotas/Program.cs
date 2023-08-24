using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeNotas
{
    public class Program
    {
        public class Aluno
        {
            public string Nome { get; set; }
            public int Nota { get; set; }
        }



        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[10];
            alunos[0] = new Aluno { Nome = "João", Nota = 8 };
            alunos[1] = new Aluno { Nome = "Bill", Nota = 5 };
            alunos[2] = new Aluno { Nome = "Arthur", Nota = 2 };
            alunos[3] = new Aluno { Nome = "José", Nota = 10 };
            alunos[4] = new Aluno { Nome = "Gustavo", Nota = 3 };
            alunos[5] = new Aluno { Nome = "Guilherme", Nota = 4 };
            alunos[6] = new Aluno { Nome = "Pascoal", Nota = 6 };
            alunos[7] = new Aluno { Nome = "Otávio", Nota = 9 };
            alunos[8] = new Aluno { Nome = "Bruna", Nota = 10 };
            alunos[9] = new Aluno { Nome = "Roberta", Nota = 7 };


            var alunosAprovados = new List<Aluno> {};
            var alunosReprovados = new List<Aluno> {};


            foreach (var aluno in alunos)
            {
                if (aluno.Nota >= 6)
                {
                    alunosAprovados.Add(aluno);
                }
                else
                {
                    alunosReprovados.Add(aluno);
                }
            }

            Console.WriteLine("Qual lista de alunos você deseja consultar?");
            Console.WriteLine("Digite '1' para Aprovados ou '2' para Reprovados");
            
            string resposta = Console.ReadLine();
            if (resposta == "1")
            {
                Console.WriteLine("Alunos Aprovados:");
                foreach (var aluno in alunosAprovados)
                {
                    Console.WriteLine(aluno.Nome);
                }
            }

            if (resposta == "2")
            {
                Console.WriteLine("Alunos Reprovados:");
                foreach (var aluno in alunosReprovados)
                {
                    Console.WriteLine(aluno.Nome);
                }
            }

            Console.WriteLine("Pressione 'ENTER' para finalizar a consulta");
            Console.ReadLine(); 
            
        }


    }   
}
