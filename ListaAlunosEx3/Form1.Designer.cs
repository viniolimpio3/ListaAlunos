namespace ListaAlunosEx3 {
    partial class frmAlunos {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtRA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dataGridAlunos = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(14, 36);
            this.txtRA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(114, 27);
            this.txtRA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "RA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 36);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(381, 27);
            this.txtNome.TabIndex = 2;
            // 
            // dataGridAlunos
            // 
            this.dataGridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.RA});
            this.dataGridAlunos.Location = new System.Drawing.Point(14, 93);
            this.dataGridAlunos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridAlunos.Name = "dataGridAlunos";
            this.dataGridAlunos.RowHeadersWidth = 51;
            this.dataGridAlunos.RowTemplate.Height = 25;
            this.dataGridAlunos.Size = new System.Drawing.Size(722, 381);
            this.dataGridAlunos.TabIndex = 4;
            this.dataGridAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAlunos_CellContentClick);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 125;
            // 
            // RA
            // 
            this.RA.HeaderText = "RA";
            this.RA.MinimumWidth = 6;
            this.RA.Name = "RA";
            this.RA.Width = 125;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(808, 34);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 31);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Cadastrar Aluno";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(547, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 31);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar por RA";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(757, 132);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(137, 31);
            this.btnUltimo.TabIndex = 7;
            this.btnUltimo.Text = "Retorna Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(757, 93);
            this.btnPrimeiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(137, 31);
            this.btnPrimeiro.TabIndex = 8;
            this.btnPrimeiro.Text = "Retorna Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(667, 35);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(135, 31);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover por RA";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 488);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dataGridAlunos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRA);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAlunos";
            this.Text = "Cadastrar Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRA;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private DataGridView dataGridAlunos;
        private Button btnSalvar;
        private Button btnBuscar;
        private Button btnUltimo;
        private Button btnPrimeiro;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn RA;
        private Button btnRemover;
    }
}