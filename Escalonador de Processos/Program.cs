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
        static void testar()
        {
            Processos processos1 = new Processos(1, "gugu", 1 , 1);
            Processos processos2 = new Processos(2, "luna", 1 , 2);
            Processos processos3 = new Processos(3, "julinha", 1 , 3);
            Processos processos4 = new Processos(4, "tavinho", 1 , 4);
            Processos processos5 = new Processos(5, "Alice", 1 , 5);

            ListaCircular escalonador = new ListaCircular();

            escalonador.Inserir(processos1);
            escalonador.Inserir(processos2);
            escalonador.Inserir(processos3);
            escalonador.Inserir(processos4);
            escalonador.Inserir(processos5);

            Console.WriteLine(escalonador.ToString());

        }
    }
} //teste
