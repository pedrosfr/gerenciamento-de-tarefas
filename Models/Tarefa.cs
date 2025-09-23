using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace gerenciador_de_tarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Prazo { get; set; }
        public bool Concluido { get; set; }

        public Tarefa()
        {

        }

        public Tarefa(int id, string titulo, string descricao, DateTime datacriacao, DateTime prazo, bool concluido)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = datacriacao;
            Prazo = prazo;
            Concluido = concluido;
        }

        public void MarcarComoConcluido()
        {
            Concluido = true;
        }
        public void EditarTitulo(string novaTitulo)
        {
            Titulo = novaTitulo;
            
        }
        public void EditarDescricao(string novaDescricao)
        {
            Descricao = novaDescricao;
        }

        public override string ToString()
        {
            return $"Título: {Titulo} | Descrição: {Descricao} | Prazo: {Prazo} | Concluído: {Concluido}";
        }

    }
}