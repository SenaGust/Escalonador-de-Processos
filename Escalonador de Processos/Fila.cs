using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador_de_Processos
{
    class Fila : IEstruturaDados
    {
        #region Atributos
        public Elemento Primeiro { get; set; }
        public Elemento Ultimo { get; set; }
        #endregion

        #region Construtor
        public Fila()
        {
            this.Ultimo = this.Primeiro = new Elemento(null); //Criação do Sentinela
        }
        #endregion

        #region Métodos
        public void Inserir(IDado dado)
        {
            Ultimo = Ultimo.Proximo = new Elemento(dado);
        }
        public IDado Retirar()
        {
            if (Vazia())
                return null;

            Elemento auxRetirada = this.Primeiro.Proximo;
            this.Primeiro.Proximo = auxRetirada.Proximo;

            if (auxRetirada.Proximo != null)
                auxRetirada.Proximo = null;
            else
                this.Ultimo = this.Primeiro;

            return auxRetirada.MeuDado;
        }
        public override string ToString()
        {
            StringBuilder auxImpressao = new StringBuilder();
            Elemento aux = Primeiro;

            while(aux.Proximo != null)
            {
                auxImpressao.AppendLine(aux.Proximo.MeuDado.ToString());
                aux = aux.Proximo;
            }

            return auxImpressao.ToString();
        }
        public bool Vazia()
        {
            return Primeiro == Ultimo;
        }
        #endregion
    }
}
