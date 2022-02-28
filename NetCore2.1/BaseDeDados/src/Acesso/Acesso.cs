using BaseDeDados.UserData;
using System;

namespace BaseDeDados.Acesso
{
    public class Acesso
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public string Sistema { get; set; }
        public DateTime DataRequisicao { get; set; }
    }
}
