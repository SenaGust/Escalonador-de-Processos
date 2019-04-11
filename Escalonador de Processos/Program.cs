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

            escalonador.Run();

            //Fim
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
