using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador_de_Processos
{
    class Processos : IDado
    {
        #region Atributos
        public int Prioridade { get; set; }
        #endregion

        #region Construtor
        public Processos()
        {
            return;
        }
        #endregion

        #region Métodos

        #endregion

        #region Métodos Interface
        public override string ToString()
        {
            return "Implementar";
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("Falta Implementar");
            return false;
        }
        #endregion
    }
}
