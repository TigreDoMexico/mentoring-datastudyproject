using BaseDeDados.UI;
using BaseDeDados.Operation.Options;

namespace BaseDeDados.Operation;

public class Operation
{
    public void Begin()
    {
        int opcao;
        bool programExecuting = true;
        while(programExecuting){
            MainInterface.MostrarOpcoesIniciais();
            GetTextoEscrito(out opcao);

            switch(opcao) {
                case (int) MainMenuOperation.Usuario:
                    BeginUsuario();
                    break;
                case (int) MainMenuOperation.Operacao:
                    BeginOperacao();
                    break;
                case (int) MainMenuOperation.Acesso:
                    BeginAcesso();
                    break;
                case (int) MainMenuOperation.Finalizar:
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
                case (int) UserOperation.Adicionar:
                    Console.WriteLine("");
                    break;
                case (int) UserOperation.Remover:
                    Console.WriteLine("A Opção OPERACAO");
                    break;
                case (int) UserOperation.Alterar:
                    Console.WriteLine("A Opção ACESSO");
                    break;
                case (int) UserOperation.Pesquisar:
                    Console.WriteLine("A Opção ACESSO");
                    break;
                case (int) UserOperation.Voltar:
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
                case (int) OperacaoOperation.Adicionar:
                    Console.WriteLine("A Opção USUÁRIO");
                    break;
                case (int) OperacaoOperation.Desfazer:
                    Console.WriteLine("A Opção OPERACAO");
                    break;
                case (int) OperacaoOperation.RealizarTodas:
                    Console.WriteLine("A Opção ACESSO");
                    break;
                case (int) OperacaoOperation.Voltar:
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
                case (int) AcessoOperation.Adicionar:
                    Console.WriteLine("A Opção USUÁRIO");
                    break;
                case (int) AcessoOperation.LiberarPrimeiro:
                    Console.WriteLine("A Opção OPERACAO");
                    break;
                case (int) AcessoOperation.RemoverPrimeiro:
                    Console.WriteLine("A Opção ACESSO");
                    break;
                case (int) AcessoOperation.LiberarTodos:
                    Console.WriteLine("A Opção ACESSO");
                    break;
                case (int) AcessoOperation.Voltar:
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