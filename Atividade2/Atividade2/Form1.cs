using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class frmDinner : Form
    {
        public frmDinner()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboComida_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDinner.Text = cboComida.Text + "   "
                + cboMistura.Text + "   "
                + cboSalada.Text;
        }

        private void cboMistura_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboComida_SelectedIndexChanged(sender, e);
        }

        private void cboSalada_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboComida_SelectedIndexChanged(sender, e);
        }
    }
}
