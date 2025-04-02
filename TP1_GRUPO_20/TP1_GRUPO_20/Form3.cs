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
    public partial class Ejercicio2 : Form
    {
        FormPrincipal formprincipal;
        public Ejercicio2(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formprincipal = formPrincipal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formprincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //variables auxiliartes sin espacios en blanco

            string apellido = txtBoxApellido.Text.Trim();
            string nombre = txtBoxNombre.Text.Trim();
            string elemento = nombre + " " + apellido; //es más comodo trabajar con un solo string


            if (txtBoxNombre.Text.Trim() == ""){ //comprueba de que el nombre no esté vacio
                MessageBox.Show("El casillero 'Nombre' no puede estar vacio", "atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           if (txtBoxApellido.Text.Trim() == "")//comprueba de que el apellido no lo este
            {
                MessageBox.Show("El casillero 'Apellido' no puede estar vacio", "atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool existe = false;
            foreach (string s in lbElementos.Items)
            {
                //comparo sin importar mayusculas o minusculas
                if (s.ToUpper() == elemento.ToUpper())
                {
                    existe = true;
                    break; // Salimos del bucle si ya lo encontramos
                }
            }

            // si está -> cartel de error
            if (existe)
            {
                MessageBox.Show("Elemento repetido", "Atención");
                return ;
            }
            lbElementos.Items.Add(elemento);
            //limpio los casilleros
            txtBoxNombre.Text = "";
            txtBoxApellido.Text = "";


            //método realizado antes de leer por completo el material de estudio luego descubrimos que la propiedad sorted lo hace más eficiente

            //si llegué acá es porque no está ->  entonces arranco a buscar la posicion
            //int pos = 0;

            //foreach (string s in lbElementos.Items)
            //{
            //    if (string.Compare(s, elemento) > 0)
            //    {
            //        break;
            //    }
            //    pos++;
            //}
            //    lbElementos.Items.Insert(pos,elemento);


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //establecemos un indice para saber que elemento se seleccionó
            int pos = lbElementos.SelectedIndex;
            //si no se seleccionó ningun elemento (pos==-1), se muestra un mensaje de error 
            if (pos == -1)
            {
                MessageBox.Show("No se seleccionó elemento", "atencion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else //si se seleccionó un elemento, se elimina de la lista mediante la posicion
            {
                lbElementos.Items.RemoveAt(pos);
            }

        }
    }
}
