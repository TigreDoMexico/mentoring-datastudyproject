namespace BaseDeDados.Actions;

using BaseDeDados.UI;
using BaseDeDados.Actions.Options;

public class UserAction
{
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
                    Console.WriteLine("");
                    break;
                case (int) UserDataAction.Remover:
                    Console.WriteLine("A Opção OPERACAO");
                    break;
                case (int) UserDataAction.Alterar:
                    Console.WriteLine("A Opção ACESSO");
                    break;
                case (int) UserDataAction.Pesquisar:
                    Console.WriteLine("A Opção ACESSO");
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
                    Console.WriteLine("A Opção USUÁRIO");
                    break;
                case (int) OperacaoAction.Desfazer:
                    Console.WriteLine("A Opção OPERACAO");
                    break;
                case (int) OperacaoAction.RealizarTodas:
                    Console.WriteLine("A Opção ACESSO");
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
                    Console.WriteLine("A Opção USUÁRIO");
                    break;
                case (int) AcessoAction.LiberarPrimeiro:
                    Console.WriteLine("A Opção OPERACAO");
                    break;
                case (int) AcessoAction.RemoverPrimeiro:
                    Console.WriteLine("A Opção ACESSO");
                    break;
                case (int) AcessoAction.LiberarTodos:
                    Console.WriteLine("A Opção ACESSO");
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