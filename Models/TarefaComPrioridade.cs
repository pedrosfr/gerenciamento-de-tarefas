using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gerenciador_de_tarefas.Models
{
    public class TarefaComPrioridade : Tarefa
    {
        public int NivelDePrioridade { get; set; }

        public TarefaComPrioridade()
        {

        }

        public TarefaComPrioridade(int id, string titulo, string descricao, DateTime datacriacao, DateTime prazo, bool concluido, int nivelDePrioridade)
        : base(id, titulo, descricao, datacriacao, prazo, concluido)
        {
            NivelDePrioridade = nivelDePrioridade;

        }
        
        
        
    }
}