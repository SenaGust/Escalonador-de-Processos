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
        public static Escalonador LeituraArquivo(string nomeArquivo)
        {
            // Formatação do arquivo
            // id;nome;prioridade;quantidade_ciclos 

            if (!File.Exists(nomeArquivo)) return null;

            string[] info;
            Escalonador auxiliar = new Escalonador();
            
            //Fazer a leitura do arquivo e organizar entre as 10 listas Circulares
            StreamReader arquivoLeitura = new StreamReader(nomeArquivo);

            while (!arquivoLeitura.EndOfStream)
            {
                info = arquivoLeitura.ReadLine().Split(';');
                auxiliar.AdicionarProcesso(new Processos(Convert.ToInt32(info[0]), info[1], Convert.ToInt32(info[2]), Convert.ToInt32(info[3])));
            }

            arquivoLeitura.Close();

            return auxiliar;
        }
    }
}