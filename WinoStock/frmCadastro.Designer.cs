
namespace WinoStock
{
    partial class frmCadastro
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
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cbxLocal = new System.Windows.Forms.ComboBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblUn = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Periferico",
            "Monitor",
            "Computador",
            "Peça",
            "Material de Escritorio",
            "Insumo"});
            this.cbxTipo.Location = new System.Drawing.Point(12, 26);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 23);
            this.cbxTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.White;
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(12, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 15);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 23);
            this.textBox1.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(13, 60);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(91, 61);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(93, 15);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data de Entrada:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(92, 76);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // cbxLocal
            // 
            this.cbxLocal.FormattingEnabled = true;
            this.cbxLocal.Items.AddRange(new object[] {
            "Gaveteiro 1",
            "Gaveteiro 2",
            "Gaveteiro 3",
            "Estoque",
            "Armario Estoque"});
            this.cbxLocal.Location = new System.Drawing.Point(229, 76);
            this.cbxLocal.Name = "cbxLocal";
            this.cbxLocal.Size = new System.Drawing.Size(121, 23);
            this.cbxLocal.TabIndex = 7;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.ForeColor = System.Drawing.Color.Black;
            this.lblLocal.Location = new System.Drawing.Point(228, 61);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(38, 15);
            this.lblLocal.TabIndex = 8;
            this.lblLocal.Text = "Local:";
            this.lblLocal.UseMnemonic = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 23);
            this.textBox2.TabIndex = 9;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.White;
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(13, 112);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(61, 15);
            this.lblDescricao.TabIndex = 10;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.BackColor = System.Drawing.Color.White;
            this.lblQtd.ForeColor = System.Drawing.Color.Black;
            this.lblQtd.Location = new System.Drawing.Point(312, 113);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(30, 15);
            this.lblQtd.TabIndex = 11;
            this.lblQtd.Text = "Qtd:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(311, 130);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(37, 23);
            this.txtQtd.TabIndex = 12;
            // 
            // lblUn
            // 
            this.lblUn.AutoSize = true;
            this.lblUn.BackColor = System.Drawing.Color.White;
            this.lblUn.ForeColor = System.Drawing.Color.Black;
            this.lblUn.Location = new System.Drawing.Point(256, 113);
            this.lblUn.Name = "lblUn";
            this.lblUn.Size = new System.Drawing.Size(35, 15);
            this.lblUn.TabIndex = 13;
            this.lblUn.Text = "Unid:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UN",
            "CX",
            "PC",
            "M",
            "CM"});
            this.comboBox1.Location = new System.Drawing.Point(257, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(34, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(257, 180);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 40);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 233);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUn);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.cbxLocal);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbxTipo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastro";
            this.Text = "r";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox cbxLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblUn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSalvar;
    }
}