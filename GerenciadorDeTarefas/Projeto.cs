using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Tarefas
{
    class Projeto
    {
        List<Tarefa> Tarefas = new List<Tarefa>();



        public string Nome { get; set; }
        public string Descricao { get; set; }
        private int _quantidadeMaximaDeTarefas;
        public int QuantidadeMaximaDeTarefas { 
            get 
            {
                return _quantidadeMaximaDeTarefas;
            }
            set 
            {
                if (value > 0)
                {
                    _quantidadeMaximaDeTarefas = value;
                }
            } 
        }
        private double _horasEstimadas;
        public double HorasEstimadas { 
            get 
            {
                return _horasEstimadas;
            }
            set 
            { 
                if (value > 0 )
                {
                    _horasEstimadas = value;
                }
            } 
        }

        public string DescricaoDetalhada 
        { 
            get 
            { return $"Projeto: {Nome} | Descrição: {Descricao} | Máximo de tarefas: {QuantidadeMaximaDeTarefas} | Horas estimadas: {HorasEstimadas}"; } 
        }

        public void AdicionarTarefa(Tarefa tarefa)
        { // O método recebeu uma tarefa pronta.
            Tarefas.Add(tarefa);
        }

        public void ListarTarefas()
        {
            if (Tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {

                Console.WriteLine("Tarefas cadastradas: ");
                for (int i = 0; i < Tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Tarefas[i].DescricaoDetalhada}");
                }
            }
        }
    }

}
