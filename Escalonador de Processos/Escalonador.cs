using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador_de_Processos
{
    class Escalonador
    {
        public ListaCircular[] Todos { get; private set; }
        public int TempoTotal { get; private set; }

        public Escalonador()
        {
            this.Todos = new ListaCircular[10];
            for (int pos = 0; pos < Todos.Length; pos++)
            {
                Todos[pos] = new ListaCircular();
            }
            this.TempoTotal = 0;
        }

        public void Run()
        {
            for (int pos = 0; pos < Todos.Length; pos++)
                while(!Todos[pos].Vazia())
                    Todos[pos].Retirar();
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
                auxImpressao.AppendLine("\tPrioridade " + pos);
                auxImpressao.AppendLine(Todos[pos].ToString());
            }

            return auxImpressao.ToString();
        }
    }
}
