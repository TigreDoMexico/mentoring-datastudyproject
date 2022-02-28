namespace BaseDeDados.Actions;

using BaseDeDados.UI;
using BaseDeDados.Actions.Options;
using BaseDeDados.Usuario;
using BaseDeDados.Acesso;
using BaseDeDados.Operacao;

public class UserAction
{
    private readonly UsuarioManager _usuarioManager = new UsuarioManager();
    private readonly OperacaoManager _operacaoManager = new OperacaoManager();
    private readonly AcessoManager _acessoManager = new AcessoManager();

    public void Begin()
    {
        int opcao;
        bool programExecuting = true;
        while(programExecuting){
            MainInterface.MostrarOpcoesIniciais();
            GetTextoEscrito(out opcao);

            switch(opcao) {
                case (int) MainMenuAction.Usuario:
                    BeginUsuario();
                    break;
                case (int) MainMenuAction.Operacao:
                    BeginOperacao();
                    break;
                case (int) MainMenuAction.Acesso:
                    BeginAcesso();
                    break;
                case (int) MainMenuAction.Finalizar:
                    Console.WriteLine("Obrigado por usar nosso sistema! Volte sempre");
                    programExecuting = false;
                    break;
                default:
                    Console.WriteLine("Escolha uma das opções disponíveis");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void BeginUsuario() {
        int opcao;
        bool menuUsuarioExecuting = true;
        while(menuUsuarioExecuting){
            MainInterface.MostrarOpcoesUsuario();
            GetTextoEscrito(out opcao);

            switch(opcao) {
                case (int) UserDataAction.Adicionar:
                    _usuarioManager.AdicionarUsuarioNaBase();
                    break;
                case (int) UserDataAction.Remover:
                    _usuarioManager.RemoverUsuarioDaBase();
                    break;
                case (int) UserDataAction.Alterar:
                    _usuarioManager.AlterarUsuarioNaBase();
                    break;
                case (int) UserDataAction.Pesquisar:
                    _usuarioManager.PesquisarUsuarioNaBase();
                    break;
                case (int) UserDataAction.ListarTodos:
                    _usuarioManager.ListarTodosOsUsuariosDaBase();
                    break;
                case (int) UserDataAction.Voltar:
                    menuUsuarioExecuting = false;
                    break;
                default:
                    Console.WriteLine("Escolha uma das opções disponíveis");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void BeginOperacao() {
        int opcao;
        bool menuOperacoesExecuting = true;
        while(menuOperacoesExecuting){
            MainInterface.MostrarOpcoesOperacoes();
            GetTextoEscrito(out opcao);

            switch(opcao) {
                case (int) OperacaoAction.Adicionar:
                    _operacaoManager.AdicionarNovaOperacao();
                    break;
                case (int) OperacaoAction.Desfazer:
                    _operacaoManager.DesfazerUltimaOperacao();
                    break;
                case (int) OperacaoAction.RealizarTodas:
                    _operacaoManager.RealizarTodasAsOperacaos();
                    break;
                case (int) OperacaoAction.Voltar:
                    menuOperacoesExecuting = false;
                    break;
                default:
                    Console.WriteLine("Escolha uma das opções disponíveis");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void BeginAcesso() {
        int opcao;
        bool menuAcessoExecuting = true;
        while(menuAcessoExecuting){
            MainInterface.MostrarOpcoesAcesso();
            GetTextoEscrito(out opcao);

            switch(opcao) {
                case (int) AcessoAction.Adicionar:
                    _acessoManager.AdicionarAcessoParaUsuario();
                    break;
                case (int) AcessoAction.LiberarPrimeiro:
                    _acessoManager.LiberarPrimeiroAcessoDaFila();
                    break;
                case (int) AcessoAction.RemoverPrimeiro:
                    _acessoManager.RemoverPrimeiroAcessoDaFila();
                    break;
                case (int) AcessoAction.LiberarTodos:
                    _acessoManager.LiberarTodosOsAcessosDaFila();
                    break;
                case (int) AcessoAction.Voltar:
                    menuAcessoExecuting = false;
                    break;
                default:
                    Console.WriteLine("Escolha uma das opções disponíveis");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void GetTextoEscrito(out int opcao)
    {
        opcao = -1;
        while (opcao == -1)
        {
            int.TryParse(Console.ReadLine(), out opcao);
            if (opcao == -1)
                Console.WriteLine("Favor insira um valor válido");
        }
    }
}