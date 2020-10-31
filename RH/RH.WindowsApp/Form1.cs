using System;
using System.Drawing;
using System.Windows.Forms;

namespace RH.WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            MuestrarOpcionMenu(1);
        }

        private void MuestrarOpcionMenu(int opcionMenu)
        {
            if (opcionMenu == 1)
            {
                panEmpleado.Location = new Point(209, 24);
                panEmpleado.Visible = true;
            }
            if (opcionMenu == 2)
            {
                panTipoDocumento.Location = new Point(209, 24);
                panTipoDocumento.Visible = true;
            }
            if (opcionMenu == 3)
            {
                panCiudad.Location = new Point(209, 24);
                panCiudad.Visible = true;
            }
            if (opcionMenu == 4)
            {
                panGenero.Location = new Point(209, 24);
                panGenero.Visible = true;
            }
            if (opcionMenu == 5)
            {
                panEstadoCivil.Location = new Point(209, 24);
                panEstadoCivil.Visible = true;
            }
            if (opcionMenu == 6)
            {
                panCargos.Location = new Point(209, 24);
                panCargos.Visible = true;
            }
            if(opcionMenu==7)
            {
                panCentroCosto.Location = new Point(209, 24);
                panCentroCosto.Visible = true;
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

    }
}
