using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador_de_Processos
{
    class ListaCircular
    {
        #region Atributos
        public Elemento atual { get; set; }
        public Elemento anterior { get; set; }
        #endregion

        #region Construtor
        public ListaCircular()
        {
            atual = new Elemento(null);
            anterior = atual;
            atual.Proximo = atual;
        }
        #endregion

        #region Métodos
        public void Inserir(IDado dado)
        {
            return; 
        }
        public IDado Retirar()
        {
            return null;
        }
        public bool Vazia()
        {
            return atual == anterior;
        }
        #endregion
    }
}
