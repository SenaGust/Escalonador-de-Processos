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
        public int PID { get; private set; }
        public string Nome { get; set; }
        public int Prioridade { get; private set; }
        public int QtdeCiclos { get; set; }
        public int TempoCPU { get; set; } //Talvez
        #endregion

        #region Construtor
        public Processos(int PID, string nome, int prioridade, int qtdeCiclos, int TempoCPU)
        {
            this.PID = PID;
            this.Nome = nome;
            this.Prioridade = prioridade;
            this.QtdeCiclos = qtdeCiclos;
            this.TempoCPU = TempoCPU;
        }
        #endregion

        #region Métodos
        public void DiminuirPrioridade()
        {

        }
        public void AumentarPrioridade()
        {

        }
        #endregion

        #region Métodos Interface
        public override string ToString()
        {
            return "Falta Implementar";
        }
        #endregion
    }
}
