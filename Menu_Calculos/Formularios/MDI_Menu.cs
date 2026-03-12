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

        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculosBot frmCalculos = new frmCalculosBot(); 
            // new frmCalculosBot() cria uma nova janela da calculadora
            
            frmCalculos.ShowDialog(); 
            // ShowDialog() impede de clicar na tela de fundo enquando frmCalculosBot estiver aberto
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "notepad.exe"; // permite a abertura do notepad.

            Process.Start(startInfo);
        }
    }
}
