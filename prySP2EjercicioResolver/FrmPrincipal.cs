using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySP2EjercicioResolver
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClickRegistrar(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Add("Estandar");
            cbTipo.Items.Add("Premium");
            cbTipo.Items.Add("Ultra");

            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnClickAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Complete el código", "Carga Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtCodigo.Focus();
                txtCodigo.BackColor = Color.Aqua;
            }
            else
            {
                if (cbTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tipo de boleto", "Carga Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    cbTipo.Focus();
                    cbTipo.BackColor = Color.Aqua;
                }
                else
                {
                    StreamWriter archivo;

                    archivo = new StreamWriter("RegistroBoletos.txt");

                    archivo.WriteLine("Codigo: " + txtCodigo.Text +
                        " Tipo Boleto: " + cbTipo.Text);

                    archivo.Close();

                    MessageBox.Show("Registramos su Boleto", "Registro de Boleto",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }
    }
}
