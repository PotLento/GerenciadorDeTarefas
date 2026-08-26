using System;
using System.Collections.Generic;
using System.Text;

namespace Tarefas
{
    class Tarefa
    {
        public string Descricao { get; set; }
        public string DescricaoDetalhada
        {
         get 
         {
                string status;
                if (Concluida == true)
                {
                    status = "Concluída";
                } else
                {
                    status = "Pendente";
                }
                return $"{Descricao} | {Prioridade} | {status}";
         }

        }

        private int _prioridade;
        public int Prioridade
        {
            get { return _prioridade; }
            set { 
                if (value >= 1 && value <= 3)
                {
                    _prioridade = value;
                    Console.WriteLine($"\nPrioridade definida para {value} ");
                } else
                {
                    Console.WriteLine($"\nO valor {value} é invalido, escolha valores de 1 a 3. ");
                }
            } 
        }
        public bool Concluida { get; set; }
        public void ExibirTarefa()
        {
            Console.WriteLine($"Descrição da tarefa: {Descricao}");

        }

        public Projeto Projeto { get; set; }
    }
}
