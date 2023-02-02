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