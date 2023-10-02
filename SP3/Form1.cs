using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP3
{
    public partial class Form1 : Form
    {
        // estructura de Turnos
        public struct TURNO
        {
            public int Numero;
            public string Dominio;
            public int Modelo;
            public string Titular;
        };
        // constantes
        const int MAXIMO = 50;

        // declarar el arreglo
        TURNO[] turnos; // = new TURNO[MAXIMO];
        // indice de carga
        int Posicion = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // creacion
            turnos = new TURNO[MAXIMO];
            // estado inicial del formulario
            numAnioFabricacion.Minimum = 1950;
            numAnioFabricacion.Maximum = 2023;
            numAnioFabricacion.Value = 2021;
            //
            txtNroTurno.Text = "";
            txtDominio.Text = "";
            txtTitular.Text = "";
            //
            txtAnioMasAntiguo.Text = "";
            txtCantidadTurnos.Text = "";
            txtDominio6Caracteres.Text = "";
            //
            btnRegistrar.Enabled = false;
            // inicializar el arreglo (pendiente)


        }

        // Eventos en los 3 TextBox que determinan el estado del botón "Registrar" (se habilita o deshabilita)
        private void txtNroTurno_TextChanged(object sender, EventArgs e)
        {
            if(txtNroTurno.Text != "" && txtDominio.Text.Length >=6 && txtTitular.Text.Length >= 3)
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            if (txtNroTurno.Text != "" && txtDominio.Text.Length >= 6 && txtTitular.Text.Length >= 3)
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {
            if (txtNroTurno.Text != "" && txtDominio.Text.Length >= 6 && txtTitular.Text.Length >= 3)
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        // Este evento controla que el número de turno que se quiere registrar no exista y luego 
        // agrega los datos del turno al arreglo, si el número ya existe el registro
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // controlar que el nro de turno no existe
            int Nro = int.Parse(txtNroTurno.Text);
            bool existe = false; //

            int i = 0;
            while (i < Posicion )
            {
                if(Nro == turnos[i].Numero)
                {
                    MessageBox.Show("El turno ya existe!!");
                    txtNroTurno.Text = "";
                    existe = true;
                    break;
                }
                i++;
            }
            //
            if(!existe) // si NO existe repetido el número de turno se puede registar un nuevo turno
            {
                //  carga del arreglo en la posición libre
                turnos[Posicion].Numero = Nro;
                turnos[Posicion].Dominio = txtDominio.Text;
                turnos[Posicion].Modelo = (int)numAnioFabricacion.Value;
                turnos[Posicion].Titular = txtTitular.Text;
                Posicion++; // incrementar el indice para la posición del arreglo a usar
                MessageBox.Show("Registro correcto");
                // limpiar
                txtNroTurno.Text = "";
                txtDominio.Text = "";
                txtTitular.Text = "";
            }

        }
    }
}
