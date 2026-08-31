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
    public partial class Admin_Usuarios : Form
    {
        private readonly ISistemaService _sistemaService;
        private List<PersonaDTO> ListaPersonas;
        private ProgressBar progressBar;
        public Admin_Usuarios(ISistemaService sistemaService)
        {
            InitializeComponent();
            this._sistemaService = sistemaService;
            this.ListaPersonas = new List<PersonaDTO>();
        }

        private async void Admin_Usuarios_Load(object sender, EventArgs e)
        {
            await this.ListarPersonas();
            this.CargarTablaPersonas();
        }

        private async Task<List<PersonaDTO>> ListarPersonas()
        {
            this.ListaPersonas = await this._sistemaService.ListaPersonas();
            return ListaPersonas;
        }

        private void CargarTablaPersonas()
        {
            if (this.ListaPersonas.Count > 0)
            {
                this.dgvPersonas.Rows.Clear();
                foreach (var cli in ListaPersonas)
                {
                    dgvPersonas.Rows.Add(
                        cli.Id,
                        cli.TipoIdentificacionDTO.Id,
                        cli.TipoIdentificacionDTO.Nombre,
                        cli.Identificacion,
                        cli.Nombres,
                        cli.Apellidos,
                        cli.Telefono,
                        cli.Mail,
                        cli.DireccionesDTO.Descripcion,
                        cli.DireccionesDTO.Ciudad.Nombre,
                        cli.FechaCreacion,
                        cli.FechaModificacion,
                        cli.EsUsuario,
                        cli.EsCliente,
                        cli.EsProveedor
                    );
                }
            }
        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Validar columna
            if (e.ColumnIndex < 0)
                return;
            if (dgvPersonas.Columns[e.ColumnIndex].Name == "Ver")
            {
                progressBar = new ProgressBar();
                progressBar.Show();
                Formulario_Personas formPer = new Formulario_Personas();
                formPer.ShowDialog();
            }
        }
    }
}
