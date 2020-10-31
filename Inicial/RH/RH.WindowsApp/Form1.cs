
using RH.WindowsApp.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RH.WindowsApp
{
    public partial class Form1 : Form
    {
        string[] ciudades;
        int[] valor;
        List<Empleado> empleados = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarCiudades();
            LlenarValores();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            MuestrarOpcionMenu(1);
        }

        private void MuestrarOpcionMenu(int opcionMenu)
        {
            switch (opcionMenu)
            {
                case 1:
                    panEmpleado.BorderStyle = BorderStyle.FixedSingle;
                    panEmpleado.Location = new Point(209, 24);
                    panEmpleado.Visible = true;
                    LlenarComboCiudad();

                    comboBox1.Items.AddRange(ciudades);  // databinding

                    LlenarEmpleados();

                    break;
                case 2:
                    panTipoDocumento.BorderStyle = BorderStyle.FixedSingle;
                    panTipoDocumento.Location = new Point(209, 24);
                    panTipoDocumento.Visible = true;
                    break;
                case 3:
                    panCiudad.BorderStyle = BorderStyle.FixedSingle;
                    panCiudad.Location = new Point(209, 24);
                    panCiudad.Visible = true;
                    break;
                case 4:
                    panGenero.BorderStyle = BorderStyle.FixedSingle;
                    panGenero.Location = new Point(209, 24);
                    panGenero.Visible = true;
                    break;
                case 5:
                    panEstadoCivil.BorderStyle = BorderStyle.FixedSingle;
                    panEstadoCivil.Location = new Point(209, 24);
                    panEstadoCivil.Visible = true;
                    break;
                case 6:
                    panCargos.BorderStyle = BorderStyle.FixedSingle;
                    panCargos.Location = new Point(209, 24);
                    panCargos.Visible = true;
                    break;
                case 7:
                    panCentroCosto.BorderStyle = BorderStyle.FixedSingle;
                    panCentroCosto.Location = new Point(209, 24);
                    panCentroCosto.Visible = true;
                    break;
                default:
                    break;
            }

            //if (opcionMenu == 1) // Si esto es verdadero
            //{
            //    // Entonces se ejecuta esto cuando es verdadero
            //}
            //else if (opcionMenu == 2)
            //{
            //}
            //else if (opcionMenu == 3)
            //{
            //}
            //else if (opcionMenu == 4)
            //{
            //}
            //else if (opcionMenu == 5)
            //{
            //}
            //else if (opcionMenu == 6)
            //{
            //}
            //else if (opcionMenu == 7)
            //{
            //}
        }

        private void LlenarEmpleados()
        {
            empleados = new List<Empleado> {
                new Empleado { Nombres="Jaime", Apellidos="Perez", Celular=3003435566, FechaNacimiento= new DateTime(1991,02,23), FechaIngreso=new DateTime(2000,03,23) },
                new Empleado { Nombres="Jualian Enrique", Apellidos="Martinez", FechaIngreso=new DateTime(2015,06,30), FechaNacimiento=new DateTime(1973,12,30)}
            };

            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.DataSource = empleados;

        }

        private void LlenarComboCiudad()
        {
            for (int i = 0; i < ciudades.Length; i++)
            {
                cboCiudad.Items.Add(ciudades[i]);
            }
        }

        private void OcultarPaneles()
        {
            panCargos.Visible = false;
            panCentroCosto.Visible = false;
            panCiudad.Visible = false;
            panEmpleado.Visible = false;
            panEstadoCivil.Visible = false;
            panGenero.Visible = false;
            panTipoDocumento.Visible = false;
        }

        private void btnTipoDOcumento_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            MuestrarOpcionMenu(2);
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            MuestrarOpcionMenu(3);
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            MuestrarOpcionMenu(4);
        }

        private void btnEstadoCivil_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            MuestrarOpcionMenu(5);
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            MuestrarOpcionMenu(6);
        }

        private void btnCentroCosto_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            MuestrarOpcionMenu(7);
        }


        public void LlenarCiudades()
        {
            ciudades = new string[] {
            "Bogota", "Medellin", "Cartagena", "Cali", "Pamplona", "Monteria", "Zipaquira", "Sincelejo"
            };
        }

        public void LlenarValores()
        {
            valor = new int[] {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
            };
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gbAdicionar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            gbAdicionar.Visible = false;
        }

        private void LimpiarCampos()
        {
            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbCelular.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado()
            {
                Nombres = tbNombre.Text,
                Apellidos = tbApellidos.Text,
                Celular = Convert.ToInt64(tbCelular.Text),
                FechaIngreso = dateTimePicker2.Value,
                FechaNacimiento = dateTimePicker1.Value
            };

            empleados.Add(empleado);

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;

            btnCancelar_Click(sender,e);
        }
    }
}
