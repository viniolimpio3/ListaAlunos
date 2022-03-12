namespace ListaAlunosEx3 {
    public partial class frmAlunos : Form {

        private Lista listaAlunos = new Lista();

        public frmAlunos() {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            try {
                ExibeAluno(listaAlunos.BuscaRA(txtRA.Text));
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {

                Aluno aluno = new Aluno(txtRA.Text, txtNome.Text);

                Aluno verificaAlunoExiste = listaAlunos.BuscaRA(aluno.RA);

                if (verificaAlunoExiste.RA != null)
                    throw new Exception("Já existe um aluno com esse RA!");

                listaAlunos.InsereNoFim(aluno);

                PreencheDadosGrid();

                MessageBox.Show("Aluno Cadastrado com Sucesso!");

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e) {
            try {

                ExibeAluno(listaAlunos.RetornaPrimeiro());

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            try {

                ExibeAluno(listaAlunos.RetornaUltimo());

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        static void ExibeAluno(Aluno aluno) {

            if (aluno == null || aluno.RA == null)
                throw new Exception("Aluno Nâo encontrado!");

            MessageBox.Show($"Nome do Aluno: {aluno.Nome}" + Environment.NewLine 
                + $"RA: {aluno.RA}");
        }

        public void PreencheDadosGrid() {

            Aluno[] alunos = listaAlunos.RetornaDados();

            dataGridAlunos.Rows.Clear();
           
            foreach(Aluno aluno in alunos) {
                DataGridViewRow row = (DataGridViewRow) dataGridAlunos.Rows[0].Clone();
                row.Cells[0].Value = aluno.Nome;
                row.Cells[1].Value = aluno.RA;
                dataGridAlunos.Rows.Add(row);
            }

        }

        private void dataGridAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnRemover_Click(object sender, EventArgs e) {
            try {
                
                Aluno alunoRemovido = listaAlunos.RemoveAluno(txtRA.Text);

                ExibeAluno(alunoRemovido); //Exibe Aluno Removido
                PreencheDadosGrid(); //Repreenche os dados no grid - pois os indices estão alterados

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}