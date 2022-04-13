using System;
using System.Collections.Generic;

namespace BaseDeDados.UserData
{
    public class UsuarioManager
    {   
        //Propriedades
        List<Usuario> listaUsuarios = new List<Usuario>();

        // Metodo
        public void AdicionarUsuarioNaBase()
        {
            var user = new Usuario();
            user.Nome = Console.ReadLine();
            
            listaUsuarios.Add(user);

            Console.WriteLine("Usuario adicionado com sucesso!");
            Console.WriteLine("Tamanho da lista: " + listaUsuarios.Count);
            Console.ReadLine();
        }

        public void RemoverUsuarioDaBase()
        {
            Console.WriteLine("Método Não Implementado (AINDA)");
            Console.ReadLine();
        }

        public void AlterarUsuarioNaBase()
        {
            Console.WriteLine("Método Não Implementado (AINDA)");
            Console.ReadLine();
        }

        public void PesquisarUsuarioNaBase()
        {
            Console.WriteLine("Método Não Implementado (AINDA)");
            Console.ReadLine();
        }

        public void ListarTodosOsUsuariosDaBase()
        {
            Console.WriteLine("Método Não Implementado (AINDA)");
            Console.ReadLine();
        }
    }
}
