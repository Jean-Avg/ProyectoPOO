using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19
{
    public partial class FrmCovid19 : Form
    {
        string vtos = "";
        string vfiebre = "";
        string vcansancio = "";
        string vincapacidad = "";
        string vrespiracion = "";
        string vdolor = "";
        string tipoSexo;
        string provincia;

        public FrmCovid19()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxtFechaActual.Text = DateTime.Now.ToShortDateString();
        }

        private void btnCerrarA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea abandonar la aplicación?", "Registro Pacientes",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void TxtFechaActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkPresion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDolor.Checked == true)
            {
                vdolor = "Dolor";
            }
            else
            {
                vdolor = "";
            }
        }

        private void chkIncapacidad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIncapacidad.Checked == true)
            {
                vincapacidad = "Incapacidad";
            }
            else
            {
                vincapacidad = "";
            }
        }

        private void chkRespiracion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRespiracion.Checked == true)
            {
                vrespiracion = "Respiración";
            }
            else
            {
                vrespiracion = "";
            }
        }
        private void chkCansancio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCansancio.Checked == true)
            {
                vcansancio = "Cansancio";
            }
            else
            {
                vcansancio = "";
            }
        }
        private void chkFiebre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiebre.Checked == true)
            {
                vfiebre = "Fiebre";
            }
            else
            {
                vfiebre = "";
            }
        }
        private void chkTos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiebre.Checked == true)
            {
                vtos = "Tos";
            }
            else
            {
                vtos = "";
            }
        }

        private void RbMasculino_CheckedChanged(object sender, EventArgs e)
        {

            if (RbMasculino.Checked == true)
            {
                txtOtro.Enabled = false;
                tipoSexo = "Masculino";
            }
        }

        private void RbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            

            if (RbFemenino.Checked == true)
            {
                txtOtro.Enabled = false;
                tipoSexo = "Femenino";
            }
        }

        private void RbOtro_CheckedChanged(object sender, EventArgs e)
        {
            
            if (RbOtro.Checked == true)
            {
                txtOtro.Enabled = true;
                tipoSexo = txtOtro.Text;
            }
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cbProvincia.SelectedIndex != -1)
            {
                provincia = cbProvincia.Text;
            }
        }

        private void btnresumir_Click(object sender, EventArgs e)
        {
            string mensaje0 = "Información Diágnostico CORANAVIRUS - COVID-19";
            string mensaje1 = "Nombre: " + txtNombre.Text + " " + txtPrimerApellido.Text + " " + txtSegundoApellido.Text;
            string mensaje2 = "Fecha: " + TxtFechaActual.Text + " Dirección: " + txtDireccion.Text;
            string mensaje3 = "Género: " + tipoSexo + " Correo Eléctronico: " + txtCorreo.Text;
            string mensaje4 = "Síntomas Básicos: " + vfiebre + " " + vtos + " " + vcansancio;
            string mensaje5 = "S´ntomas Graves: " + vrespiracion + " " + vdolor + " " + vincapacidad;

            DialogResult Resultado = new DialogResult();

            Resultado = MessageBox.Show(mensaje0 + mensaje1 + mensaje2 + mensaje3 + mensaje4 + mensaje5 + " ",
                                        "Información general resumen ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
