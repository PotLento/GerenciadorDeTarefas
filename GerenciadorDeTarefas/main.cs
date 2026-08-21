List<string> tarefas = new List<string>();
int opcao = 0;

while (opcao != 4)
{
    Console.WriteLine("===== GERENCIADOR DE TAREFAS =====");
    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("3 - Remover tarefa");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");

    while (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.Write("Opção inválida. Tente novamente: ");
    }

    switch (opcao)
    {
        case 1:
            AdicionarTarefa(tarefas);
            break;

        case 2:
            Console.WriteLine("Listar tarefas selecionado.");
            ListarTarefas(tarefas);
            break;

        case 3:
            Console.WriteLine("Remover tarefa selecionado.");
            RemoverTarefa(tarefas);
            break;

        case 4:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

    // código responsável por listar
    void ListarTarefas(List<string> tarefas)
{
    if (tarefas.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa cadastrada.");
    }
    else
    {
        Console.WriteLine("Tarefas cadastradas: ");
        for (int i = 0; i < tarefas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tarefas[i]}");
        }
    }
}

void AdicionarTarefa(List<string> tarefas)
{
    Console.WriteLine("Adicionar tarefa selecionado.");
    Console.WriteLine("Digite a descrição da tarefa: ");

    string descricao = Console.ReadLine();

    tarefas.Add(descricao);
}

void RemoverTarefa(List<string> tarefas)
{
    if (tarefas.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa cadastrada.");
    }
    else
    {
        ListarTarefas(tarefas);
        Console.Write("Digite o número da tarefa a ser removida: ");
        int numeroTarefa;
        while (!int.TryParse(Console.ReadLine(), out numeroTarefa) || numeroTarefa < 1 || numeroTarefa > tarefas.Count)
        {
            Console.Write("Índice inválido. Tente novamente: ");
        }
        tarefas.RemoveAt(numeroTarefa - 1);
        Console.WriteLine("Tarefa removida com sucesso.");
    }
}