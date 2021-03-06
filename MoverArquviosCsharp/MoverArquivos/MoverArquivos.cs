using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MoverArquviosCsharp.Mover
{
    class MoverArquivos
    {

        public void MoverArquivosDiretorios(string diretorioAtual, string diretoriofinal)
        {
            CriarDiretorio(diretorioAtual);
            CriarDiretorio(diretoriofinal);

            string[] listarArquivos = System.IO.Directory.GetFiles(diretorioAtual);
            
            
            foreach (string arquivo in listarArquivos) {
                try
                {
                   string  nomerquivo = System.IO.Path.GetFileName(arquivo);
                    string destinoArquivo = System.IO.Path.Combine(diretoriofinal, nomerquivo);

                    System.IO.File.Move(arquivo, destinoArquivo, true);

                    Console.WriteLine(arquivo + "\n" + nomerquivo + "\n" + destinoArquivo);
                }
                catch(Exception e){
                    Console.Write(e.ToString());
                }
            }
            Console.WriteLine("Não existe mais arquivos para processar");
            Console.WriteLine("clique em qualquer botao pra encerrar");
        }

       private void CriarDiretorio(string diretorio)
        {
            try
            {
                if (!System.IO.Directory.Exists(diretorio))
                {
                    System.IO.Directory.CreateDirectory(diretorio);
                    Console.WriteLine("criando o diretorio : " + diretorio);
                }

            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
