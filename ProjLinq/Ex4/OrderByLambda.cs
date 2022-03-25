using ProjLinq.Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLinq.Ex4
{
    public class OrderByLambda
    {
        public static void Main(String[] args)
        {
            string pathFile = @"C:\Users\André\Documents\5by5\2022\linq\dados\motoristas_habilitados_11_2021.json";

            Console.WriteLine("Início");

            //Carregar dados
            var lst = ReadFile.getData(pathFile);

            if (lst != null)
            {
       
                var dataQueryLambda = lst.Where(d => d.Cpf == "880.***.***-34")
                                         .OrderBy(d => d.NomeMotorista);

                foreach (var data in dataQueryLambda)
                {
                    Console.WriteLine(data);
                }
            }
            Console.WriteLine("Fim");
        }
    }
}
