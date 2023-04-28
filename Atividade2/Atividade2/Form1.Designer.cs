
namespace Atividade2
{
    partial class frmDinner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboComida = new System.Windows.Forms.ComboBox();
            this.cboMistura = new System.Windows.Forms.ComboBox();
            this.cboSalada = new System.Windows.Forms.ComboBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblMistura = new System.Windows.Forms.Label();
            this.lblSalada = new System.Windows.Forms.Label();
            this.txtDinner = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboComida
            // 
            this.cboComida.FormattingEnabled = true;
            this.cboComida.Items.AddRange(new object[] {
            "Arroz",
            "Macarrão",
            "Feijão",
            "Arroz e Feijão"});
            this.cboComida.Location = new System.Drawing.Point(147, 126);
            this.cboComida.Name = "cboComida";
            this.cboComida.Size = new System.Drawing.Size(121, 21);
            this.cboComida.TabIndex = 0;
            this.cboComida.Text = "(Selecione)";
            this.cboComida.SelectedIndexChanged += new System.EventHandler(this.cboComida_SelectedIndexChanged);
            // 
            // cboMistura
            // 
            this.cboMistura.FormattingEnabled = true;
            this.cboMistura.Items.AddRange(new object[] {
            "Ovo",
            "Bisteca de porco",
            "Frango Assado",
            "Bife à Milanesa",
            "Calabresa Acebolada",
            "Filé de frango Grelhado",
            "Peixe Frito"});
            this.cboMistura.Location = new System.Drawing.Point(440, 126);
            this.cboMistura.Name = "cboMistura";
            this.cboMistura.Size = new System.Drawing.Size(121, 21);
            this.cboMistura.TabIndex = 0;
            this.cboMistura.Text = "(Selecione)";
            this.cboMistura.SelectedIndexChanged += new System.EventHandler(this.cboMistura_SelectedIndexChanged);
            // 
            // cboSalada
            // 
            this.cboSalada.FormattingEnabled = true;
            this.cboSalada.Items.AddRange(new object[] {
            "Alface",
            "Pepino",
            "Brócoles",
            "Tomate",
            "Agrião",
            "Rúcula",
            "Couve-Flor"});
            this.cboSalada.Location = new System.Drawing.Point(779, 126);
            this.cboSalada.Name = "cboSalada";
            this.cboSalada.Size = new System.Drawing.Size(121, 21);
            this.cboSalada.TabIndex = 0;
            this.cboSalada.Text = "(Selecione)";
            this.cboSalada.SelectedIndexChanged += new System.EventHandler(this.cboSalada_SelectedIndexChanged);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(147, 107);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(45, 13);
            this.lblComida.TabIndex = 1;
            this.lblComida.Text = "Comida:";
            // 
            // lblMistura
            // 
            this.lblMistura.AutoSize = true;
            this.lblMistura.Location = new System.Drawing.Point(449, 107);
            this.lblMistura.Name = "lblMistura";
            this.lblMistura.Size = new System.Drawing.Size(44, 13);
            this.lblMistura.TabIndex = 1;
            this.lblMistura.Text = "Mistura:";
            // 
            // lblSalada
            // 
            this.lblSalada.AutoSize = true;
            this.lblSalada.Location = new System.Drawing.Point(776, 107);
            this.lblSalada.Name = "lblSalada";
            this.lblSalada.Size = new System.Drawing.Size(43, 13);
            this.lblSalada.TabIndex = 1;
            this.lblSalada.Text = "Salada:";
            // 
            // txtDinner
            // 
            this.txtDinner.Location = new System.Drawing.Point(181, 287);
            this.txtDinner.Name = "txtDinner";
            this.txtDinner.ReadOnly = true;
            this.txtDinner.Size = new System.Drawing.Size(719, 20);
            this.txtDinner.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(356, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(428, 39);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1163, 578);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDinner);
            this.Controls.Add(this.lblSalada);
            this.Controls.Add(this.lblMistura);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.cboSalada);
            this.Controls.Add(this.cboMistura);
            this.Controls.Add(this.cboComida);
            this.Name = "frmDinner";
            this.Text = "Programa Refeição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboComida;
        private System.Windows.Forms.ComboBox cboMistura;
        private System.Windows.Forms.ComboBox cboSalada;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblMistura;
        private System.Windows.Forms.Label lblSalada;
        private System.Windows.Forms.TextBox txtDinner;
        private System.Windows.Forms.Button btnExit;
    }
}

