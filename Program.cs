using System.Collections.Specialized;
using gerenciador_de_tarefas.Models;
try
{
    ListaDeTarefas lista = new ListaDeTarefas();
    int opcao;
    do
    {
        Console.WriteLine();
        Console.WriteLine("=== Gerenciamento de Tarefas ===");
        Console.WriteLine("1 - Adicionar Tarefas");
        Console.WriteLine("2 - Listar Tarefas");
        Console.WriteLine("3 - Buscar Tarefa por título");
        Console.WriteLine("4 - Marcar Tarefa Concluído");
        Console.WriteLine("5 - Editar o Título da Tarefa");
        Console.WriteLine("6 - Editar a Descrição da Tarefa");
        Console.WriteLine("7 - Remover Tarefa");
        Console.WriteLine("0 - Sair");

        Console.Write("Escolha uma opção: ");
        opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            try
            {
                Console.Write("Digite o id da Tarefa: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Digite o título: ");
                string titulo = Console.ReadLine();

                Console.Write("Digite a descrição: ");
                string descricao = Console.ReadLine();

                Console.Write("Digite a Data da Criação (dd/mm/aaaa): ");
                DateTime datacriacao = DateTime.Parse(Console.ReadLine());

                Console.Write("Digite o prazo (dd/mm/aaaa): ");
                DateTime prazo = DateTime.Parse(Console.ReadLine());

                Console.Write("Nível de Prioridade da Tarefa: ");
                int nivelDePrioridade = int.Parse(Console.ReadLine());

                Tarefa t = new TarefaComPrioridade(id, titulo, descricao, datacriacao, prazo, concluido: false, nivelDePrioridade);
                lista.Adicionar(t);
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida! Verifique os dados digitados.");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Ocorreu um erro inesperado! " + ex.Message);

            }

        }
        else if (opcao == 2)
        {
            
                lista.ListarTodas();

        }
        else if (opcao == 3)
        {
            try
            {
                System.Console.Write("Digite o nome do título que deseja buscar: ");
                string titulo = Console.ReadLine();
                lista.Buscar(titulo);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro na busca! " + ex.Message);

            }
        }
        else if (opcao == 4)
        {
            System.Console.WriteLine("Digite o ID da Tarefa que deseja concluir: ");
            int id = int.Parse(Console.ReadLine());

            bool encontrado = false;
            foreach (Tarefa tarefa in lista.Tarefa)
            {
                if (tarefa.Id == id)
                {
                    tarefa.Concluido = true;
                    Console.WriteLine("Tarefa marcada como concluída!");
                    encontrado = true;

                }
                if (!encontrado)
                {
                    System.Console.WriteLine("Tarefa não encontrada!");
                }
            }
        }
        else if (opcao == 5)
        {

            Console.Write("Digite o ID para digitar um novo título: ");
            int id = int.Parse(Console.ReadLine());
            bool encontrada = false;
            foreach (Tarefa tarefa in lista.Tarefa)
            {
                if (tarefa.Id == id)
                {
                    Console.Write("Digite o novo título: ");
                    string novaTitulo = Console.ReadLine();
                    encontrada = true;
                    tarefa.EditarTitulo(novaTitulo);
                    Console.WriteLine("Título alterado com sucesso!");


                }
                else
                {
                    Console.WriteLine("ID Não encontrado!");
                }

            }
        }
        else if (opcao == 6)
        {
            Console.Write("Digite o ID para digitar uma nova descrição: ");
            int id = int.Parse(Console.ReadLine());
            bool encontrada = false;
            foreach (Tarefa tarefa in lista.Tarefa)
            {
                if (tarefa.Id == id)
                {
                    System.Console.Write("Digite uma nova descrição: ");
                    string novaDescricao = Console.ReadLine();
                    tarefa.EditarDescricao(novaDescricao);
                    encontrada = true;
                    Console.Write("Descrição alterada com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("ID Não encontrado!");
                }
            }
        }
        else if (opcao == 7)
        {
            try
            {
                System.Console.Write("Digite o ID para excluir a Tarefa: ");
                int id = int.Parse(Console.ReadLine());

                bool encontrada = false;

                for (int i = 0; i < lista.Tarefa.Count; i++)
                {
                    if (lista.Tarefa[i].Id == id)
                    {
                        lista.Remover(lista.Tarefa[i]);
                        encontrada = true;
                        Console.WriteLine("Tarefa excluída com sucesso!");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("ID Não encontrado!");
                    }
                }
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Tarefa não existe!");
            }

        }
        else if (opcao == 0)
        {
            System.Console.WriteLine("Saindo...");
        }
        else
        {
            System.Console.WriteLine("Opção inválida!");
        }


    } while (opcao != 0);
}
catch (Exception ex)
{
    Console.WriteLine("Erro inesperado! "+ex.Message);
}