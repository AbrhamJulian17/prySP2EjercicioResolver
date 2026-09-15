namespace prySP2EjercicioResolver
{
    partial class FrmPrincipal
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
            gbDistancia = new GroupBox();
            rdCorta = new RadioButton();
            rdLarga = new RadioButton();
            txtName = new Label();
            txtTipo = new Label();
            txtCodigo = new TextBox();
            txtFecha = new Label();
            btnClickAceptar = new Button();
            cbTipo = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            gbDistancia.SuspendLayout();
            SuspendLayout();
            // 
            // gbDistancia
            // 
            gbDistancia.Controls.Add(rdCorta);
            gbDistancia.Controls.Add(rdLarga);
            gbDistancia.Location = new Point(12, 136);
            gbDistancia.Name = "gbDistancia";
            gbDistancia.Size = new Size(290, 174);
            gbDistancia.TabIndex = 0;
            gbDistancia.TabStop = false;
            gbDistancia.Text = "Distancia";
            // 
            // rdCorta
            // 
            rdCorta.AutoSize = true;
            rdCorta.Location = new Point(60, 101);
            rdCorta.Name = "rdCorta";
            rdCorta.Size = new Size(54, 19);
            rdCorta.TabIndex = 1;
            rdCorta.TabStop = true;
            rdCorta.Text = "Corta";
            rdCorta.UseVisualStyleBackColor = true;
            // 
            // rdLarga
            // 
            rdLarga.AutoSize = true;
            rdLarga.Location = new Point(60, 48);
            rdLarga.Name = "rdLarga";
            rdLarga.Size = new Size(54, 19);
            rdLarga.TabIndex = 0;
            rdLarga.TabStop = true;
            rdLarga.Text = "Larga";
            rdLarga.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(34, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(46, 15);
            txtName.TabIndex = 1;
            txtName.Text = "Codigo";
            // 
            // txtTipo
            // 
            txtTipo.AutoSize = true;
            txtTipo.Location = new Point(34, 98);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(31, 15);
            txtTipo.TabIndex = 2;
            txtTipo.Text = "Tipo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(107, 60);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(112, 23);
            txtCodigo.TabIndex = 3;
            txtCodigo.TextChanged += textBox1_TextChanged;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // txtFecha
            // 
            txtFecha.AutoSize = true;
            txtFecha.Location = new Point(34, 25);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(38, 15);
            txtFecha.TabIndex = 4;
            txtFecha.Text = "Fecha";
            // 
            // btnClickAceptar
            // 
            btnClickAceptar.Location = new Point(210, 331);
            btnClickAceptar.Name = "btnClickAceptar";
            btnClickAceptar.Size = new Size(92, 26);
            btnClickAceptar.TabIndex = 2;
            btnClickAceptar.Text = "Regristrar";
            btnClickAceptar.UseVisualStyleBackColor = true;
            btnClickAceptar.Click += btnClickAceptar_Click;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(107, 98);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(195, 23);
            cbTipo.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 369);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbTipo);
            Controls.Add(btnClickAceptar);
            Controls.Add(txtFecha);
            Controls.Add(txtCodigo);
            Controls.Add(txtTipo);
            Controls.Add(txtName);
            Controls.Add(gbDistancia);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Boleteria";
            Load += FrmPrincipal_Load;
            gbDistancia.ResumeLayout(false);
            gbDistancia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDistancia;
        private RadioButton rdCorta;
        private RadioButton rdLarga;
        private Label txtName;
        private Label txtTipo;
        private TextBox txtCodigo;
        private Label txtFecha;
        private Button btnClickAceptar;
        private ComboBox cbTipo;
        private DateTimePicker dateTimePicker1;
    }
}