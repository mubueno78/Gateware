using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateware.Negocio
{
    public class Exercicio03
    {
        public static bool Solucao01()
        {
            try
            {
                string strArquivoDestino = string.Empty;
                string strPathOrigem = @"c:\Projetos\Gateware\Exercicio03\origem";
                string strPathDestino = @"c:\Projetos\Gateware\Exercicio03\destino";

                if(!Directory.Exists(strPathDestino))
                {
                    Directory.CreateDirectory(strPathDestino);
                }

                DirectoryInfo diretorio = new DirectoryInfo(strPathOrigem);
                FileInfo[] arquivos = diretorio.GetFiles();
                foreach(FileInfo arquivo in arquivos)
                {
                    strArquivoDestino = string.Format(@"{0}\{1}", strPathDestino, arquivo.Name);
                    File.Copy(arquivo.FullName, strArquivoDestino);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
