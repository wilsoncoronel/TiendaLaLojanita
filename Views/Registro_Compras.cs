using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Views
{
    public partial class Registro_Compras : Form, ISesionReceptor
    {
        private readonly IProveedorService proveedorService;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }
        public Registro_Compras(IProveedorService proveedorService)
        {
            InitializeComponent();
            this.proveedorService = proveedorService;
        }

        private void Registro_Compras_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = $"Usuario: {Sesion?.Usuario}";
            this.lblFechaIngreso.Text = $"Fecha Ingreso: {DateTime.Now.ToString("g")}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btbBuscarProveedor_Click(object sender, EventArgs e)
        {
           this.CargarProveedor(this.txtIdentificacion.Text);
        }

        private async void CargarProveedor(string identificacion)
        {
            if(identificacion is null || identificacion == "")
            {
                MessageBox.Show("Debe ingresar una identificacion valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    ProveedorDTO proveedor = await this.proveedorService.ObtenerProveedorCI(identificacion);
                    if (proveedor is null)
                    {
                        MessageBox.Show("No se encontro ningun proveedor con la identificacion ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("No se encontro ningun proveedor con la identificacion ingresada");
                    }
                    this.txtRazonSocial.Text = proveedor.RazonSocial;
                    this.txtTelefono.Text = proveedor.Telefono;
                    this.txtDireccion.Text = proveedor.Direccion;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al buscar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }

        }
    }
}
