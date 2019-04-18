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
        // id;nome;prioridade;quantidade_ciclos 

        public static Escalonador LeituraArquivo(string nomeArquivo)
        {
            if (!File.Exists(nomeArquivo)) return null;

            //IDado novo;
            string[] info;
            Escalonador auxiliar = new Escalonador();
            
            //Fazer a leitura do arquivo e organizar entre as 10 listas Circulares
            StreamReader arquivoLeitura = new StreamReader(nomeArquivo);

            while (!arquivoLeitura.EndOfStream)
            {
                info = arquivoLeitura.ReadLine().Split(';');
                //novo = new Processos(Convert.ToInt32(info[0]), info[1], Convert.ToInt32(info[2]), Convert.ToInt32(info[3]));

                auxiliar.AdicionarProcesso(info);
                //switch (info[2]) //não leu o primeiro dado do arquivo
                //{
                //    case "1": auxiliar.Todos[0].Inserir(novo); break;
                //    case "2": auxiliar.Todos[1].Inserir(novo); break;
                //    case "3": auxiliar.Todos[2].Inserir(novo); break;
                //    case "4": auxiliar.Todos[3].Inserir(novo); break;
                //    case "5": auxiliar.Todos[4].Inserir(novo); break;
                //    case "6": auxiliar.Todos[5].Inserir(novo); break;
                //    case "7": auxiliar.Todos[6].Inserir(novo); break;
                //    case "8": auxiliar.Todos[7].Inserir(novo); break;
                //    case "9": auxiliar.Todos[8].Inserir(novo); break;
                //    case "10": auxiliar.Todos[9].Inserir(novo); break;
                //    default: break;
                //}


            }

            arquivoLeitura.Close();

            return auxiliar;
        }
    }
}
