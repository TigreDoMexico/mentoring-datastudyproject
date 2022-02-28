using BaseDeDados.UserData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDados.Operacao
{
    public class Operacao
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public DateTime DataRequisicao { get; set; }
    }
}
