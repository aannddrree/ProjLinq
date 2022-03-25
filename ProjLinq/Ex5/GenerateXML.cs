using ProjLinq.Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjLinq.Ex5
{
    public class GenerateXML
    {
        public static void Main(String[] args)
        {
            string pathFile = @"C:\Users\André\Documents\5by5\2022\linq\dados\motoristas_habilitados_11_2021.json";

            Console.WriteLine("Início");

            //Carregar dados
            var lst = ReadFile.getData(pathFile);

            if (lst != null)
            {

                // Create the query.
                var studentsToXML = new XElement("Root",
                    from data in lst
                    where data.Cpf == "880.***.***-34"
                    select new XElement("motorista",
                               new XElement("razao_social", data.RazaoSocial),
                               new XElement("cnpj", data.Cnpj),
                               new XElement("nome_motorista", data.NomeMotorista),
                               new XElement("cpf", data.Cpf),
                               new XElement("vigencia_do_cadastro", data.VigenciaCadastro)
                            ) // end "data"
                        ); // end "Root"

                Console.WriteLine(studentsToXML);

            }
            Console.WriteLine("Fim");
        }
    }
}
