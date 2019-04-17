using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador_de_Processos
{
    class Escalonador
    {
        public ListaCircular[] Todos { get; set; }
        public int TempoTotal { get; set; }

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

        public void AdicionarProcesso()
        {
            
        }

        public bool Vazio()
        {
            return Todos[0].Vazia() && Todos[1].Vazia() && Todos[2].Vazia() && Todos[3].Vazia() && Todos[4].Vazia() && Todos[5].Vazia() && Todos[6].Vazia() && Todos[7].Vazia() && Todos[8].Vazia() && Todos[9].Vazia();
        }
    }
}
