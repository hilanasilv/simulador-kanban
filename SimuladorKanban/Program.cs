using System;
using System.Collections.Generic;
using System.Linq;
using static SimuladorKanban.Kanban;

namespace SimuladorKanban
{   
    // Classe responsável por organizar e gerenciar as tarefas dentro do sistema.
    internal class Kanban
    {
        // Classe que representa uma tarefa dentro do sistema.
        public class Tarefa
        {
            public int Id { get; private set; }
            public string Nome { get; set; }

            // Contador estático para gerar IDs para cada tarefa.
            private static int contador = 1;

            // Construtor da tarefa
            public Tarefa(string nome)
            {
                Id = contador++; // Incrementa o contador para cada nova tarefa
                Nome = nome; // Atribui o nome da tarefa
            }
        }

        // Listas que representam as fases do fluxo Kanban: "A fazer", "Em progresso" e "Concluído"
        private List<Tarefa> toDo = new List<Tarefa>();
        private List<Tarefa> doing = new List<Tarefa>();
        private List<Tarefa> done = new List<Tarefa>();

        // Método para adicionar uma nova tarefa à lista "A fazer"
        public void AdicionarTarefa(Tarefa tarefa)
        {
            toDo.Add(tarefa);
        }

        // Método para exibir todas as tarefas listadas
        public void ExibirTarefas()
        {
            Console.WriteLine("\n--- Quadro de tarefas ---\n");
            Console.WriteLine("A Fazer:");
            foreach (var tarefa in toDo)
            {
                Console.WriteLine($"{tarefa.Id}. {tarefa.Nome}");
            }

            Console.WriteLine("-----------");

            Console.WriteLine("\nEm Progresso:");
            foreach (var tarefa in doing)
            {
                Console.WriteLine($"{tarefa.Id}. {tarefa.Nome}");
            }

            Console.WriteLine("-----------");

            Console.WriteLine("\nConcluído:");
            foreach (var tarefa in done)
            {
                Console.WriteLine($"{tarefa.Id} .  {tarefa.Nome}");
            }

            Console.WriteLine("-----------");
        }

        // Método para mover uma tarefa entre as listas.
        public void MoverTarefa()
        {
            ExibirTarefas();
            Console.WriteLine("\nDigite o número da tarefa que deseja mover: ");
            int taskNumber = int.Parse(Console.ReadLine());

            // Método que percorre as três listas em busca da tarefa com o taskNumber informado.
            Tarefa tarefa = toDo.FirstOrDefault(t => t.Id == taskNumber) ??
                           doing.FirstOrDefault(t => t.Id == taskNumber) ??
                           done.FirstOrDefault(t => t.Id == taskNumber);

            if (tarefa == null)
            {
                Console.WriteLine("Tarefa não encontrada.");
                return;
            }

            Console.WriteLine("Para qual lista deseja mover a tarefa?");
            Console.WriteLine("1 - A Fazer");
            Console.WriteLine("2 - Em Progresso");
            Console.WriteLine("3 - Concluído");
            Console.WriteLine("4 - Retornar ao menu");
            int novaLista = int.Parse(Console.ReadLine());

            // Move a tarefa para a lista correspondente e remove das outras listas.
            switch (novaLista)
            {
                case 1:
                    toDo.Add(tarefa);
                    doing.Remove(tarefa);
                    done.Remove(tarefa);
                    Console.WriteLine($"Tarefa movida com sucesso para a lista 'A fazer'");
                    break;
                case 2:
                    doing.Add(tarefa);
                    toDo.Remove(tarefa);
                    done.Remove(tarefa);
                    Console.WriteLine("Tarefa movida com sucesso para a lista 'Em Progresso'.");
                    break;
                case 3:
                    done.Add(tarefa);
                    toDo.Remove(tarefa);
                    doing.Remove(tarefa);
                    Console.WriteLine("Tarefa movida com sucesso para a lista 'Concluído'.");
                    break;
                case 4:
                    ExibirTarefas();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    // Entrada da aplicação - Layout de exibição.
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância da classe Kanban para gerenciar as tarefas.
            Kanban kanban = new Kanban();

            // Loop que exibe o menu até o usuário encerrar o sistema. 
            while (true)
            {
                Console.WriteLine("\n--- Gerenciador de Tarefas ---\n");
                Console.WriteLine("1 - Adicionar nova tarefa");
                Console.WriteLine("2 - Exibir tarefas");
                Console.WriteLine("3 - Mover tarefa");
                Console.WriteLine("4 - Sair\n");
                Console.Write("Escolha uma opção: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome da tarefa: ");
                        string nomeTarefa = Console.ReadLine();
                        kanban.AdicionarTarefa(new Tarefa(nomeTarefa));
                        Console.WriteLine($"A tarefa '{nomeTarefa}' foi adicionada à lista 'A Fazer'.");
                        break;
                    case 2:
                        kanban.ExibirTarefas();
                        break;
                    case 3:
                        kanban.MoverTarefa();
                        break;
                    case 4:
                        Console.WriteLine("Encerrando o sistema...");
                        return;
                }
            }
        }

    }
}