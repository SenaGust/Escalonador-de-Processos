using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Escalonador_de_Processos
{
    class Escalonador
    {
        #region Atributos
        public IEstruturaDados[] Todos { get; private set; }
        public int TempoTotal { get; private set; }
        public int Quantum { get; set; }
        #endregion

        #region Construtor
        public Escalonador()
        {
            //Instanciando todas as listas
            this.Todos = new Fila[10];
            for (int pos = 0; pos < Todos.Length; pos++)
            {
                Todos[pos] = new Fila();
            }

            //Definindo outros atributos
            this.TempoTotal = 0;
        }   
        #endregion

        #region Métodos
        public void Run(int quantum)
        {
            this.Quantum = quantum;

            for (int pos = 0; pos < Todos.Length; pos++)
            {
                Console.WriteLine("\t\tProcessando Lista de Processos com Prioridade " + (pos + 1));

                while (!Todos[pos].Vazia())
                {
                    Processos processo = (Processos)(Todos[pos].Retirar());
                    Console.WriteLine("Processando: " + processo.ToString());
                    if(Processar(processo) > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Processo Finalizado");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        AdicionarProcesso(processo);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Processo não Finalizado");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine("\n" + Todos[pos].ToString());
                }

            }

            Console.WriteLine("\nO total de ciclos utilizado pelos processos é de " + this.TempoTotal);
        }

        public int Processar(Processos processo)
        {
            int quantidadeTempo = processo.QtdeCiclos - this.Quantum;
            int tempoTotalQuantum = this.Quantum * 500;

            if (quantidadeTempo == 0)
            {
                //processo finalizado -> retirar o processo da fila
                processo.DiminuirQtdeCiclos(this.Quantum); 
                Thread.Sleep(tempoTotalQuantum); //
                TempoTotal += Quantum;

                return 1;
            }
            else if(quantidadeTempo < 0)
            {
                //processo finalizado antes do tempo -> retirar o processo da fila
                processo.DiminuirQtdeCiclos(processo.QtdeCiclos);
                tempoTotalQuantum *= processo.QtdeCiclos / this.Quantum; //redefinição do quantum gasto
                Thread.Sleep(tempoTotalQuantum);
                TempoTotal += processo.QtdeCiclos;

                return 1;
            }
            else//quantidade > 0
            {
                //processo não finalizou -> Continua na fila

                processo.DiminuirQtdeCiclos(this.Quantum);
                Thread.Sleep(tempoTotalQuantum);
                TempoTotal += Quantum;

                //mudar Prioridade??? ----> retirar da lista, mudar a prioridade e adicionar ao escalonador
                processo.DiminuirPrioridade();

                return -1;
            }
        }

        public void AdicionarProcesso(Processos processo)
        {
            switch (processo.Prioridade)
            {
                case 1: Todos[0].Inserir(processo); break;
                case 2: Todos[1].Inserir(processo); break;
                case 3: Todos[2].Inserir(processo); break;
                case 4: Todos[3].Inserir(processo); break;
                case 5: Todos[4].Inserir(processo); break;
                case 6: Todos[5].Inserir(processo); break;
                case 7: Todos[6].Inserir(processo); break;
                case 8: Todos[7].Inserir(processo); break;
                case 9: Todos[8].Inserir(processo); break;
                case 10: Todos[9].Inserir(processo); break;
                default: break;
            }
        }

        public bool Vazio()
        {
            return Todos[0].Vazia() && Todos[1].Vazia() && Todos[2].Vazia() && Todos[3].Vazia() && Todos[4].Vazia() && Todos[5].Vazia() && Todos[6].Vazia() && Todos[7].Vazia() && Todos[8].Vazia() && Todos[9].Vazia();
        }

        public override string ToString()
        {
            StringBuilder auxImpressao = new StringBuilder();

            for (int pos = 0; pos < Todos.Length; pos++)
            {
                auxImpressao.AppendLine("\tPrioridade " + (pos + 1));
                auxImpressao.AppendLine(Todos[pos].ToString());
            }

            return auxImpressao.ToString();
        }
        #endregion
    }
}
