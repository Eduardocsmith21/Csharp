using System;

namespace MediaGeralPoo
{
    class MediaGeral
    {
        public static void Main (String [] args)
        {
            Console.Title = "### Média dos Alunos ###";

            Console.Write("Informe a quantidade de alunos: ");
            int nAluos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno [] aluno = new Aluno[nAluos];

            for(int i = 0; i < aluno.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno #" + (i+1) + "Nome...: ");
                string nome = Console.ReadLine();
                Console.Write("Aluno #" + (i+1) + "Prova:");
                int provas = int.Parse(Console.ReadLine());

                aluno[i] = new Aluno(nome, provas);

                Console.WriteLine("Insira as notas do aluno "+ nome);
                aluno[i].InserirNotas();

            }
            Console.Clear();
            
            double MediaGeral = 0;
            foreach(Aluno alunos in aluno)
            {
                Console.WriteLine("Aluno: " + alunos.Nome);
                Console.WriteLine("Média: " + alunos.Media);
                Console.WriteLine();

                MediaGeral += alunos.Media;
            }
            double resultadoFinal = MediaGeral / aluno.Length;
            Console.WriteLine("Média geral dos alunos " + resultadoFinal);
            Console.ReadKey();
        }
    }
}
using System;

namespace MediaGeralPoo
{
    class Aluno
    {
        public String Nome {get; private set;}
        private double [] _Notas;
        public double Media 
        {
            get
            {
                return CalcularMedia();
            }
        }
        public Aluno (string nome, int provas)
        {
            Nome = nome;
            _Notas = new double[provas];
        }
        public void InserirNotas()
        {
            for(int i = 0; i < _Notas.Length; i++)
            {
                Console.Write("Nota #" + (i+1) + ":");
                _Notas[i] = double.Parse(Console.ReadLine());
            }
        }
        private double CalcularMedia()
        {
            double total = 0;
            for(int i = 0; i < _Notas.Length; i++)
            {
                total += _Notas[i];
            }
            return total / _Notas.Length;
        }
    }
}