using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDados.UI
{
    public static class MainInterface
    {
        public static void MostrarApresentacao()
        {
            Console.Clear();
            Console.WriteLine("=== BEM-VINDO A BASE DE DADOS DA ADS ===");
            Console.WriteLine("\n[Pressione Enter para Continuar]\n");
            Console.ReadLine();
        }

        public static void MostrarOpcoesIniciais()
        {
            Console.Clear();
            Console.WriteLine("\nESCOLHA UMA OPÇÃO");

            Console.WriteLine("1 - Usuários (Lista)");
            Console.WriteLine("2 - Operações (Pilha)");
            Console.WriteLine("3 - Ordem de Acesso (Fila)");
            Console.WriteLine("0 - Finalizar Programa");
        }

        public static void MostrarOpcoesUsuario()
        {
            Console.Clear();
            Console.WriteLine("\nUSUÁRIOS (LISTA)");

            Console.WriteLine("1 - Adicionar novo Usuário");
            Console.WriteLine("2 - Remover Usuário");
            Console.WriteLine("3 - Alterar Usuário");
            Console.WriteLine("4 - Pesquisar Usuário na Base");
            Console.WriteLine("0 - Voltar");
        }

        public static void MostrarOpcoesOperacoes()
        {
            Console.Clear();
            Console.WriteLine("\nOPERAÇÕES (PILHA)");

            Console.WriteLine("1 - Adicionar operação na Pilha");
            Console.WriteLine("2 - Desfazer ultima operação");
            Console.WriteLine("3 - Realizar Operações");
            Console.WriteLine("0 - Voltar");
        }

        public static void MostrarOpcoesAcesso()
        {
            Console.Clear();
            Console.WriteLine("\nACESSOS (FILA)");

            Console.WriteLine("1 - Adicionar usuário na Fila de Acessos");
            Console.WriteLine("2 - Liberar acesso para o primeiro da fila");
            Console.WriteLine("3 - Remover acesso para o primeiro da fila");
            Console.WriteLine("4 - Liberar acesso para todos os usuários");
            Console.WriteLine("0 - Voltar");
        }
    }
}
