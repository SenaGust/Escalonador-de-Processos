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
            //testar();
            ProgramFinal();

            //Fim
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void testar()
        {
            ListaCircular listaCircular = new ListaCircular();

            Processos A = new Processos(1, "Primeiro", 1, 1);
            Processos B = new Processos(2, "Segundo", 1, 1);
            Processos C = new Processos(3, "Terceiro", 1, 1);
            Processos D = new Processos(4, "Quarto", 1, 1);
            Processos E = new Processos(5, "Quinto", 1, 1);
            Processos F = new Processos(6, "Sexto", 1, 1);

            listaCircular.Inserir(A);
            listaCircular.Inserir(B);
            listaCircular.Inserir(C);
            listaCircular.Inserir(D);
            listaCircular.Inserir(E);
            listaCircular.Inserir(F);

            Console.WriteLine("Antes de retirar");
            Console.WriteLine(listaCircular.ToString());

            while(!listaCircular.Vazia())
            {
                Console.WriteLine("Retirou: " + listaCircular.Retirar());
                Console.WriteLine("Retirou: " + listaCircular.Retirar());
                Console.WriteLine(listaCircular.ToString());
            }

            Console.WriteLine("Vazia");
            Console.WriteLine(listaCircular.ToString());
        }

        static void ProgramFinal()
        {
            string nomeArquivo = "teste.txt";
            Escalonador escalonador = Arquivo.LeituraArquivo(nomeArquivo);

            if (escalonador == null)
                Console.WriteLine("O arquivo {0} não existe.", nomeArquivo);
            else
            {
                Console.WriteLine(escalonador.ToString());
                escalonador.Run(10);
            }

            Console.WriteLine(escalonador.ToString());
        }
    }
} //teste
