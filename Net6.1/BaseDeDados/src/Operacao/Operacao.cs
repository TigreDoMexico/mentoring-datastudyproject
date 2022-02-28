namespace BaseDeDados.Operacao;

using BaseDeDados.Usuario;

public class Operacao
{
    public int Id { get; set; }
    public Usuario? Usuario { get; set; }
    public string? Nome { get; set; }
    public DateTime DataRequisicao { get; set; }
}