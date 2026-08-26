using Tarefas;
 
GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

int opcao = 0;

    while (opcao != 5)
    {

        Console.Clear();
        ExibirLogo();    
        Console.WriteLine("1 - Adicionar tarefa");
        Console.WriteLine("2 - Listar tarefas");
        Console.WriteLine("3 - Remover tarefa");
        Console.WriteLine("4 - Concluir tarefa");
        Console.WriteLine("5 - Sair");
        Console.Write("\nEscolha uma opção: ");

        while (!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.Write("Opção inválida. Tente novamente: ");
        }

        // Limpa o menu antes de mostrar somente a ação escolhida
        Console.Clear();
        ExibirLogo();

        switch (opcao)
        {
            case 1:
                gerenciador.AdicionarTarefa();
                break;

            case 2:
                Console.WriteLine("Listar tarefas selecionado.");
                gerenciador.ListarTarefas();
                break;

            case 3:
                Console.WriteLine("Remover tarefa selecionado.");
                gerenciador.RemoverTarefa();
                break;

            case 4:
                Console.WriteLine("Concluir tarefa selecionado.");
                gerenciador.ConcluirTarefa();
                break;

            case 5:
            Console.WriteLine("Saindo...");
            break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

    if (opcao != 5)
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░███████╗██████╗░███████╗███╗░░██╗░█████╗░██╗░█████╗░██████╗░░█████╗░██████╗░  ██████╗░███████╗
██╔════╝░██╔════╝██╔══██╗██╔════╝████╗░██║██╔══██╗██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░██╗░█████╗░░██████╔╝█████╗░░██╔██╗██║██║░░╚═╝██║███████║██║░░██║██║░░██║██████╔╝  ██║░░██║█████╗░░
██║░░╚██╗██╔══╝░░██╔══██╗██╔════╝██║╚████║██║░░██╗██║██╔══██║██║░░██║██║░░██║██╔══██╗  ██║░░██║██╔══╝░░
╚██████╔╝███████╗██║░░██║███████╗██║░╚███║╚█████╔╝██║██║░░██║██████╔╝╚█████╔╝██║░░██║  ██████╔╝███████╗
░╚═════╝░╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝░╚════╝░╚═╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

████████╗░█████╗░██████╗░███████╗███████╗░█████╗░░██████╗
╚══██╔══╝██╔══██╗██╔══██╗██╔════╝██╔════╝██╔══██╗██╔════╝
░░░██║░░░███████║██████╔╝█████╗░░█████╗░░███████║╚█████╗░
░░░██║░░░██╔══██║██╔══██╗██╔══╝░░██╔══╝░░██╔══██║░╚═══██╗
░░░██║░░░██║░░██║██║░░██║███████╗██║░░░░░██║░░██║██████╔╝
░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░░╚═╝╚═════╝░");
}