using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4._13
{
    public partial class FrmPersonas : Form
    {
       
        const int tamanio = 3;
        Personas[] personas = new Personas[tamanio];
        int ultimo = 0;
        public FrmPersonas()
        {
            InitializeComponent();
        }
       
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            BtnGrabar.Enabled = true;
            BtnCancelar.Enabled = true;
            TxtApellidos.Enabled = true;
            TxtNombres.Enabled = true;
            CbTipoDoc.Enabled = true;
            TxtDoc.Enabled = true;
            CbEstadoCivil.Enabled = true;
            RbtnHombre.Enabled = true;
            RbtnMujer.Enabled = true;
            ChbFallecido.Enabled = true;

            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnBorrar.Enabled = false;
            BtnSalir.Enabled = false;

            TxtApellidos.Focus();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();

                if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;

                if (control is CheckBox)
                    ((CheckBox)control).Checked = false;

                if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
            }
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            Personas oPersona = new Personas();
            oPersona.pApellido = TxtApellidos.Text;
            oPersona.pNombre = TxtNombres.Text;
            oPersona.pTipoDoc = CbTipoDoc.Text;
            oPersona.pDocumento = Convert.ToInt32(TxtDoc.Text);
            oPersona.pEstadoCivil = CbEstadoCivil.Text;


            if (RbtnHombre.Checked)
            {
                oPersona.pSexo = "Hombre";
            }
            else
            {
                oPersona.pSexo = "Mujer";
            }
            if (ChbFallecido.Checked)
            {
                oPersona.pFallecido = "Fallecido";
            }
            if (ultimo < tamanio)
            {
                personas[ultimo] = oPersona;
                ultimo++;
            }
            LstbPersonas.Items.Clear();
            for (int i = 0; i < ultimo; i++)
            {
                LstbPersonas.Items.Add(personas[i].ToString());
           
            }

            MessageBox.Show("Persona cargada con exito");

            TxtApellidos.Enabled = false;
            TxtNombres.Enabled = false;
            CbTipoDoc.Enabled = false;
            TxtDoc.Enabled = false;
            CbEstadoCivil.Enabled = false;
            RbtnHombre.Enabled = false;
            RbtnMujer.Enabled = false;
            ChbFallecido.Enabled = false;

            BtnGrabar.Enabled = false;
            BtnCancelar.Enabled = false;

            BtnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            BtnBorrar.Enabled = true;
            BtnSalir.Enabled = true;
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            BtnGrabar.Enabled = true;
            BtnCancelar.Enabled = true;

            TxtApellidos.Enabled = true;
            TxtNombres.Enabled = true;
            CbTipoDoc.Enabled = true;
            TxtDoc.Enabled = true;
            CbEstadoCivil.Enabled = true;
            RbtnHombre.Enabled = true;
            RbtnMujer.Enabled = true;
            ChbFallecido.Enabled = true;

            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnBorrar.Enabled = false;
            BtnSalir.Enabled = false;

            LstbPersonas.Enabled = false;

            TxtApellidos.Focus();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "¿Estás seguro de borrar este registro?",
    "Confirmación",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();

                if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;

                if (control is CheckBox)
                    ((CheckBox)control).Checked = false;

                if (control is RadioButton)
                    ((RadioButton)control).Checked = false;

                TxtApellidos.Enabled = false;
                TxtNombres.Enabled = false;
                CbTipoDoc.Enabled = false;
                TxtDoc.Enabled = false;
                CbEstadoCivil.Enabled = false;
                RbtnHombre.Enabled = false;
                RbtnMujer.Enabled = false;
                ChbFallecido.Enabled = false;

                BtnGrabar.Enabled = false;
                BtnCancelar.Enabled = false;

                BtnNuevo.Enabled = true;
                BtnEditar.Enabled = true;
                BtnBorrar.Enabled = true;
                BtnSalir.Enabled = true;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
       "¿Seguro que querés salir?",
       "Salir",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (resultado == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        private void LstbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstbPersonas.HorizontalScrollbar = true;
            LstbPersonas.Font = new Font("Consolas", 10);
        }
    }
}
