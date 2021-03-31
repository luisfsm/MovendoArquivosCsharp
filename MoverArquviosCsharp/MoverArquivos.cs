using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MoverArquviosCsharp
{
    class MoverArquivos
    {
        public void MoverArquivosDiretorios(string diretorioAtual, string diretoriofinal)
        {
            string[] listarArquivos = System.IO.Directory.GetFiles(diretorioAtual);

            foreach (string arquivo in listarArquivos) {
                Console.WriteLine(arquivo);
            }
        }

    }
}
