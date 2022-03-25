using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLinq.Ex2
{
    //newtonsoft json - Nuget - Instalar 
    public class PenalidadesAplicadas
    {
        [JsonProperty("razao_social")]
        public string? RazaoSocial { get; set; }

        [JsonProperty("cnpj")]
        public string? Cnpj { get; set; }

        [JsonProperty("nome_motorista")]
        public string? NomeMotorista { get; set; }

        [JsonProperty("cpf")]
        public string? Cpf { get; set; }

        [JsonProperty("vigencia_do_cadastro")]
        public DateTime? VigenciaCadastro { get; set; }

        public override string ToString()
        {
            return this.NomeMotorista + " - CPF: " + this.Cpf;
        }
    }
}
