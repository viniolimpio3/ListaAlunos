using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlunosEx3 {
    class Aluno {

        private string ra;
        private string nome;

        public Aluno() {

        }

        public Aluno(string ra, string nome) {
            this.RA = ra;
            this.Nome = nome;
        }

        public string RA { 
            get => this.ra; 
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Valor de RA Inválido!");

                this.ra = value;
            }
        }


        public string Nome {
            get => this.nome;
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Valor do Nome Inválido!");

                this.nome = value;
            }
        }
    }
}
