using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeDS
{
    public partial class frmPedido : Form
    { 
        public frmPedido()
        {
            InitializeComponent();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmPedido_Load(object sender, EventArgs e)
        {

        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttEnvio_Click(object sender, EventArgs e)
        {
            string lanche = " ";
            string bebida = " ";
            string acomp = " ";
            int calorias = 0;

            // Verificação do lanche 
            if (rbtHotdog.Checked)
            {
                lanche = rbtHotdog.Text;
                calorias += 150; 
            }else if (rbtMistoquente.Checked)
            {
                lanche = rbtMistoquente.Text;
                calorias += 100;
            }else if (rbtXsalada.Checked)
            {
                lanche = rbtXsalada.Text;
                calorias += 180;
            }
            else if(rbtXburger.Checked){
                lanche = rbtXburger.Text;
                calorias += 160; 
            }else
            {
                lanche = rbtXbacon.Text;
                calorias += 180; 
            }

            //Verificação da bebida escolhida
            if (rbtSuco.Checked)
            {
                bebida = rbtSuco.Text;
                calorias += 60;
            }
            else if (rbtRefri.Checked)
            {
                bebida = rbtRefri.Text;
                calorias += 80;
            }
            else if (rbtCerveja.Checked)
            {
                bebida = rbtCerveja.Text;
                calorias += 120;
            }
            else if (rbtAgua.Checked)
            {
                bebida = rbtAgua.Text;
                calorias += 0;
            }
            else {
                bebida = rbtChopp.Text;
                calorias += 90;
            }
            //Verificaçãqo do acompanhamento escolhido
            if (rbtBatatafrita.Checked)
            {
                acomp = rbtBatatafrita.Text;
                calorias += 170;
            }
            else if (rbtMandioca.Checked)
            {
                acomp = rbtMandioca.Text;
                calorias += 190;
            }
            else if (rbtPolentafrita.Checked)
            {
                acomp = rbtPolentafrita.Text;
                calorias += 160;
            }
            else if (rbtSalada.Checked)
            {
                acomp = rbtSalada.Text;
                calorias += 30;
            }
            else {
                acomp = rbtPolvo.Text;
                calorias += 220;
            }
            if (calorias < 351){
                txtStatus.Text = String.Format("Assim está bom");
            }
            else {
                txtStatus.Text = String.Format("Você vai acabar engordando!");
            }
            txtPedido.Text = String.Format("Lanche: {0}. Bebida: {1}. Acompanhamento: {2}.", lanche, bebida, acomp);
            txtCaloria.Text = String.Format("{0} Kcal", calorias);
        }
    }
}
