using System;

namespace Re
{
    class Recursividade
    {
        //Método Não recursivo
        public void Executar(string msg, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(msg);
            }
        }
        public void ExecutarRecursivo(string menssagem, int numero)
        {
            // Método Recursivo
            if (numero > 0)
            {
                Console.WriteLine(menssagem);
                ExecutarRecursivo(menssagem, numero - 1);
            }
        }
    }
}