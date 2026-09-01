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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace TiendaLaLojanita.Views
{
    public partial class Admin_Usuarios : Form
    {
        private readonly ISistemaService _sistemaService;
        private readonly IClienteService clienteService;
        private List<PersonaDTO> ListaPersonas;
        private ProgressBar progressBar;
        public Admin_Usuarios(ISistemaService sistemaService, IClienteService clienteService)
        {
            InitializeComponent();
            this._sistemaService = sistemaService;
            this.clienteService = clienteService;
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

        private async void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.RowIndex < 0)
                return;
            // Validar columna
            if (e.ColumnIndex < 0)
                return;
            if (dgvPersonas.Columns[e.ColumnIndex].Name == "Ver")
            {
                progressBar = new ProgressBar();
                progressBar.Show();
                id = Convert.ToInt32(dgvPersonas.Rows[e.RowIndex].Cells["Id"].Value);
                var persona = await this._sistemaService.BuscarPersonaCompleto(id);
                if (persona is null)
                {
                    MessageBox.Show($"No se puedo obter informacion de esta persona!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar.Hide();
                    return;
                }
                progressBar.Hide();
                ISistemaService sistemaService = this._sistemaService;
                IClienteService clienteService = this.clienteService;
                Formulario_Personas formPer = new Formulario_Personas(persona, sistemaService, clienteService);
                formPer.ShowDialog();
            }
        }
    }
}
