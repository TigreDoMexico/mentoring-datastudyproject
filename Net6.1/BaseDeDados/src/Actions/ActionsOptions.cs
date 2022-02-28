namespace BaseDeDados.Actions.Options;

public enum MainMenuAction {
    Finalizar = 0,
    Usuario = 1,
    Operacao = 2,
    Acesso = 3
}

public enum UserDataAction {
    Voltar = 0,
    Adicionar = 1,
    Remover = 2,
    Alterar = 3,
    Pesquisar = 4,
    ListarTodos = 5
}

public enum OperacaoAction {
    Voltar = 0,
    Adicionar = 1,
    Desfazer = 2,
    RealizarTodas = 3
}

public enum AcessoAction {
    Voltar = 0,
    Adicionar = 1,
    LiberarPrimeiro = 2,
    RemoverPrimeiro = 3,
    LiberarTodos = 4
}
