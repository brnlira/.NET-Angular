using System;

namespace PBT.API.Model
{
    public class CSessao
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public int SessaoId { get; set; }
        public string NomeSessao { get; set; }
        public string Local { get; set; }
        public string DataDaSessao { get; set; }
        public int QtdPessoas { get; set; }
    }
}