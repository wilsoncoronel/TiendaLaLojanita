using FluentValidation.Results;
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
using TiendaLaLojanita.Services;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class DatosConfiguraciones : Form
    {
        private List<MarcaDTO> ListaMarcas;
        private readonly IMarcaService marcaService;
        private readonly ITiposArticulosService tipoArticuloService;
        private readonly IImpuestoService impuestoService;
        private List<TipoArticuloDTO> ListasTiposArticulos;
        private List<ImpuestoArticuloDTO> ListasImpuestos;
        private MarcaDTO MarcaActual;
        private TipoArticuloDTO TipoArticuloActual;
        private TipoArticuloEditarDTO TipoArticuloEditarDTO;
        private MarcaEditarDTO marcaEditarActual;
        private ImpuestoArticuloDTO impActual;
        private ImpuestoArticuloEditarDTO impuestoEditarActualDto;
        private List<EstadoImpuestoDTO> ListaEstadosImpuestos;
        
        public DatosConfiguraciones(IMarcaService marcaService, ITiposArticulosService tipoArticuloService, IImpuestoService impuestoService)
        {
            InitializeComponent();
            ListaMarcas = new List<MarcaDTO>();
            ListasTiposArticulos = new List<TipoArticuloDTO>();
            ListasImpuestos = new List<ImpuestoArticuloDTO>();
            ListaEstadosImpuestos = new List<EstadoImpuestoDTO>();
            this.marcaService = marcaService;
            this.tipoArticuloService = tipoArticuloService;
            this.impuestoService = impuestoService;
            this.CargarListas();
            this.cbxEstadoVisual.SelectedIndex = 0;
            this.cbxEstadoTipo.SelectedIndex = 0;

        }

        private async void CargarListas()
        {
            this.ListaMarcas.Clear();
            this.ListaMarcas = await this.marcaService.ListarMarcas();
            this.CargarTablaMarcas();
            this.ListasTiposArticulos.Clear();
            this.ListasTiposArticulos = await this.tipoArticuloService.ListarTiposArticulos();
            this.cargarTablaTiposArticulos();
            this.ListasImpuestos.Clear();
            this.ListasImpuestos = await this.impuestoService.ListarImpuestos();
            this.cargarTablaImpuestos();
            
        }

        private void CargarTablaMarcas()
        {
            this.dgvMarcas.Rows.Clear();
            foreach (var marca in ListaMarcas)
            {
                int index = this.dgvMarcas.Rows.Add(new object[]
                {
                    marca.Id,
                    marca.Nombre,
                    marca.Descripcion,
                    marca.EstadoVisual? "Visible": "No Visible"
                });
            }
        }

        private void cargarTablaTiposArticulos()
        {

            this.dgvTiposArticulos.Rows.Clear();
            foreach (var tipo in ListasTiposArticulos)
            {
                int index = this.dgvTiposArticulos.Rows.Add(new object[]
                {
                    tipo.Id,
                    tipo.Nombre,
                    tipo.Descripcion,
                    tipo.EstadoVisual? "Visible": "No Visible"
                });
            }
        }

        private void cargarTablaImpuestos()
        {
            this.dgvImpuestos.Rows.Clear();
            foreach (var impuesto in ListasImpuestos)
            {
                int index = this.dgvImpuestos.Rows.Add(new object[]
                {
                    impuesto.Id,
                    impuesto.IdEstadoImpuesto,
                    impuesto.EstadoImpuesto.Nombre,
                    impuesto.Nombre,
                    impuesto.ValorImpuesto,
                    impuesto.Descripcion,
                });
            }
        }

        private async void DatosConfiguraciones_Load(object sender, EventArgs e)
        {
            this.ListaEstadosImpuestos.Clear();
            this.ListaEstadosImpuestos = await this.impuestoService.ListarEstadosImpuestos();
            this.cbxEstadoImpuesto.DataSource = this.ListaEstadosImpuestos;
            this.cbxEstadoImpuesto.DisplayMember = "Nombre";
            this.cbxEstadoImpuesto.ValueMember = "Id";
        }

        private void btnCancelarTipo_Click(object sender, EventArgs e)
        {
            this.LimpiarFormulario();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtIdMarca is null || this.txtIdMarca.Text == "")
            {
                var resp = await this.CrearMarca();
                if (resp != null && resp > 0)
                {
                    MessageBox.Show($"Marca creada con éxito con el id: {resp}", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.MarcaActual.Id = resp;
                    this.ListaMarcas.Add(this.MarcaActual);
                    this.MarcaActual = new MarcaDTO();
                    this.CargarTablaMarcas();
                }
                else
                {
                    MessageBox.Show($"No se pudo crear la marca!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.CargarEditarMarcaDTO();
                var resp = await this.EditarMarca();
                if (resp)
                {
                    MessageBox.Show($"Marca con el id: {marcaEditarActual.Id}, editada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MarcaDTO marca = new MarcaDTO
                    {
                        Id = this.marcaEditarActual.Id,
                        Nombre = this.marcaEditarActual.Nombre,
                        Descripcion = this.marcaEditarActual.Descripcion,
                        EstadoVisual = this.marcaEditarActual.EstadoVisual
                    };
                    for (int i = 0; i < this.ListaMarcas.Count; i++)
                    {

                        if (this.ListaMarcas[i].Id == marca.Id)
                        {
                            this.ListaMarcas[i] = marca;
                        }
                    }
                    this.CargarTablaMarcas();
                    this.LimpiarFormulario();
                    this.marcaEditarActual = new MarcaEditarDTO();
                }
                else
                {
                    MessageBox.Show($"No se pudo editar la marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarEditarMarcaDTO()
        {
            this.marcaEditarActual = new MarcaEditarDTO();
            this.marcaEditarActual.Id = Convert.ToInt32(txtIdMarca.Text);
            this.marcaEditarActual.Nombre = this.txtNombreMarca.Text.ToUpper();
            this.marcaEditarActual.Descripcion = txtDescripcion.Text.ToUpper();
            this.marcaEditarActual.EstadoVisual = cbxEstadoVisual.SelectedIndex == 0 ? true : false;
        }

        private async Task<bool> EditarMarca()
        {
            bool resultado = await this.marcaService.EditarMarca(this.marcaEditarActual);
            return resultado;
        }
        private async Task<int> CrearMarca()
        {
            MarcaCreacionDTO marcaDto = new MarcaCreacionDTO();
            marcaDto.Nombre = txtNombreMarca.Text.ToUpper();
            marcaDto.EstadoVisual = (cbxEstadoVisual.SelectedIndex == 0);
            marcaDto.Descripcion = this.txtDescripcion.Text.ToUpper();
            var validator = new MarcaValidator();
            ValidationResult result = validator.Validate(marcaDto);
            if (!result.IsValid)
            {
                RecorrerErrores(result);
                return 0;
            }
            else
            {
                this.LimpiarFormulario();
                this.MarcaActual = new MarcaDTO()
                {
                    Nombre = marcaDto.Nombre,
                    Descripcion = marcaDto.Descripcion,
                    EstadoVisual = marcaDto.EstadoVisual
                };
                return await this.marcaService.CrearMarca(marcaDto);
            }
        }

        private void LimpiarFormulario()
        {
            txtIdMarca.Clear();
            txtDescripcion.Clear();
            txtNombreMarca.Clear();
            if (cbxEstadoVisual.Items.Count > 0) cbxEstadoVisual.SelectedIndex = 0;
        }
        private void RecorrerErrores(ValidationResult result)
        {
            if (result.Errors.Count > 1)
            {
                MessageBox.Show($"Error de Validacion,  hay campos obligatorios vacios!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    MessageBox.Show(error.ErrorMessage, $"Error de Validacion, {error.PropertyName}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvMarcas.Columns[e.ColumnIndex].Name == "Editar")
                {
                    id = Convert.ToInt32(dgvMarcas.Rows[e.RowIndex].Cells["IdMarca"].Value);
                    this.CargarEditarMarca(id);
                }
            }
            catch
            {
                throw;
            }
        }

        private void CargarEditarMarca(int idMarca)
        {
            MarcaDTO marcaActual = this.ListaMarcas.FirstOrDefault(a => a.Id == idMarca);
            this.txtNombreMarca.Text = marcaActual.Nombre.ToUpper();
            this.txtDescripcion.Text = (marcaActual.Descripcion ?? "").ToUpper();
            this.txtIdMarca.Text = Convert.ToString(marcaActual.Id);
            this.cbxEstadoVisual.SelectedIndex = marcaActual.EstadoVisual ? 0 : 1;
        }



        private void CargarEditarTipo(int idTipo)
        {
            TipoArticuloDTO tipoActual = this.ListasTiposArticulos.FirstOrDefault(a => a.Id == idTipo);
            this.txtNombreTipo.Text = tipoActual.Nombre.ToUpper();
            this.txtDescripcionTipo.Text = (tipoActual.Descripcion ?? "").ToUpper();
            this.txtIdTipo.Text = Convert.ToString(tipoActual.Id);
            this.cbxEstadoTipo.SelectedIndex = tipoActual.EstadoVisual ? 0 : 1;
        }

        private async void btnGuardarTipo_Click(object sender, EventArgs e)
        {
            if (this.txtIdTipo is null || this.txtIdTipo.Text == "")
            {
                var resp = await this.CrearTipoArticulo();
                if (resp != null && resp > 0)
                {
                    this.TipoArticuloActual.Id = resp;
                    MessageBox.Show($"Tipo artículo creado con éxito con el id: {resp}", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ListasTiposArticulos.Add(this.TipoArticuloActual);
                    this.TipoArticuloActual = new TipoArticuloDTO();
                    this.cargarTablaTiposArticulos();
                }
                else
                {
                    MessageBox.Show($"No se pudo crear el tipo articulo!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.CargarEditarTipoDTO();
                var resp = await this.EditarTipoArticulo();
                if (resp)
                {
                    MessageBox.Show($"Tipo Artículo con el id: {TipoArticuloEditarDTO.Id}, editado correctamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TipoArticuloDTO tipo = new TipoArticuloDTO
                    {
                        Id = this.TipoArticuloEditarDTO.Id,
                        Nombre = this.TipoArticuloEditarDTO.Nombre,
                        Descripcion = this.TipoArticuloEditarDTO.Descripcion,
                        EstadoVisual = this.TipoArticuloEditarDTO.EstadoVisual
                    };
                    for (int i = 0; i < this.ListasTiposArticulos.Count; i++)
                    {

                        if (this.ListasTiposArticulos[i].Id == tipo.Id)
                        {
                            this.ListasTiposArticulos[i] = tipo;
                            break;
                        }
                    }
                    this.cargarTablaTiposArticulos();
                    this.LimpiarFormularioTipo();
                    this.TipoArticuloEditarDTO = new TipoArticuloEditarDTO();
                }
                else
                {
                    MessageBox.Show($"No se pudo editar el tipo artículo!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async Task<bool> EditarTipoArticulo()
        {
            bool resultado = await this.tipoArticuloService.EditarTipoArticulo(this.TipoArticuloEditarDTO);
            return resultado;
        }
        private void LimpiarFormularioTipo()
        {
            txtIdTipo.Clear();
            txtDescripcionTipo.Clear();
            txtNombreTipo.Clear();
            if (cbxEstadoTipo.Items.Count > 0) cbxEstadoTipo.SelectedIndex = 0;
        }

        private async Task<int> CrearTipoArticulo()
        {
            TipoArticuloCreacionDTO tipoDto = new TipoArticuloCreacionDTO();
            tipoDto.Nombre = txtNombreTipo.Text.ToUpper();
            tipoDto.EstadoVisual = (cbxEstadoTipo.SelectedIndex == 0);
            tipoDto.Descripcion = this.txtDescripcionTipo.Text.ToUpper();
            var validator = new TipoArticuloValidator();
            ValidationResult result = validator.Validate(tipoDto);
            if (!result.IsValid)
            {
                RecorrerErrores(result);
                return 0;
            }
            else
            {
                this.LimpiarFormularioTipo();
                this.TipoArticuloActual = new TipoArticuloDTO()
                {
                    Nombre = tipoDto.Nombre,
                    Descripcion = tipoDto.Descripcion,
                    EstadoVisual = tipoDto.EstadoVisual
                };
                return await this.tipoArticuloService.CrearTipoArticulo(tipoDto);
            }
        }

        private void CargarEditarTipoDTO()
        {
            this.TipoArticuloEditarDTO = new TipoArticuloEditarDTO();
            this.TipoArticuloEditarDTO.Id = Convert.ToInt32(txtIdTipo.Text);
            this.TipoArticuloEditarDTO.Nombre = this.txtNombreTipo.Text.ToUpper();
            this.TipoArticuloEditarDTO.Descripcion = txtDescripcionTipo.Text.ToUpper();
            this.TipoArticuloEditarDTO.EstadoVisual = cbxEstadoTipo.SelectedIndex == 0 ? true : false;
        }

        private void dgvTiposArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvTiposArticulos.Columns[e.ColumnIndex].Name == "EditarTipo")
                {
                    id = Convert.ToInt32(dgvTiposArticulos.Rows[e.RowIndex].Cells["IdTipoArticulo"].Value);
                    this.CargarEditarTipo(id);
                }
            }
            catch
            {
                throw;
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            this.LimpiarFormulario();
        }

        private void dgvImpuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvImpuestos.Columns[e.ColumnIndex].Name == "EditarImpuesto")
                {
                    id = Convert.ToInt32(dgvImpuestos.Rows[e.RowIndex].Cells["IdImpuesto"].Value);
                    this.CargarEditarImpuesto(id);
                }
            }
            catch
            {
                throw;
            }
        }

        private void CargarEditarImpuesto(int idImpuesto)
        {
            ImpuestoArticuloDTO impuestoActual = this.ListasImpuestos.FirstOrDefault(i => i.Id == idImpuesto);
            this.txtNombreImpuesto.Text = impuestoActual.Nombre.ToUpper();
            this.txtDescripcionImpuesto.Text = (impuestoActual.Descripcion ?? "").ToUpper();
            this.nudValorImpuesto.Value = impuestoActual.ValorImpuesto;
            this.txtIdImpuesto.Text = Convert.ToString(impuestoActual.Id);
            this.cbxEstadoImpuesto.SelectedValue = impuestoActual.IdEstadoImpuesto;
        }

        private async void btbGuardarImpuesto_Click(object sender, EventArgs e)
        {
            if (this.txtIdImpuesto is null || this.txtIdImpuesto.Text == "")
            {
                var resp = await this.CrearImpuesto();
                if (resp != null && resp > 0)
                {
                    MessageBox.Show($"Impuesto artículo creado con éxito con el id: {resp}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.impActual.Id = resp;
                    ImpuestoArticuloDTO impTemp = this.CargarDatosRelacionados(this.impActual);
                    this.ListasImpuestos.Add(impTemp);
                    this.impActual = new ImpuestoArticuloDTO();
                    this.cargarTablaImpuestos();
                }
                else
                {
                    MessageBox.Show($"No se pudo crear el artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.CargarEditarImpuestoDTO();
                var resp = await this.ModificarImpuesto();
                if (resp)
                {
                    MessageBox.Show($"Impuesto con el id: {impuestoEditarActualDto.Id}, editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ImpuestoArticuloDTO imp = new ImpuestoArticuloDTO
                    {
                        Id = this.impuestoEditarActualDto.Id,
                        Nombre = this.impuestoEditarActualDto.Nombre,
                        Descripcion = this.impuestoEditarActualDto.Descripcion,
                        ValorImpuesto = this.impuestoEditarActualDto.ValorImpuesto,
                        IdEstadoImpuesto = this.impuestoEditarActualDto.IdEstadoImpuesto
                    };
                    imp = this.CargarDatosRelacionados(imp);
                    for (int i = 0; i < this.ListasImpuestos.Count; i++)
                    {
                        if (this.ListasImpuestos[i].Id == imp.Id)
                        {
                            this.ListasImpuestos[i] = imp;
                        }
                    }
                    this.cargarTablaImpuestos();
                    this.LimpiarFormularioImpuestos();
                    this.impuestoEditarActualDto = new ImpuestoArticuloEditarDTO();
                }
                else
                {
                    MessageBox.Show($"No se pudo crear el artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task<bool> ModificarImpuesto()
        {
            bool resultado = await this.impuestoService.EditarImpuesto(this.impuestoEditarActualDto);
            return resultado;
        }

        private void LimpiarFormularioImpuestos()
        {
            txtIdImpuesto.Clear();
            txtDescripcionImpuesto.Clear();
            txtNombreImpuesto.Clear();
            nudValorImpuesto.Value = 0;
            if (cbxEstadoImpuesto.Items.Count > 0) cbxEstadoImpuesto.SelectedIndex = 0;
        }

        private void CargarEditarImpuestoDTO()
        {
            this.impuestoEditarActualDto = new ImpuestoArticuloEditarDTO();
            this.impuestoEditarActualDto.Nombre = this.txtNombreImpuesto.Text.ToUpper();
            this.impuestoEditarActualDto.Descripcion = txtDescripcionImpuesto.Text.ToUpper();
            this.impuestoEditarActualDto.ValorImpuesto = Convert.ToDecimal(nudValorImpuesto.Value);
            this.impuestoEditarActualDto.IdEstadoImpuesto = Convert.ToInt32(cbxEstadoImpuesto.SelectedValue);
        }

        private ImpuestoArticuloDTO CargarDatosRelacionados(ImpuestoArticuloDTO impArt)
        {
            if (this.impuestoEditarActualDto != null)
            {
                impArt.EstadoImpuesto= this.ListaEstadosImpuestos.FirstOrDefault(i => i.Id == impuestoEditarActualDto.IdEstadoImpuesto);
            }
            else if (this.impActual != null)
            {
                impArt.EstadoImpuesto = this.ListaEstadosImpuestos.FirstOrDefault(est => est.Id == impActual.IdEstadoImpuesto);
            }
            return impArt;
        }
        
        
        private async Task<int> CrearImpuesto()
        {
            ImpuestoArticuloCreacionDTO impArticuloDto = new ImpuestoArticuloCreacionDTO();
            impArticuloDto.Nombre = txtNombreImpuesto.Text.ToUpper();
            impArticuloDto.IdEstadoImpuesto = Convert.ToInt32(cbxEstadoImpuesto.SelectedValue);
            impArticuloDto.ValorImpuesto= Convert.ToDecimal(nudValorImpuesto.Value);
            impArticuloDto.Descripcion = this.txtDescripcionImpuesto.Text.ToUpper();
            var validator = new ImpuestoValidator();
            ValidationResult result = validator.Validate(impArticuloDto);
            if (!result.IsValid)
            {
                RecorrerErrores(result);
                return 0;
            }
            else
            {
                this.LimpiarFormulario();
                this.impActual = new ImpuestoArticuloDTO { 
                    IdEstadoImpuesto = impArticuloDto.IdEstadoImpuesto,
                    Descripcion = impArticuloDto.Descripcion,
                    Nombre = impArticuloDto.Nombre,
                    ValorImpuesto= impArticuloDto.ValorImpuesto
                };
                return await this.impuestoService.CrearImpuesto(impArticuloDto);
            }
        }
    }
}
