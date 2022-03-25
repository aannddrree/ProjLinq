﻿using ProjLinq.Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLinq.Ex3
{
    public class QueryOr
    {
        public static void Main (String[] args)
        {
            string pathFile = @"C:\Users\André\Documents\5by5\2022\linq\dados\motoristas_habilitados_11_2021.json";

            Console.WriteLine("Início");

            //Carregar dados
            var lst = ReadFile.getData(pathFile);

            if (lst != null)
            {
                var dataQuery =
                             (from data in lst
                              where data.Cpf == "052.***.***-37" || data.Cpf == "880.***.***-34"
                              select data);

                foreach (var data in dataQuery)
                {
                    Console.WriteLine(data);
                }
            }

            Console.WriteLine("Fim");


        }

    }
}
