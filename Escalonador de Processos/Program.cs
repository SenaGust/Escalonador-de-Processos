using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador_de_Processos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeArquivo = "teste.txt";
            Escalonador escalonador = Arquivo.LeituraArquivo(nomeArquivo);

            if (escalonador == null)
                Console.WriteLine("O arquivo {0} não existe.", nomeArquivo);
            else
            {
                Console.WriteLine(escalonador.Todos[0].ToString());
                Console.WriteLine(escalonador.Todos[1].ToString());
                Console.WriteLine(escalonador.Todos[2].ToString());
                Console.WriteLine(escalonador.Todos[3].ToString());
                Console.WriteLine(escalonador.Todos[4].ToString());
                Console.WriteLine(escalonador.Todos[5].ToString());
                Console.WriteLine(escalonador.Todos[6].ToString());
                Console.WriteLine(escalonador.Todos[7].ToString());
                Console.WriteLine(escalonador.Todos[8].ToString());
                Console.WriteLine(escalonador.Todos[9].ToString());
                escalonador.Run();
            }

            //Fim
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
} //teste
