using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // System.Diagnostics.Process -> permite iniciar programas externos

namespace Menu_Calculos.Formularios
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        void MDI_Warning_Message()
        {
            MessageBox.Show("Uma janela já foi aberta. Feche-a para abrir uma nova!",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
        private bool FormAberto(Type tipoForm)
        {
            foreach (Form form in MdiChildren)
            {
                if (form.GetType() == tipoForm) //tipoForm retorna qual instância atual
                {
                    MessageBox.Show(tipoForm.ToString());
                    form.Focus(); // traz para frente
                    return true; // retorna true caso já exita um form do mesmo type aberto. 
                }
            }
            return false;
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {
            nameUserLabel.Text = $"Usuário atual: {Environment.UserDomainName} \\ {Environment.UserName}";
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAberto(typeof(frmCalculosBot))) // executa apenas se MdiChildren estiver vazio.
            {
                frmCalculosBot frmCalculos = new frmCalculosBot();
                frmCalculos.MdiParent = this; // indica se essa nova instancia é parente de MDI
                //this indica o form MDI atual

                // new frmCalculosBot() cria/instância uma nova janela da calculadora

            
                frmCalculos.Show();
                // ShowDialog() impede de clicar na tela de fundo enquando frmCalculosBot estiver aberto
            }
            else
            {
                MDI_Warning_Message();
            }
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "notepad.exe"; // permite a abertura do notepad.

            Process.Start(startInfo);
        }

        private void cálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Saindo...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.No){
                e.Cancel = true;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora_label.Text = $"Data: {DateTime.Now.ToString("dd/MM/yyyy")} Horas: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void calculadoraWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "calc.exe"; // permite a abertura do notepad.

            Process.Start(startInfo);
        }

        private void navegadorWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "firefox.exe";

            Process.Start(startInfo);
        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAberto(typeof(frmRadio)))
            {
                frmRadio frmRadio = new frmRadio();
                frmRadio.MdiParent = this;
                frmRadio.Show();
                return;
            }
            else
            {
                MDI_Warning_Message();
            }
        }

        private void visorÚnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAberto(typeof(frmVisorUnico)))
            {
                frmVisorUnico frmVisorUnico = new frmVisorUnico();
                frmVisorUnico.MdiParent = this;
                frmVisorUnico.Show();
            }
            else
            {
                MDI_Warning_Message();
            }
        }
        
        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        
        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void vertucalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
