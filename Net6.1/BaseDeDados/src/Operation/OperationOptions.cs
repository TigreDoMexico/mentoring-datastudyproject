namespace BaseDeDados.Operation.Options;

public enum MainMenuOperation {
    Finalizar = 0,
    Usuario = 1,
    Operacao = 2,
    Acesso = 3
}

public enum UserOperation {
    Voltar = 0,
    Adicionar = 1,
    Remover = 2,
    Alterar = 3,
    Pesquisar = 4
}

public enum OperacaoOperation {
    Voltar = 0,
    Adicionar = 1,
    Desfazer = 2,
    RealizarTodas = 3
}

public enum AcessoOperation {
    Voltar = 0,
    Adicionar = 1,
    LiberarPrimeiro = 2,
    RemoverPrimeiro = 3,
    LiberarTodos = 4
}
