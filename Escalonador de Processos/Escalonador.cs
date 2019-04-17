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
            this.TempoTotal = 0;
        }

        public void Run()
        {

        }
    }
}
