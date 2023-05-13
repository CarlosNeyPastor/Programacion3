namespace Calculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textNum1 = new TextBox();
            textNum2 = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnProducto = new Button();
            btnDivision = new Button();
            lblResultado = new Label();
            listResultado = new ListBox();
            lblCalculadora = new Label();
            CheckResultados = new CheckBox();
            cboResultado = new ComboBox();
            CheckFondo = new CheckBox();
            gbTipo = new GroupBox();
            rbCientifica = new RadioButton();
            rbEstandar = new RadioButton();
            gbCientificas = new GroupBox();
            btnLog = new Button();
            btnPotencia = new Button();
            btnRaid = new Button();
            gbTipo.SuspendLayout();
            gbCientificas.SuspendLayout();
            SuspendLayout();
            // 
            // textNum1
            // 
            textNum1.Location = new Point(12, 64);
            textNum1.Name = "textNum1";
            textNum1.Size = new Size(157, 23);
            textNum1.TabIndex = 0;
            textNum1.TextAlign = HorizontalAlignment.Right;
            textNum1.TextChanged += textNum1_TextChanged;
            // 
            // textNum2
            // 
            textNum2.Location = new Point(12, 118);
            textNum2.Name = "textNum2";
            textNum2.Size = new Size(157, 23);
            textNum2.TabIndex = 1;
            textNum2.TextAlign = HorizontalAlignment.Right;
            textNum2.TextChanged += textNum2_TextChanged;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(12, 169);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(36, 23);
            btnSuma.TabIndex = 2;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(54, 169);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(34, 23);
            btnResta.TabIndex = 3;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(94, 169);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(31, 23);
            btnProducto.TabIndex = 4;
            btnProducto.Text = "*";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(131, 169);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(38, 23);
            btnDivision.TabIndex = 5;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = SystemColors.ButtonHighlight;
            lblResultado.BorderStyle = BorderStyle.Fixed3D;
            lblResultado.Location = new Point(12, 221);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(157, 23);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            lblResultado.TextAlign = ContentAlignment.MiddleRight;
            lblResultado.Click += lblResultado_Click;
            // 
            // listResultado
            // 
            listResultado.FormattingEnabled = true;
            listResultado.ItemHeight = 15;
            listResultado.Location = new Point(223, 34);
            listResultado.Name = "listResultado";
            listResultado.Size = new Size(207, 364);
            listResultado.TabIndex = 8;
            listResultado.SelectedIndexChanged += listResultado_SelectedIndexChanged;
            // 
            // lblCalculadora
            // 
            lblCalculadora.AutoSize = true;
            lblCalculadora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCalculadora.Location = new Point(57, 32);
            lblCalculadora.Name = "lblCalculadora";
            lblCalculadora.Size = new Size(70, 15);
            lblCalculadora.TabIndex = 9;
            lblCalculadora.Text = "Calculadora";
            // 
            // CheckResultados
            // 
            CheckResultados.AutoSize = true;
            CheckResultados.BackgroundImageLayout = ImageLayout.Center;
            CheckResultados.Location = new Point(47, 247);
            CheckResultados.Name = "CheckResultados";
            CheckResultados.Size = new Size(124, 19);
            CheckResultados.TabIndex = 11;
            CheckResultados.Text = "Mostrar resultados";
            CheckResultados.UseVisualStyleBackColor = true;
            CheckResultados.CheckedChanged += CheckMostrarResultado_CheckedChanged;
            // 
            // cboResultado
            // 
            cboResultado.FormattingEnabled = true;
            cboResultado.Location = new Point(223, 424);
            cboResultado.Name = "cboResultado";
            cboResultado.Size = new Size(207, 23);
            cboResultado.TabIndex = 12;
            cboResultado.SelectedIndexChanged += cboResultado_SelectedIndexChanged;
            // 
            // CheckFondo
            // 
            CheckFondo.AutoSize = true;
            CheckFondo.Location = new Point(47, 272);
            CheckFondo.Name = "CheckFondo";
            CheckFondo.Size = new Size(106, 19);
            CheckFondo.TabIndex = 13;
            CheckFondo.Text = "Fondo amarillo";
            CheckFondo.UseVisualStyleBackColor = true;
            CheckFondo.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // gbTipo
            // 
            gbTipo.Controls.Add(rbCientifica);
            gbTipo.Controls.Add(rbEstandar);
            gbTipo.Location = new Point(17, 314);
            gbTipo.Name = "gbTipo";
            gbTipo.Size = new Size(167, 57);
            gbTipo.TabIndex = 14;
            gbTipo.TabStop = false;
            gbTipo.Text = "Tipo";
            // 
            // rbCientifica
            // 
            rbCientifica.AutoSize = true;
            rbCientifica.Location = new Point(10, 34);
            rbCientifica.Name = "rbCientifica";
            rbCientifica.Size = new Size(75, 19);
            rbCientifica.TabIndex = 1;
            rbCientifica.TabStop = true;
            rbCientifica.Text = "Cientifica";
            rbCientifica.UseVisualStyleBackColor = true;
            rbCientifica.CheckedChanged += rbCientifica_CheckedChanged;
            // 
            // rbEstandar
            // 
            rbEstandar.AutoSize = true;
            rbEstandar.Location = new Point(10, 14);
            rbEstandar.Name = "rbEstandar";
            rbEstandar.Size = new Size(70, 19);
            rbEstandar.TabIndex = 0;
            rbEstandar.TabStop = true;
            rbEstandar.Text = "Estandar";
            rbEstandar.UseVisualStyleBackColor = true;
            // 
            // gbCientificas
            // 
            gbCientificas.Controls.Add(btnLog);
            gbCientificas.Controls.Add(btnPotencia);
            gbCientificas.Controls.Add(btnRaid);
            gbCientificas.Location = new Point(17, 401);
            gbCientificas.Name = "gbCientificas";
            gbCientificas.Size = new Size(195, 64);
            gbCientificas.TabIndex = 15;
            gbCientificas.TabStop = false;
            gbCientificas.Text = "Cientificas";
            // 
            // btnLog
            // 
            btnLog.Location = new Point(134, 22);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(55, 23);
            btnLog.TabIndex = 2;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            // 
            // btnPotencia
            // 
            btnPotencia.Location = new Point(53, 22);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(75, 23);
            btnPotencia.TabIndex = 1;
            btnPotencia.Text = "Potencia";
            btnPotencia.UseVisualStyleBackColor = true;
            // 
            // btnRaid
            // 
            btnRaid.Location = new Point(5, 22);
            btnRaid.Name = "btnRaid";
            btnRaid.Size = new Size(42, 23);
            btnRaid.TabIndex = 0;
            btnRaid.Text = "RAID";
            btnRaid.UseVisualStyleBackColor = true;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(442, 487);
            Controls.Add(gbCientificas);
            Controls.Add(gbTipo);
            Controls.Add(CheckFondo);
            Controls.Add(cboResultado);
            Controls.Add(CheckResultados);
            Controls.Add(lblCalculadora);
            Controls.Add(listResultado);
            Controls.Add(lblResultado);
            Controls.Add(btnDivision);
            Controls.Add(btnProducto);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(textNum2);
            Controls.Add(textNum1);
            Name = "FormCalculadora";
            Text = "Calculadora";
            Load += Form1_Load;
            gbTipo.ResumeLayout(false);
            gbTipo.PerformLayout();
            gbCientificas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNum1;
        private TextBox textNum2;
        private Button btnSuma;
        private Button btnResta;
        private Button btnProducto;
        private Button btnDivision;
        private Label lblResultado;
        private ListBox listResultado;
        private Label lblCalculadora;
        private CheckBox CheckResultados;
        private ComboBox cboResultado;
        private CheckBox CheckFondo;
        private GroupBox gbTipo;
        private RadioButton rbCientifica;
        private RadioButton rbEstandar;
        private GroupBox gbCientificas;
        private Button btnLog;
        private Button btnPotencia;
        private Button btnRaid;
    }
}