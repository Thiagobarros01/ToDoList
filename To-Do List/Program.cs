using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List {
    internal class Program {

        static List<Tarefa> tarefas = new List<Tarefa>();
        static void Main(string[] args) {




            while (true) {
                Console.WriteLine("\nTo-Do List");
                Console.WriteLine("1. Adicionar tarefa");
                Console.WriteLine("2. Listar tarefas");
                Console.WriteLine("3. Marcar tarefa como concluída");
                Console.WriteLine("4. Remover tarefa concluída");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                switch (opcao) {
                    case "1":
                        AdicionarTarefa();
                        break;
                    case "2":
                        ListarTarefas();
                        break;
                    case "3":
                        MarcarTarefaComoConcluida();
                        break;
                    case "4":
                        RemoverTarefaConcluida();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
        static void AdicionarTarefa() {
            Console.Write("Digite a descrição da tarefa: ");
            string descricao = Console.ReadLine();
            tarefas.Add(new Tarefa(descricao));
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        static void ListarTarefas() {
            if (tarefas.Count == 0) {
                Console.WriteLine("Nenhuma tarefa na lista.");
                return;
            }

            Console.WriteLine("\nLista de Tarefas:");
            for (int i = 0; i < tarefas.Count; i++) {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }
        }

        static void MarcarTarefaComoConcluida() {
            ListarTarefas();
            Console.Write("Digite o número da tarefa que deseja marcar como concluída: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0 && numero <= tarefas.Count) {
                tarefas[numero - 1].MarcarComoConcluida();
                Console.WriteLine("Tarefa marcada como concluída!");
            }
            else {
                Console.WriteLine("Número inválido. Tente novamente.");
            }
        }

        static void RemoverTarefaConcluida() {
            ListarTarefas();
            Console.Write("Digite o número da tarefa concluída que deseja remover: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0 && numero <= tarefas.Count && tarefas[numero - 1].Concluida) {
                tarefas.RemoveAt(numero - 1);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else {
                Console.WriteLine("Número inválido ou tarefa não concluída. Tente novamente.");
            }
        }


    }
}

