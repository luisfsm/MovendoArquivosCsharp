using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MoverArquviosCsharp
{
    class MoverArquivos
    {
        private string diretorioAtual;
        private string diretorioFinal;


        public void MoverArquivosDiretorios(string diretorioAtual, string diretoriofinal)
        {
            string[] listarArquivos = System.IO.Directory.GetFiles(diretorioAtual);

            foreach (string arquivo in listarArquivos) {
                try
                {
                    System.IO.Directory.Move(arquivo, diretoriofinal);
                }
                catch(Exception e){
                    Console.Write("erro ao mover");

                }
                finally
                {
                    Console.WriteLine("Arquivo movido : " + arquivo);
                }
               
            }
        }

    }
}
