using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // new frmCalculosBot() cria uma nova janela
            
            frmCalculos.ShowDialog(); 
            // ShowDialog() impede de clicar na tela de fundo enquando frmCalculosBot estiver aberto
        }
    }
}
