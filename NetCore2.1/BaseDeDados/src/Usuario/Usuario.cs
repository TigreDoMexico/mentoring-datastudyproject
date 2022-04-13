using System;

namespace BaseDeDados.UserData
{   

    public class Usuario
    {
        public int RA { get; set; }
        public string Nome { get; set; } = "";
        public int CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
