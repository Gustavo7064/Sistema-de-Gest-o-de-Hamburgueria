namespace SistemaHamburgueria
{
    partial class Pedido
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.txtValorLanche = new System.Windows.Forms.TextBox();
            this.grpRetirar = new System.Windows.Forms.GroupBox();
            this.chkTomate = new System.Windows.Forms.CheckBox();
            this.chkBaconR = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkSalada = new System.Windows.Forms.CheckBox();
            this.lblValorLanche = new System.Windows.Forms.Label();
            this.cmbLanches = new System.Windows.Forms.ComboBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.grpAdicionar = new System.Windows.Forms.GroupBox();
            this.chkMolhoEspecial = new System.Windows.Forms.CheckBox();
            this.chkCatupiryA = new System.Windows.Forms.CheckBox();
            this.chkHabmburguer = new System.Windows.Forms.CheckBox();
            this.chkCheddar = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkCarne = new System.Windows.Forms.CheckBox();
            this.chkQueijo = new System.Windows.Forms.CheckBox();
            this.chkMolho = new System.Windows.Forms.CheckBox();
            this.chkMaionese = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.chkFrango = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.grpRetirar.SuspendLayout();
            this.grpAdicionar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(842, 365);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 40);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(562, 365);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 40);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(580, 144);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagar.TabIndex = 28;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(546, 53);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 27;
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(587, 119);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 26;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(528, 27);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 25;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // txtValorLanche
            // 
            this.txtValorLanche.Location = new System.Drawing.Point(492, 208);
            this.txtValorLanche.Name = "txtValorLanche";
            this.txtValorLanche.Size = new System.Drawing.Size(100, 20);
            this.txtValorLanche.TabIndex = 24;
            // 
            // grpRetirar
            // 
            this.grpRetirar.Controls.Add(this.chkFrango);
            this.grpRetirar.Controls.Add(this.chkMolho);
            this.grpRetirar.Controls.Add(this.chkQueijo);
            this.grpRetirar.Controls.Add(this.chkCarne);
            this.grpRetirar.Controls.Add(this.chkTomate);
            this.grpRetirar.Controls.Add(this.chkBaconR);
            this.grpRetirar.Controls.Add(this.chkCebola);
            this.grpRetirar.Controls.Add(this.chkSalada);
            this.grpRetirar.Location = new System.Drawing.Point(54, 236);
            this.grpRetirar.Name = "grpRetirar";
            this.grpRetirar.Size = new System.Drawing.Size(200, 150);
            this.grpRetirar.TabIndex = 23;
            this.grpRetirar.TabStop = false;
            this.grpRetirar.Text = "Deseja retirar algum incremento:";
            // 
            // chkTomate
            // 
            this.chkTomate.AutoSize = true;
            this.chkTomate.Location = new System.Drawing.Point(6, 88);
            this.chkTomate.Name = "chkTomate";
            this.chkTomate.Size = new System.Drawing.Size(62, 17);
            this.chkTomate.TabIndex = 4;
            this.chkTomate.Text = "Tomate";
            this.chkTomate.UseVisualStyleBackColor = true;
            // 
            // chkBaconR
            // 
            this.chkBaconR.AutoSize = true;
            this.chkBaconR.Location = new System.Drawing.Point(6, 65);
            this.chkBaconR.Name = "chkBaconR";
            this.chkBaconR.Size = new System.Drawing.Size(57, 17);
            this.chkBaconR.TabIndex = 3;
            this.chkBaconR.Text = "Bacon";
            this.chkBaconR.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(6, 42);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(62, 17);
            this.chkCebola.TabIndex = 2;
            this.chkCebola.Text = "Cebola ";
            this.chkCebola.UseVisualStyleBackColor = true;
            this.chkCebola.CheckedChanged += new System.EventHandler(this.chkCebola_CheckedChanged);
            // 
            // chkSalada
            // 
            this.chkSalada.AutoSize = true;
            this.chkSalada.Location = new System.Drawing.Point(6, 19);
            this.chkSalada.Name = "chkSalada";
            this.chkSalada.Size = new System.Drawing.Size(59, 17);
            this.chkSalada.TabIndex = 1;
            this.chkSalada.Text = "Salada";
            this.chkSalada.UseVisualStyleBackColor = true;
            // 
            // lblValorLanche
            // 
            this.lblValorLanche.AutoSize = true;
            this.lblValorLanche.Location = new System.Drawing.Point(484, 188);
            this.lblValorLanche.Name = "lblValorLanche";
            this.lblValorLanche.Size = new System.Drawing.Size(108, 13);
            this.lblValorLanche.TabIndex = 22;
            this.lblValorLanche.Text = "VALOR DO LANCHE";
            // 
            // cmbLanches
            // 
            this.cmbLanches.FormattingEnabled = true;
            this.cmbLanches.Location = new System.Drawing.Point(54, 41);
            this.cmbLanches.Name = "cmbLanches";
            this.cmbLanches.Size = new System.Drawing.Size(200, 21);
            this.cmbLanches.TabIndex = 20;
            this.cmbLanches.Text = "Opções";
            this.cmbLanches.SelectedIndexChanged += new System.EventHandler(this.cmbLanches_SelectedIndexChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(703, 365);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(112, 40);
            this.btnMenu.TabIndex = 19;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // grpAdicionar
            // 
            this.grpAdicionar.Controls.Add(this.chkMaionese);
            this.grpAdicionar.Controls.Add(this.chkBacon);
            this.grpAdicionar.Controls.Add(this.chkMolhoEspecial);
            this.grpAdicionar.Controls.Add(this.chkCatupiryA);
            this.grpAdicionar.Controls.Add(this.chkHabmburguer);
            this.grpAdicionar.Controls.Add(this.chkCheddar);
            this.grpAdicionar.Location = new System.Drawing.Point(286, 171);
            this.grpAdicionar.Name = "grpAdicionar";
            this.grpAdicionar.Size = new System.Drawing.Size(200, 150);
            this.grpAdicionar.TabIndex = 24;
            this.grpAdicionar.TabStop = false;
            this.grpAdicionar.Text = "Adicionais";
            // 
            // chkMolhoEspecial
            // 
            this.chkMolhoEspecial.AutoSize = true;
            this.chkMolhoEspecial.Location = new System.Drawing.Point(6, 88);
            this.chkMolhoEspecial.Name = "chkMolhoEspecial";
            this.chkMolhoEspecial.Size = new System.Drawing.Size(144, 17);
            this.chkMolhoEspecial.TabIndex = 4;
            this.chkMolhoEspecial.Text = "Molho especial (R$ 3,00)";
            this.chkMolhoEspecial.UseVisualStyleBackColor = true;
            // 
            // chkCatupiryA
            // 
            this.chkCatupiryA.AutoSize = true;
            this.chkCatupiryA.Location = new System.Drawing.Point(6, 65);
            this.chkCatupiryA.Name = "chkCatupiryA";
            this.chkCatupiryA.Size = new System.Drawing.Size(114, 17);
            this.chkCatupiryA.TabIndex = 3;
            this.chkCatupiryA.Text = "Catupiry  (R$ 8,00)";
            this.chkCatupiryA.UseVisualStyleBackColor = true;
            this.chkCatupiryA.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkHabmburguer
            // 
            this.chkHabmburguer.AutoSize = true;
            this.chkHabmburguer.Location = new System.Drawing.Point(6, 42);
            this.chkHabmburguer.Name = "chkHabmburguer";
            this.chkHabmburguer.Size = new System.Drawing.Size(163, 17);
            this.chkHabmburguer.TabIndex = 2;
            this.chkHabmburguer.Text = "Hamburguer extra (R$ 12,00)";
            this.chkHabmburguer.UseVisualStyleBackColor = true;
            this.chkHabmburguer.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkCheddar
            // 
            this.chkCheddar.AutoSize = true;
            this.chkCheddar.Location = new System.Drawing.Point(6, 19);
            this.chkCheddar.Name = "chkCheddar";
            this.chkCheddar.Size = new System.Drawing.Size(113, 17);
            this.chkCheddar.TabIndex = 1;
            this.chkCheddar.Text = "Cheddar (R$ 6,00)";
            this.chkCheddar.UseVisualStyleBackColor = true;
            this.chkCheddar.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(6, 111);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(104, 17);
            this.chkBacon.TabIndex = 36;
            this.chkBacon.Text = "Bacon (R$ 5,00)";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkCarne
            // 
            this.chkCarne.AutoSize = true;
            this.chkCarne.Location = new System.Drawing.Point(6, 111);
            this.chkCarne.Name = "chkCarne";
            this.chkCarne.Size = new System.Drawing.Size(54, 17);
            this.chkCarne.TabIndex = 5;
            this.chkCarne.Text = "Carne";
            this.chkCarne.UseVisualStyleBackColor = true;
            // 
            // chkQueijo
            // 
            this.chkQueijo.AutoSize = true;
            this.chkQueijo.Location = new System.Drawing.Point(86, 19);
            this.chkQueijo.Name = "chkQueijo";
            this.chkQueijo.Size = new System.Drawing.Size(56, 17);
            this.chkQueijo.TabIndex = 6;
            this.chkQueijo.Text = "Queijo";
            this.chkQueijo.UseVisualStyleBackColor = true;
            // 
            // chkMolho
            // 
            this.chkMolho.AutoSize = true;
            this.chkMolho.Location = new System.Drawing.Point(86, 42);
            this.chkMolho.Name = "chkMolho";
            this.chkMolho.Size = new System.Drawing.Size(55, 17);
            this.chkMolho.TabIndex = 7;
            this.chkMolho.Text = "Molho";
            this.chkMolho.UseVisualStyleBackColor = true;
            // 
            // chkMaionese
            // 
            this.chkMaionese.AutoSize = true;
            this.chkMaionese.Location = new System.Drawing.Point(6, 134);
            this.chkMaionese.Name = "chkMaionese";
            this.chkMaionese.Size = new System.Drawing.Size(119, 17);
            this.chkMaionese.TabIndex = 37;
            this.chkMaionese.Text = "Maionese (R$ 3,00)";
            this.chkMaionese.UseVisualStyleBackColor = true;
            this.chkMaionese.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(590, 273);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(283, 40);
            this.btnCalcular.TabIndex = 30;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // chkFrango
            // 
            this.chkFrango.AutoSize = true;
            this.chkFrango.Location = new System.Drawing.Point(86, 65);
            this.chkFrango.Name = "chkFrango";
            this.chkFrango.Size = new System.Drawing.Size(59, 17);
            this.chkFrango.TabIndex = 8;
            this.chkFrango.Text = "Frango";
            this.chkFrango.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Location = new System.Drawing.Point(286, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionais";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Maionese (R$ 3,00)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 17);
            this.checkBox2.TabIndex = 36;
            this.checkBox2.Text = "Bacon (R$ 5,00)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 88);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(144, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Molho especial (R$ 3,00)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 65);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(114, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Catupiry  (R$ 8,00)";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 42);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(163, 17);
            this.checkBox5.TabIndex = 2;
            this.checkBox5.Text = "Hamburguer extra (R$ 12,00)";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 19);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(113, 17);
            this.checkBox6.TabIndex = 1;
            this.checkBox6.Text = "Cheddar (R$ 6,00)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAdicionar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.txtValorLanche);
            this.Controls.Add(this.grpRetirar);
            this.Controls.Add(this.lblValorLanche);
            this.Controls.Add(this.cmbLanches);
            this.Controls.Add(this.btnMenu);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.grpRetirar.ResumeLayout(false);
            this.grpRetirar.PerformLayout();
            this.grpAdicionar.ResumeLayout(false);
            this.grpAdicionar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.TextBox txtValorLanche;
        private System.Windows.Forms.GroupBox grpRetirar;
        private System.Windows.Forms.CheckBox chkTomate;
        private System.Windows.Forms.CheckBox chkBaconR;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.CheckBox chkSalada;
        private System.Windows.Forms.Label lblValorLanche;
        private System.Windows.Forms.ComboBox cmbLanches;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.GroupBox grpAdicionar;
        private System.Windows.Forms.CheckBox chkMolhoEspecial;
        private System.Windows.Forms.CheckBox chkCatupiryA;
        private System.Windows.Forms.CheckBox chkHabmburguer;
        private System.Windows.Forms.CheckBox chkCheddar;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkQueijo;
        private System.Windows.Forms.CheckBox chkCarne;
        private System.Windows.Forms.CheckBox chkMolho;
        private System.Windows.Forms.CheckBox chkMaionese;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox chkFrango;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
    }
}