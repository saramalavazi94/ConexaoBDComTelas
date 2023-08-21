namespace ConexaoBDComTelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void atualizaInterface()
        {
            Tarefa tarefa= new Tarefa();
            List<Tarefa> tarefas =  tarefa.buscaTods();
            foreach( Tarefa t in tarefas)
            {
                listTarefas.Items.Add( $"{t.id} - {t.descricao}" );
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaInterface();
            listTarefas.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string descricao = txtTarefa.Text;
            bool concluido = checkBoxConcluido.Checked;

            Tarefa tarefa = new Tarefa();
            tarefa.descricao = descricao;
            tarefa.concluido= concluido;
            tarefa.Insere( tarefa );

            MessageBox.Show("Tarefa cadastrada com sucesso!");
            atualizaInterface();

            txtTarefa.Clear();
            checkBoxConcluido.Checked= false;

        }
    }
}