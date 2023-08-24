namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.lbgener = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbjob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.cmbgener = new System.Windows.Forms.ComboBox();
            this.tltnome = new System.Windows.Forms.ToolTip(this.components);
            this.btncolocar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCadastro.Controls.Add(this.lbgener);
            this.pnlCadastro.Controls.Add(this.mtbCPF);
            this.pnlCadastro.Controls.Add(this.label1);
            this.pnlCadastro.Controls.Add(this.txbjob);
            this.pnlCadastro.Controls.Add(this.label2);
            this.pnlCadastro.Controls.Add(this.txbemail);
            this.pnlCadastro.Controls.Add(this.lbemail);
            this.pnlCadastro.Controls.Add(this.lbnome);
            this.pnlCadastro.Controls.Add(this.txbnome);
            this.pnlCadastro.Controls.Add(this.cmbgener);
            this.pnlCadastro.Location = new System.Drawing.Point(21, 13);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(679, 251);
            this.pnlCadastro.TabIndex = 0;
            this.pnlCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastro_Paint);
            // 
            // lbgener
            // 
            this.lbgener.AutoSize = true;
            this.lbgener.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgener.Location = new System.Drawing.Point(11, 181);
            this.lbgener.Name = "lbgener";
            this.lbgener.Size = new System.Drawing.Size(45, 16);
            this.lbgener.TabIndex = 9;
            this.lbgener.Text = "Gênero";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(14, 158);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(103, 20);
            this.mtbCPF.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPF";
            // 
            // txbjob
            // 
            this.txbjob.Location = new System.Drawing.Point(14, 119);
            this.txbjob.Name = "txbjob";
            this.txbjob.Size = new System.Drawing.Size(194, 20);
            this.txbjob.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profissão";
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(14, 80);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(194, 20);
            this.txbemail.TabIndex = 3;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(11, 64);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(35, 16);
            this.lbemail.TabIndex = 2;
            this.lbemail.Text = "Email";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(11, 25);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(92, 16);
            this.lbnome.TabIndex = 1;
            this.lbnome.Text = "Nome completo";
            this.lbnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbnome
            // 
            this.txbnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbnome.Location = new System.Drawing.Point(14, 41);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(194, 20);
            this.txbnome.TabIndex = 0;
            this.tltnome.SetToolTip(this.txbnome, "Insira seu nome completo");
            // 
            // cmbgener
            // 
            this.cmbgener.FormattingEnabled = true;
            this.cmbgener.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro",
            "Prefiro não informar"});
            this.cmbgener.Location = new System.Drawing.Point(14, 200);
            this.cmbgener.Name = "cmbgener";
            this.cmbgener.Size = new System.Drawing.Size(140, 21);
            this.cmbgener.TabIndex = 8;
            this.cmbgener.SelectedIndexChanged += new System.EventHandler(this.cmbgener_SelectedIndexChanged);
            // 
            // btncolocar
            // 
            this.btncolocar.BackColor = System.Drawing.Color.LightGreen;
            this.btncolocar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btncolocar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncolocar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncolocar.Location = new System.Drawing.Point(713, 25);
            this.btncolocar.Name = "btncolocar";
            this.btncolocar.Size = new System.Drawing.Size(75, 43);
            this.btncolocar.TabIndex = 1;
            this.btncolocar.Text = "Inserir";
            this.btncolocar.UseVisualStyleBackColor = false;
            this.btncolocar.Click += new System.EventHandler(this.btninserir);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(713, 95);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 43);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 276);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btncolocar);
            this.Controls.Add(this.pnlCadastro);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.TextBox txbjob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tltnome;
        private System.Windows.Forms.Label lbgener;
        private System.Windows.Forms.ComboBox cmbgener;
        private System.Windows.Forms.Button btncolocar;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnLimpar;
    }
}