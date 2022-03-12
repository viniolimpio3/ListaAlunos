using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlunosEx3 {
    class Lista {

        private const int CAPACIDADE = 32;
        private Aluno[] dados = new Aluno[CAPACIDADE];
        private int quantidade = 0;
        public int Tamanho() {
            return quantidade;
        }
        public void InsereNaPosicao(int p_posicao, Aluno aluno) {
            if (Tamanho() == CAPACIDADE)
                throw new Exception("A lista está cheia!!!\n\n");
            else if (p_posicao > Tamanho())
                throw new Exception("Não é possível inserir nesta posição");
            else {
                quantidade++;
                for (int i = Tamanho() - 1; i > p_posicao; i--) {
                    dados[i] = dados[i - 1];
                }
                dados[p_posicao] = aluno;
            }
        }
        public Aluno RemoveAluno(string ra) {

            int posicao = -1;

            if (Tamanho() == 0)
                throw new Exception("A lista está vazia!!!");
            else if (string.IsNullOrEmpty(ra))
                throw new Exception("RA Nulo!!!");
            else {

                Aluno a = new Aluno();
                for (int i = 0; i < this.Tamanho(); i++) {
                    if (dados[i] == null || dados[i].RA != ra)
                        continue;

                    posicao = i;
                    break;
                }

                if (posicao < 0)
                    throw new Exception("Aluno não encontrado!");

                Aluno aux = dados[posicao];

                for (int i = posicao; i < Tamanho() - 1; i++) 
                    dados[i] = dados[i + 1];
                
                quantidade--;
                return aux;
            }
        }
        public void InsereNoInicio(Aluno aluno) {
            InsereNaPosicao(0, aluno);
        }
        public void InsereNoFim(Aluno aluno) {
            InsereNaPosicao(Tamanho(), aluno);
        }

        public Aluno RetornaPrimeiro() {
            if (this.Tamanho() == 0)
                throw new Exception("Lista de Alunos Vazia");

            return dados[0];
        }

        public Aluno RetornaUltimo() {
            if (this.Tamanho() == 0)
                throw new Exception("Lista de Alunos Vazia");

            return dados[this.Tamanho()];
        }

        /// <summary>
        /// Busca um Aluno por RA
        /// </summary>
        /// <param name="ra"> RA </param>
        /// <returns> Aluno Encontrado </returns>
        public Aluno BuscaRA(string ra) {

            ra = ra.Trim();

            if(string.IsNullOrEmpty(ra))
                throw new Exception("RA não pode ser Vazio ou Nulo!");

            Aluno a = new Aluno();

            for (int i = 0; i < this.Tamanho(); i++) {
                if (dados[i] == null || dados[i].RA != ra)
                    continue;

                a = dados[i];
                break;
            }

            return a;
        }
        
        public Aluno[] RetornaDados() {

            if (this.Tamanho() == 0) 
                throw new Exception("A lista de Alunos está vazia!");
            
            Aluno[] alunos = new Aluno[this.Tamanho()];
            for (int i = 0; i < this.Tamanho(); i++) {
                alunos[i] = this.dados[i];
            }
            return alunos;
        }

    }
}
