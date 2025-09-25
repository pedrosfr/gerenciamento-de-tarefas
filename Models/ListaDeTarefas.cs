using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace gerenciador_de_tarefas.Models
{
    public class ListaDeTarefas
    {
        public List<Tarefa> Tarefa { get; set; } = new List<Tarefa>();

        public ListaDeTarefas()
        {

        }

        public void Adicionar(Tarefa t)
        {
            Tarefa.Add(t);
        }
        public void Remover(Tarefa t)
        {
            Tarefa.Remove(t);
        }
        public void ListarTodas()
        {
            if (Tarefa == null || Tarefa.Count == 0)
            {
                System.Console.WriteLine("Nenhuma Tarefa Cadastrada!");
                return;
            }
            foreach (Tarefa t in Tarefa)
            {
                if (t != null)
                {
                    t.Exibir();
                }

                else
                {
                    Console.WriteLine("Não Existe nenhuma Tarefa");
                }
            }
        }
        public void Buscar(string titulo)
        {
            bool encontrado = false;

            foreach (Tarefa t in Tarefa)
            {
                if (t.Titulo != null && t.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    t.Exibir();
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Título não encontrado!");
            }

        }






    }
}