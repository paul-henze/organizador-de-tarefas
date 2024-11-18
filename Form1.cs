using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace GerenciadordeTarefas
{
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //botao para adicionar tarefas
        {
            if (!string.IsNullOrWhiteSpace(TarefaAdicionar.Text))
            {
                string tarefa = "- " + TarefaAdicionar.Text;
                switch (true)
                {
                    case var _ when semUrgencia_btn.Checked:
                        LBListaAgSu.Items.Add(tarefa);
                        break;

                    case var _ when importante_btn.Checked:
                        LBListaAgImp.Items.Add(tarefa);
                        break;

                    case var _ when muitoImportante_btn.Checked:
                        LBListaAgMImp.Items.Add(tarefa);
                        break;

                    default:
                        MessageBox.Show("Por favor, Insira uma tarefa.");
                        return;
                }
                TarefaAdicionar.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, Insira uma tarefa.");
            }
                                    
                           
        
        }
        private void Main_frm_Load(object sender, EventArgs e)
        {

        }

        private void ListaAg_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e) //botao para remover tarefas
        {

            var listas = new List<ListBox>
            {

                LBListaAgSu, LBListaAgImp, LBListaAgMImp,
                LBListaAnSu, LBListaAnImp, LBListaAnMImp,
                LBListaFinSu, LBListaFinImp, LBListaFinMImp,

            };
            bool itemRemovido = false;

            foreach (var lista in listas)
            {
                if (lista.SelectedItem != null)
                {
                    lista.Items.Remove(lista.SelectedItem);
                    itemRemovido = true;
                    break;
                }
            }
            if (!itemRemovido)
            {
                MessageBox.Show("Selecione uma tarefa para remover.");
            }
                        
        }    

        private void MoverDir1_Click(object sender, EventArgs e) //botao para mover tarefas de aguardando >> andamento
        {

            var listas = new List<(ListBox origem, ListBox destino)>
            {
                 
                (LBListaAgSu, LBListaAnSu),
                (LBListaAgImp, LBListaAnImp),
                (LBListaAgMImp, LBListaAnMImp)

            };
            foreach (var (origem, destino) in listas)
            {
                if (origem.SelectedItem != null)
                {
                    destino.Items.Add(origem.SelectedItem);
                    origem.Items.Remove(origem.SelectedItem);
                    break;
                }
            }
            

        }

        private void MoverDir2_Click(object sender, EventArgs e) //botao para mover tarefas de andamento >> finalizado
        {

            var listas = new List<(ListBox origem, ListBox destino)>
            {

                (LBListaAnSu, LBListaFinSu),
                (LBListaAnImp, LBListaFinImp),
                (LBListaAnMImp, LBListaFinMImp)

            };
            foreach (var (origem, destino) in listas)
            {
                if (origem.SelectedItem != null)
                {
                    destino.Items.Add(origem.SelectedItem);
                    origem.Items.Remove(origem.SelectedItem);
                    break;
                }
            }
            
        }

        private void MoverEsq2_Click(object sender, EventArgs e) //botao para mover tarefas de finalizado >> andamento
        {

            var listas = new List<(ListBox origem, ListBox destino)>
            {

                (LBListaFinSu, LBListaAnSu),
                (LBListaFinImp, LBListaAnImp),
                (LBListaFinMImp, LBListaAnMImp)

            };
            foreach (var (origem, destino) in listas)
            {
                if (origem.SelectedItem != null)
                {
                    destino.Items.Add(origem.SelectedItem);
                    origem.Items.Remove(origem.SelectedItem);
                    break;
                }
            }
            
        }

        private void MoverEsq1_Click(object sender, EventArgs e) //botao para mover tarefas de andamento >> aguardando
        {

            var listas = new List<(ListBox origem, ListBox destino)>
            {

                (LBListaAnSu, LBListaAgSu),
                (LBListaAnImp, LBListaAgImp),
                (LBListaAnMImp, LBListaAgMImp)

            };
            foreach (var (origem, destino) in listas)
            {
                if (origem.SelectedItem != null)
                {
                    destino.Items.Add(origem.SelectedItem);
                    origem.Items.Remove(origem.SelectedItem);
                    break;
                }
            }
            
        }

        private void ListaAn_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LBListaAnMImp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBListaFinImp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBListaAgMImp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
