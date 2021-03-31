using System;
using MoverArquviosCsharp.Mover;

namespace MoverArquviosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MoverArquivos moverArquivos = new MoverArquivos();

            moverArquivos.MoverArquivosDiretorios("C:\\arquivos", "C:\\movidos");
           
        }
    }
}
