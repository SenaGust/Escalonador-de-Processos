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

        public void AdicionarProcesso(string [] info)
        {
            IDado novo;
            novo = new Processos(Convert.ToInt32(info[0]), info[1], Convert.ToInt32(info[2]), Convert.ToInt32(info[3]));

            switch (info[2])
            {
                case "1": Todos[0].Inserir(novo); break;
                case "2": Todos[1].Inserir(novo); break;
                case "3": Todos[2].Inserir(novo); break;
                case "4": Todos[3].Inserir(novo); break;
                case "5": Todos[4].Inserir(novo); break;
                case "6": Todos[5].Inserir(novo); break;
                case "7": Todos[6].Inserir(novo); break;
                case "8": Todos[7].Inserir(novo); break;
                case "9": Todos[8].Inserir(novo); break;
                case "10": Todos[9].Inserir(novo); break;
            }
        }

        public bool Vazio()
        {
            return Todos[0].Vazia() && Todos[1].Vazia() && Todos[2].Vazia() && Todos[3].Vazia() && Todos[4].Vazia() && Todos[5].Vazia() && Todos[6].Vazia() && Todos[7].Vazia() && Todos[8].Vazia() && Todos[9].Vazia();
        }
    }
}
