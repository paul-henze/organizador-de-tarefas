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
                                       

            /*
            if (semUrgencia_btn.Checked)
            {

                if (!string.IsNullOrWhiteSpace(TarefaAdicionar.Text))
                {
                    LBListaAgSu.Items.Add("- " + TarefaAdicionar.Text);
                    TarefaAdicionar.Clear();
                }
                else
                {
                    MessageBox.Show("Por Favor, Insira uma tarefa.");
                }
            }
            else if (importante_btn.Checked)
            {
                if (!string.IsNullOrWhiteSpace(TarefaAdicionar.Text))
                {
                    LBListaAgImp.Items.Add("- " + TarefaAdicionar.Text);
                    TarefaAdicionar.Clear();
                }
                else
                {
                    MessageBox.Show("Por Favor, Insira uma tarefa.");
                }
            }
            else if (muitoImportante_btn.Checked)
            {
                if (!string.IsNullOrWhiteSpace(TarefaAdicionar.Text))
                {
                    LBListaAgMImp.Items.Add("- " + TarefaAdicionar.Text);
                    TarefaAdicionar.Clear();
                }
                else
                {
                    MessageBox.Show("Por Favor, Insira uma tarefa.");
                }
            }
            */
                
        
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
            
            /*
             if (LBListaAgSu.SelectedItem != null)
             {

                 LBListaAgSu.Items.Remove(LBListaAgSu.SelectedItem);

             }
             else
             {
                 if (LBListaAnSu.SelectedItem != null)
                 {

                     LBListaAnSu.Items.Remove(LBListaAnSu.SelectedItem);

                 }
                 else
                 {
                     if (LBListaFinSu.SelectedItem != null)
                     {

                         LBListaFinSu.Items.Remove(LBListaFinSu.SelectedItem);

                     }
                     else
                     {
                         MessageBox.Show("Selecione uma tarefa para remover.");
                     }
                 }
             }
            */
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
            /*
            //Move tarefas sem urgencia
            if (LBListaAgSu.SelectedItem != null)
            {
                LBListaAnSu.Items.Add(LBListaAgSu.SelectedItem);
                LBListaAgSu.Items.Remove(LBListaAgSu.SelectedItem);
            }
            //move tarefas importantes
            if (LBListaAgImp.SelectedItem != null)
            {
                LBListaAnImp.Items.Add(LBListaAgImp.SelectedItem);
                LBListaAgImp.Items.Remove(LBListaAgImp.SelectedItem);
            }
            //move tarefas muito importantes
            if (LBListaAgMImp.SelectedItem != null)
            {
                LBListaAnMImp.Items.Add(LBListaAgMImp.SelectedItem);
                LBListaAgMImp.Items.Remove(LBListaAgMImp.SelectedItem);
            }
            */

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
            /*
            //move tarefas sem urgencia
            if (LBListaAnSu.SelectedItem != null)
            {
                LBListaFinSu.Items.Add(LBListaAnSu.SelectedItem);
                LBListaAnSu.Items.Remove(LBListaAnSu.SelectedItem);
            }
            //move tarefas importantes
            if (LBListaAnImp.SelectedItem != null)
            {
                LBListaFinImp.Items.Add(LBListaAnImp.SelectedItem);
                LBListaAnImp.Items.Remove(LBListaAnImp.SelectedItem);
            }
            //move tarefas muito importantes
            if (LBListaAnMImp.SelectedItem != null)
            {
                LBListaFinMImp.Items.Add(LBListaAnMImp.SelectedItem);
                LBListaAnMImp.Items.Remove(LBListaAnMImp.SelectedItem);
            }
            */
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
            /*
            //move tarefas sem urgencia
            if (LBListaFinSu.SelectedItem != null)
            {
                LBListaAnSu.Items.Add(LBListaFinSu.SelectedItem);
                LBListaFinSu.Items.Remove(LBListaFinSu.SelectedItem);
            }
            //move tarefas importantes
            if (LBListaFinImp.SelectedItem != null)
            {
                LBListaAnImp.Items.Add(LBListaFinImp.SelectedItem);
                LBListaFinImp.Items.Remove(LBListaFinImp.SelectedItem);
            }
            //move tarefas muito importantes
            if (LBListaFinMImp.SelectedItem != null)
            {
                LBListaAnMImp.Items.Add(LBListaFinMImp.SelectedItem);
                LBListaFinMImp.Items.Remove(LBListaFinMImp.SelectedItem);
            }
            */
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
            /*
            //move tarefas sem urgencia
            if (LBListaAnSu.SelectedItem != null)
            {
                LBListaAgSu.Items.Add(LBListaAnSu.SelectedItem);
                LBListaAnSu.Items.Remove(LBListaAnSu.SelectedItem);
            }
            //move tarefas importantes
            if (LBListaAnImp.SelectedItem != null)
            {
                LBListaAgImp.Items.Add(LBListaAnImp.SelectedItem);
                LBListaAnImp.Items.Remove(LBListaAnImp.SelectedItem);
            }
            //move tarefas muito importantes
            if (LBListaAnMImp.SelectedItem != null)
            {
                LBListaAgMImp.Items.Add(LBListaAnMImp.SelectedItem);
                LBListaAnMImp.Items.Remove(LBListaAnMImp.SelectedItem);
            }
            */
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
