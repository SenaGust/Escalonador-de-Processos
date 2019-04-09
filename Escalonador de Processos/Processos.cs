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
        static public int processID { get;set; }
        #endregion

        #region Construtor
        public Processos()
        {
            processID = Escalonador.GetID();
            Prioridade = 5;
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
