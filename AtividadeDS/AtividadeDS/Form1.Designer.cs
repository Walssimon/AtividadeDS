
namespace AtividadeDS
{
    partial class frmPedido
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
            this.bttExit = new System.Windows.Forms.Button();
            this.bttEnvio = new System.Windows.Forms.Button();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblCaloria = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtCaloria = new System.Windows.Forms.TextBox();
            this.gbrLanche = new System.Windows.Forms.GroupBox();
            this.rbtHotdog = new System.Windows.Forms.RadioButton();
            this.rbtMistoquente = new System.Windows.Forms.RadioButton();
            this.rbtXsalada = new System.Windows.Forms.RadioButton();
            this.rbtXburger = new System.Windows.Forms.RadioButton();
            this.grbBebida = new System.Windows.Forms.GroupBox();
            this.rbtSuco = new System.Windows.Forms.RadioButton();
            this.rbtCerveja = new System.Windows.Forms.RadioButton();
            this.rbtRefri = new System.Windows.Forms.RadioButton();
            this.grbAcomp = new System.Windows.Forms.GroupBox();
            this.rbtBatatafrita = new System.Windows.Forms.RadioButton();
            this.rbtPolentafrita = new System.Windows.Forms.RadioButton();
            this.rbtSalada = new System.Windows.Forms.RadioButton();
            this.rbtMandioca = new System.Windows.Forms.RadioButton();
            this.fundo = new System.Windows.Forms.Panel();
            this.rbtXbacon = new System.Windows.Forms.RadioButton();
            this.rbtChopp = new System.Windows.Forms.RadioButton();
            this.rbtAgua = new System.Windows.Forms.RadioButton();
            this.rbtPolvo = new System.Windows.Forms.RadioButton();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbrLanche.SuspendLayout();
            this.grbBebida.SuspendLayout();
            this.grbAcomp.SuspendLayout();
            this.fundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttExit
            // 
            this.bttExit.ForeColor = System.Drawing.Color.Black;
            this.bttExit.Location = new System.Drawing.Point(936, 643);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(194, 34);
            this.bttExit.TabIndex = 1;
            this.bttExit.Text = "Sair";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // bttEnvio
            // 
            this.bttEnvio.Location = new System.Drawing.Point(556, 453);
            this.bttEnvio.Name = "bttEnvio";
            this.bttEnvio.Size = new System.Drawing.Size(239, 40);
            this.bttEnvio.TabIndex = 0;
            this.bttEnvio.Text = "Enviar Pedido";
            this.bttEnvio.UseVisualStyleBackColor = true;
            this.bttEnvio.Click += new System.EventHandler(this.bttEnvio_Click);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(81, 541);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(88, 13);
            this.lblPedido.TabIndex = 2;
            this.lblPedido.Text = "Pedido realizado:";
            // 
            // lblCaloria
            // 
            this.lblCaloria.AutoSize = true;
            this.lblCaloria.Location = new System.Drawing.Point(81, 617);
            this.lblCaloria.Name = "lblCaloria";
            this.lblCaloria.Size = new System.Drawing.Size(88, 13);
            this.lblCaloria.TabIndex = 2;
            this.lblCaloria.Text = "Total de calorias:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(84, 569);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(688, 20);
            this.txtPedido.TabIndex = 3;
            // 
            // txtCaloria
            // 
            this.txtCaloria.Location = new System.Drawing.Point(84, 643);
            this.txtCaloria.Name = "txtCaloria";
            this.txtCaloria.Size = new System.Drawing.Size(350, 20);
            this.txtCaloria.TabIndex = 3;
            // 
            // gbrLanche
            // 
            this.gbrLanche.Controls.Add(this.rbtXbacon);
            this.gbrLanche.Controls.Add(this.rbtXburger);
            this.gbrLanche.Controls.Add(this.rbtXsalada);
            this.gbrLanche.Controls.Add(this.rbtMistoquente);
            this.gbrLanche.Controls.Add(this.rbtHotdog);
            this.gbrLanche.Location = new System.Drawing.Point(84, 66);
            this.gbrLanche.Name = "gbrLanche";
            this.gbrLanche.Size = new System.Drawing.Size(239, 262);
            this.gbrLanche.TabIndex = 4;
            this.gbrLanche.TabStop = false;
            this.gbrLanche.Text = "Lanches";
            // 
            // rbtHotdog
            // 
            this.rbtHotdog.AutoSize = true;
            this.rbtHotdog.Location = new System.Drawing.Point(21, 36);
            this.rbtHotdog.Name = "rbtHotdog";
            this.rbtHotdog.Size = new System.Drawing.Size(65, 17);
            this.rbtHotdog.TabIndex = 0;
            this.rbtHotdog.TabStop = true;
            this.rbtHotdog.Text = "Hot-Dog";
            this.rbtHotdog.UseVisualStyleBackColor = true;
            // 
            // rbtMistoquente
            // 
            this.rbtMistoquente.AutoSize = true;
            this.rbtMistoquente.Location = new System.Drawing.Point(21, 84);
            this.rbtMistoquente.Name = "rbtMistoquente";
            this.rbtMistoquente.Size = new System.Drawing.Size(88, 17);
            this.rbtMistoquente.TabIndex = 0;
            this.rbtMistoquente.TabStop = true;
            this.rbtMistoquente.Text = "Misto-Quente";
            this.rbtMistoquente.UseVisualStyleBackColor = true;
            // 
            // rbtXsalada
            // 
            this.rbtXsalada.AutoSize = true;
            this.rbtXsalada.Location = new System.Drawing.Point(21, 133);
            this.rbtXsalada.Name = "rbtXsalada";
            this.rbtXsalada.Size = new System.Drawing.Size(68, 17);
            this.rbtXsalada.TabIndex = 0;
            this.rbtXsalada.TabStop = true;
            this.rbtXsalada.Text = "X-Salada";
            this.rbtXsalada.UseVisualStyleBackColor = true;
            // 
            // rbtXburger
            // 
            this.rbtXburger.AutoSize = true;
            this.rbtXburger.Location = new System.Drawing.Point(19, 176);
            this.rbtXburger.Name = "rbtXburger";
            this.rbtXburger.Size = new System.Drawing.Size(66, 17);
            this.rbtXburger.TabIndex = 0;
            this.rbtXburger.TabStop = true;
            this.rbtXburger.Text = "X-Burger";
            this.rbtXburger.UseVisualStyleBackColor = true;
            // 
            // grbBebida
            // 
            this.grbBebida.Controls.Add(this.rbtAgua);
            this.grbBebida.Controls.Add(this.rbtRefri);
            this.grbBebida.Controls.Add(this.rbtChopp);
            this.grbBebida.Controls.Add(this.rbtCerveja);
            this.grbBebida.Controls.Add(this.rbtSuco);
            this.grbBebida.Location = new System.Drawing.Point(510, 66);
            this.grbBebida.Name = "grbBebida";
            this.grbBebida.Size = new System.Drawing.Size(278, 283);
            this.grbBebida.TabIndex = 4;
            this.grbBebida.TabStop = false;
            this.grbBebida.Text = "Bebidas";
            // 
            // rbtSuco
            // 
            this.rbtSuco.AutoSize = true;
            this.rbtSuco.Location = new System.Drawing.Point(29, 36);
            this.rbtSuco.Name = "rbtSuco";
            this.rbtSuco.Size = new System.Drawing.Size(50, 17);
            this.rbtSuco.TabIndex = 0;
            this.rbtSuco.TabStop = true;
            this.rbtSuco.Text = "Suco";
            this.rbtSuco.UseVisualStyleBackColor = true;
            // 
            // rbtCerveja
            // 
            this.rbtCerveja.AutoSize = true;
            this.rbtCerveja.Location = new System.Drawing.Point(29, 114);
            this.rbtCerveja.Name = "rbtCerveja";
            this.rbtCerveja.Size = new System.Drawing.Size(61, 17);
            this.rbtCerveja.TabIndex = 0;
            this.rbtCerveja.TabStop = true;
            this.rbtCerveja.Text = "Cerveja";
            this.rbtCerveja.UseVisualStyleBackColor = true;
            this.rbtCerveja.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rbtRefri
            // 
            this.rbtRefri.AutoSize = true;
            this.rbtRefri.Location = new System.Drawing.Point(29, 75);
            this.rbtRefri.Name = "rbtRefri";
            this.rbtRefri.Size = new System.Drawing.Size(83, 17);
            this.rbtRefri.TabIndex = 0;
            this.rbtRefri.TabStop = true;
            this.rbtRefri.Text = "Refrigerante";
            this.rbtRefri.UseVisualStyleBackColor = true;
            // 
            // grbAcomp
            // 
            this.grbAcomp.Controls.Add(this.rbtMandioca);
            this.grbAcomp.Controls.Add(this.rbtPolvo);
            this.grbAcomp.Controls.Add(this.rbtSalada);
            this.grbAcomp.Controls.Add(this.rbtPolentafrita);
            this.grbAcomp.Controls.Add(this.rbtBatatafrita);
            this.grbAcomp.Location = new System.Drawing.Point(903, 66);
            this.grbAcomp.Name = "grbAcomp";
            this.grbAcomp.Size = new System.Drawing.Size(278, 283);
            this.grbAcomp.TabIndex = 4;
            this.grbAcomp.TabStop = false;
            this.grbAcomp.Text = "Acompanhamentos";
            // 
            // rbtBatatafrita
            // 
            this.rbtBatatafrita.AutoSize = true;
            this.rbtBatatafrita.Location = new System.Drawing.Point(21, 27);
            this.rbtBatatafrita.Name = "rbtBatatafrita";
            this.rbtBatatafrita.Size = new System.Drawing.Size(79, 17);
            this.rbtBatatafrita.TabIndex = 0;
            this.rbtBatatafrita.TabStop = true;
            this.rbtBatatafrita.Text = "Batata Frita";
            this.rbtBatatafrita.UseVisualStyleBackColor = true;
            // 
            // rbtPolentafrita
            // 
            this.rbtPolentafrita.AutoSize = true;
            this.rbtPolentafrita.Location = new System.Drawing.Point(21, 124);
            this.rbtPolentafrita.Name = "rbtPolentafrita";
            this.rbtPolentafrita.Size = new System.Drawing.Size(84, 17);
            this.rbtPolentafrita.TabIndex = 0;
            this.rbtPolentafrita.TabStop = true;
            this.rbtPolentafrita.Text = "Polenta Frita";
            this.rbtPolentafrita.UseVisualStyleBackColor = true;
            this.rbtPolentafrita.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rbtSalada
            // 
            this.rbtSalada.AutoSize = true;
            this.rbtSalada.Location = new System.Drawing.Point(21, 176);
            this.rbtSalada.Name = "rbtSalada";
            this.rbtSalada.Size = new System.Drawing.Size(58, 17);
            this.rbtSalada.TabIndex = 0;
            this.rbtSalada.TabStop = true;
            this.rbtSalada.Text = "Salada";
            this.rbtSalada.UseVisualStyleBackColor = true;
            this.rbtSalada.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rbtMandioca
            // 
            this.rbtMandioca.AutoSize = true;
            this.rbtMandioca.Location = new System.Drawing.Point(21, 75);
            this.rbtMandioca.Name = "rbtMandioca";
            this.rbtMandioca.Size = new System.Drawing.Size(72, 17);
            this.rbtMandioca.TabIndex = 0;
            this.rbtMandioca.TabStop = true;
            this.rbtMandioca.Text = "Mandioca";
            this.rbtMandioca.UseVisualStyleBackColor = true;
            // 
            // fundo
            // 
            this.fundo.BackColor = System.Drawing.Color.Aqua;
            this.fundo.Controls.Add(this.label1);
            this.fundo.Controls.Add(this.txtStatus);
            this.fundo.Controls.Add(this.grbAcomp);
            this.fundo.Controls.Add(this.grbBebida);
            this.fundo.Controls.Add(this.gbrLanche);
            this.fundo.Controls.Add(this.txtCaloria);
            this.fundo.Controls.Add(this.txtPedido);
            this.fundo.Controls.Add(this.lblCaloria);
            this.fundo.Controls.Add(this.lblPedido);
            this.fundo.Controls.Add(this.bttEnvio);
            this.fundo.Controls.Add(this.bttExit);
            this.fundo.Location = new System.Drawing.Point(-2, -2);
            this.fundo.Name = "fundo";
            this.fundo.Size = new System.Drawing.Size(1269, 788);
            this.fundo.TabIndex = 0;
            // 
            // rbtXbacon
            // 
            this.rbtXbacon.AutoSize = true;
            this.rbtXbacon.Location = new System.Drawing.Point(19, 213);
            this.rbtXbacon.Name = "rbtXbacon";
            this.rbtXbacon.Size = new System.Drawing.Size(66, 17);
            this.rbtXbacon.TabIndex = 0;
            this.rbtXbacon.TabStop = true;
            this.rbtXbacon.Text = "X-Bacon";
            this.rbtXbacon.UseVisualStyleBackColor = true;
            // 
            // rbtChopp
            // 
            this.rbtChopp.AutoSize = true;
            this.rbtChopp.Location = new System.Drawing.Point(29, 194);
            this.rbtChopp.Name = "rbtChopp";
            this.rbtChopp.Size = new System.Drawing.Size(56, 17);
            this.rbtChopp.TabIndex = 0;
            this.rbtChopp.TabStop = true;
            this.rbtChopp.Text = "Chopp";
            this.rbtChopp.UseVisualStyleBackColor = true;
            this.rbtChopp.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rbtAgua
            // 
            this.rbtAgua.AutoSize = true;
            this.rbtAgua.Location = new System.Drawing.Point(29, 155);
            this.rbtAgua.Name = "rbtAgua";
            this.rbtAgua.Size = new System.Drawing.Size(50, 17);
            this.rbtAgua.TabIndex = 0;
            this.rbtAgua.TabStop = true;
            this.rbtAgua.Text = "Água";
            this.rbtAgua.UseVisualStyleBackColor = true;
            // 
            // rbtPolvo
            // 
            this.rbtPolvo.AutoSize = true;
            this.rbtPolvo.Location = new System.Drawing.Point(21, 223);
            this.rbtPolvo.Name = "rbtPolvo";
            this.rbtPolvo.Size = new System.Drawing.Size(127, 17);
            this.rbtPolvo.TabIndex = 0;
            this.rbtPolvo.TabStop = true;
            this.rbtPolvo.Text = "Provolone à Milanesa";
            this.rbtPolvo.UseVisualStyleBackColor = true;
            this.rbtPolvo.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(450, 643);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(322, 20);
            this.txtStatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 758);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wersington e Walssimon Sacramento 20806 e 20811";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.fundo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmPedido";
            this.Text = "O Programa de Calorias ";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.gbrLanche.ResumeLayout(false);
            this.gbrLanche.PerformLayout();
            this.grbBebida.ResumeLayout(false);
            this.grbBebida.PerformLayout();
            this.grbAcomp.ResumeLayout(false);
            this.grbAcomp.PerformLayout();
            this.fundo.ResumeLayout(false);
            this.fundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Button bttEnvio;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblCaloria;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtCaloria;
        private System.Windows.Forms.GroupBox gbrLanche;
        private System.Windows.Forms.RadioButton rbtXburger;
        private System.Windows.Forms.RadioButton rbtXsalada;
        private System.Windows.Forms.RadioButton rbtMistoquente;
        private System.Windows.Forms.RadioButton rbtHotdog;
        private System.Windows.Forms.GroupBox grbBebida;
        private System.Windows.Forms.RadioButton rbtRefri;
        private System.Windows.Forms.RadioButton rbtCerveja;
        private System.Windows.Forms.RadioButton rbtSuco;
        private System.Windows.Forms.GroupBox grbAcomp;
        private System.Windows.Forms.RadioButton rbtMandioca;
        private System.Windows.Forms.RadioButton rbtSalada;
        private System.Windows.Forms.RadioButton rbtPolentafrita;
        private System.Windows.Forms.RadioButton rbtBatatafrita;
        private System.Windows.Forms.Panel fundo;
        private System.Windows.Forms.RadioButton rbtXbacon;
        private System.Windows.Forms.RadioButton rbtAgua;
        private System.Windows.Forms.RadioButton rbtChopp;
        private System.Windows.Forms.RadioButton rbtPolvo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
    }
}

