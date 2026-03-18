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

        private void MDI_Menu_Load(object sender, EventArgs e)
        {
            nameUserLabel.Text = $"Usuário atual: {Environment.UserDomainName} \\ {Environment.UserName}";
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0) // executa apenas se MdiChildren estiver vazio.
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
                MessageBox.Show("Uma janela já foi aberta. Feche-a para abrir uma nova!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void calculadoraWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "calculator.exe"; // permite a abertura do notepad.

            Process.Start(startInfo);
            */
        }

        private void navegadorWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "firefox.exe";

            Process.Start(startInfo);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //frmCalculosBot frmCalculosBot = new frmCalculosBot();
            //frmCalculosBot.();
        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0)
            {
                frmRadio frmRadio = new frmRadio();
                frmRadio.MdiParent = this;
                frmRadio.Show();
                return;
            }
            else
            {
                MessageBox.Show("Uma janela já foi aberta. Feche-a para abrir uma nova!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
