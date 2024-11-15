using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List {
    class Tarefa {
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public Tarefa(string descricao) {
            Descricao = descricao;
            Concluida = false;
        }

        public void MarcarComoConcluida() {
            Concluida = true;
        }

        public override string ToString() {
            return Concluida ? $"[X] {Descricao}" : $"[ ] {Descricao}";

        }
    }
}
