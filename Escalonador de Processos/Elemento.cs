using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador_de_Processos
{
    class Elemento
    {
        public IDado MeuDado { get; set; }
        public Elemento Proximo { get; set; }

        public Elemento(IDado dado)
        {
            this.MeuDado = dado;
        }
    }
}
