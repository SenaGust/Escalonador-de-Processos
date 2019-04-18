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
            testar();

            string nomeArquivo = "teste.txt";
            Escalonador escalonador = Arquivo.LeituraArquivo(nomeArquivo);

            if (escalonador == null)
                Console.WriteLine("O arquivo {0} não existe.", nomeArquivo);
            else
            {
                Console.WriteLine(escalonador.ToString());
                escalonador.Run();
            }

            Console.WriteLine(escalonador.ToString());

            //Fim
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
} //teste
