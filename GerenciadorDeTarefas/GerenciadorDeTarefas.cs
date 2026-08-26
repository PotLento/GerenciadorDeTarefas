namespace Tarefas
{
    // ATIVIDADE 3 - Gerenciador de tarefas com lista interna
    class GerenciadorDeTarefas
    {
        private List<Tarefa> tarefas = new List<Tarefa>();

        public void ListarTarefas()
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
                    Console.WriteLine($"{i + 1}. {tarefas[i].DescricaoDetalhada}");
                }
            }
        }

        public void AdicionarTarefa()
        {

            Console.WriteLine("Adicionar tarefa selecionado.");
            Console.WriteLine("Digite a descrição da tarefa: ");

            string descricao = Console.ReadLine();

            Tarefa novaTarefa = new Tarefa();
            novaTarefa.Descricao = descricao;

            int prioridadeEscolhida;
            Console.Write("De 1 a 3, qual seria a prioridade desta tarefa? ");
            while (!int.TryParse(Console.ReadLine(), out prioridadeEscolhida)
            || prioridadeEscolhida < 1
            || prioridadeEscolhida > 3)
            {
                Console.Write($"\nO valor {prioridadeEscolhida} é invalido, escolha valores de 1 a 3: ");
            }
            novaTarefa.Prioridade = prioridadeEscolhida;

            novaTarefa.Concluida = false;

            tarefas.Add(novaTarefa);
        }

        public void RemoverTarefa()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {
                ListarTarefas();
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

        public void ConcluirTarefa()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {
                ListarTarefas();
                Console.Write("Digite o número da tarefa a ser concluída: ");
                int numeroTarefa;
                while (!int.TryParse(Console.ReadLine(), out numeroTarefa)
                    || numeroTarefa < 1
                    || numeroTarefa > tarefas.Count)
                {
                    Console.Write("Índice inválido. Tente novamente: ");
                }
                tarefas[numeroTarefa - 1].Concluida = true;
                Console.WriteLine("Tarefa marcada como Concluída!");
            }
        }


    }

}