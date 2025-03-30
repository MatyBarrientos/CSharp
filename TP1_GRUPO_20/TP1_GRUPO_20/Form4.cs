using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_20
{
    public partial class Ejercicio3 : Form
    {

        FormPrincipal formprincipal;
        public Ejercicio3(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formprincipal = formPrincipal;
        }
        private void Ejercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formprincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoSeleccionado = "Usted seleccono los siguientes elementos:\n";
            if (radBtnFem.Checked)
            {
                textoSeleccionado += "Sexo: Femenino\n";
            }
            else if (radBtnMasc.Checked)
            {
                textoSeleccionado += "Sexo: Masculino\n";
            }

            if (radBtnCasado.Checked)
            {
                textoSeleccionado += "Estado Civil: Casado\n";
            }
            else if (radBtnSoltero.Checked)
            {
                textoSeleccionado += "Estado Civil: Soltero\n";
            }

            if (checkLstBox.CheckedItems.Count > 0)   // Verifica si hay algo seleccionado, si se selecciono, mostramos lo siguiente: 
            {
                textoSeleccionado += "Oficio: \n";
                
                foreach (string s in checkLstBox.CheckedItems) // Recorremos con un ciclo foreach el contenido del CheckListBox
                {
                    textoSeleccionado += "- " + s.ToString() + "\n";
                }
                
                lblCont.Text = textoSeleccionado; //Asignamos el total del contenido al Label
                lblCont.Show(); //Mostramos el Label
            }
            else //Si no tiene nada seleccionado, avisa y borra el contenido anterior si es que existía
            {
                MessageBox.Show("Debe seleccionar por lo menos un oficio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCont.Text = "";
            }

        }
    }
}
