using Tarefas;
/*
Projeto p1 = new Projeto();

p1.Nome = "Estudos C#";
p1.Descricao = "Estudar C# pela manhã";
p1.QuantidadeMaximaDeTarefas = 5;
p1.HorasEstimadas = 6.6;

Console.WriteLine(p1.DescricaoDetalhada);
Console.ReadKey();
*/

// Atividades 1 e 2: associação entre Tarefa e Projeto e acesso aos dados do Projeto através da Tarefa.

/*
Projeto p1 = new Projeto();

Tarefa t1 = new Tarefa();

t1.Projeto = p1;

p1.Nome = "Teste";

Console.WriteLine(t1.Projeto.Nome);
Console.ReadKey();
*/

Projeto p1 = new Projeto();

Tarefa t1 = new Tarefa();

t1.Descricao = "Estudar mais";

   p1.AdicionarTarefa(t1);

    p1.ListarTarefas();
Console.ReadKey();

GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

int opcao = 0;

    while (opcao != 5)
    {

        Console.Clear();
        ExibirLogo();    
        Console.WriteLine("\n1 - Adicionar tarefa");
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