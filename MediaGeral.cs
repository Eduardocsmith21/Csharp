using System;

namespace MediaGeralPoo
{
    class MediaGeral
    {
        public static void Main (String [] args)
        {
            Console.Title = "### Média dos Alunos ###";

            Console.Write("Informe quantos alunos: ");
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
                Console.WriteLine("Media: " + alunos.Media);
                Console.WriteLine();

                MediaGeral += alunos.Media;
            }
            double resultadoFinal = MediaGeral / aluno.Length;
            Console.WriteLine("Media geral dos alunos " + resultadoFinal);
            Console.ReadKey();
        }
    }
}