using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Escalonador_de_Processos
{
    class Arquivo
    {
        // Formatação do arquivo
        // PID; Nome; Prioridade; QtdeCiclos; TempoCPU (talvez)

        public static Escalonador LeituraArquivo(string nomeArquivo)
        {
            if (!File.Exists(nomeArquivo)) return null;

            Escalonador auxiliar = new Escalonador();

            //Fazer a leitura do arquivo e organizar entre as 10 listas Circulares
            StreamReader arquivoLeitura = new StreamReader(nomeArquivo);



            arquivoLeitura.Close();

            return auxiliar;
        }
    }
}
