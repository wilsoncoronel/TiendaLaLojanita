using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Registro_Compras : Form, ISesionReceptor
    {
        private readonly IProveedorService proveedorService;
        private readonly IArticuloService articuloService;
        private readonly ICompraService compraService;
        List<ArticuloDTO> listaArticulos;
        private int contador = 0;
        private decimal imp = 0;
        private int cant = 1;
        private int IdProveedor = 0;
        private List<EstadoCompraDTO> ListaEstados;
        private  List<Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>> listaImpuestos;
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }
        public Registro_Compras(IProveedorService proveedorService, IArticuloService articuloService, ICompraService compraService)
        {
            InitializeComponent();
            this.proveedorService = proveedorService;
            this.articuloService = articuloService;
            this.compraService = compraService;
            this.listaArticulos = new List<ArticuloDTO>();
            listaImpuestos = new List<Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>>();
        }

        private async void CargarDatosInciales()
        {
            this.ListaEstados = await this.compraService.ListarEstadosCompra();
            this.CargarCombos();
        }
        private void CargarCombos()
        {
            this.cbxEstadoCompra.DataSource = this.ListaEstados;
            this.cbxEstadoCompra.DisplayMember = "Nombre";
            this.cbxEstadoCompra.ValueMember = "Id";
        }

        private async void Registro_Compras_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = $"Usuario: {Sesion?.Usuario}";
            this.lblFechaIngreso.Text = $"Fecha Ingreso: {DateTime.Now.ToString("g")}";
            this.listaArticulos = await this.CargarListaArticulos();
            this.CargarDatosInciales();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var resp = await this.CrearCompra();
            if (resp == 0)
            {
                MessageBox.Show("No se pudo crear la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                int idCompra = resp;
                MessageBox.Show($"Compra creada con exito con el ID: {idCompra}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private async Task<int> CrearCompra()
        {
            try
            {
                int idCompra = 0;
                CompraCreacionDTO compraCreacionDTO = new CompraCreacionDTO();
                compraCreacionDTO.IdProveedor = this.IdProveedor; // Reemplazar con el ID real del proveedor
                compraCreacionDTO.Documento = this.txtDocumento.Text;
                compraCreacionDTO.FechaCompra = this.dtpCompra.Value;
                compraCreacionDTO.IdEstado = Convert.ToInt32(this.cbxEstadoCompra.SelectedValue); // Estado "Pendiente" por defecto
                compraCreacionDTO.EstadoVisual = true; // Estado visual "Activo" por defecto
                compraCreacionDTO.IdUsuarioCreador = this.Sesion.Id; // Reemplazar con el ID real del usuario creador
                compraCreacionDTO.DetalleComprasCreacionDto = new List<DetalleCompraCreacionDTO>();
                foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                {
                    if (row.IsNewRow) continue; // Saltar la fila nueva
                    DetalleCompraCreacionDTO detalle = new DetalleCompraCreacionDTO
                    {
                        ArticuloId = Convert.ToInt32(row.Cells["IdArticulo"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        ValorCompra = Convert.ToDecimal(row.Cells["ValorCompra"].Value),
                        ValorVenta = Convert.ToDecimal(row.Cells["ValorVenta"].Value),
                        ImpuestoValor = Convert.ToDecimal(row.Cells["ImpuestoValor"].Value),
                        ValorTotal = Convert.ToDecimal(row.Cells["ValorTotal"].Value),
                        Descripcion = row.Cells["Descripcion"].Value?.ToString()
                    };
                    compraCreacionDTO.DetalleComprasCreacionDto.Add(detalle);
                }
                var validator = new CompraValidator();
                ValidationResult result = validator.Validate(compraCreacionDTO);

                if (!result.IsValid)
                {
                    string errores = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                    MessageBox.Show($"Errores de validación:\n{errores}", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    idCompra = await this.compraService.RegistrarCompra(compraCreacionDTO);
                    return idCompra;
                }
                return idCompra;
            }
            catch(Exception ex)
            { 
                throw ex;
            }
        }

        private void btbBuscarProveedor_Click(object sender, EventArgs e)
        {
            this.CargarProveedor(this.txtIdentificacionProveedor.Text);
        }
        private async Task<List<ArticuloDTO>> CargarListaArticulos()
        {
            List<ArticuloDTO> listaArticulos;
            listaArticulos = await this.articuloService.ListarTodosArticulos();
            if (listaArticulos is null || listaArticulos.Count == 0)
            {
                MessageBox.Show("No se encontraron articulos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("No se encontraron articulos en el sistema");
            }
            return listaArticulos;
        }
        private async void CargarProveedor(string identificacion)
        {
            if (identificacion is null || identificacion == "")
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
                    this.IdProveedor = proveedor.Id;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BusquedaArticulo();
        }

        private void txtArticuloBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArticuloBusqueda.Text))
            {
                return;
            }
          this.BusquedaArticulo();
        }

        private void BusquedaArticulo()
        {
            ArticuloDTO articuloActual = new ArticuloDTO();
            articuloActual = this.listaArticulos.FirstOrDefault(art => art.Nombre == this.txtArticuloBusqueda.Text || art.Codigo == this.txtArticuloBusqueda.Text);
            if (articuloActual is null || articuloActual.Id == 0)
            {
                MessageBox.Show("No se encontro ningun articulo con el nombre o código ingresado!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtArticuloBusqueda.Text = "";
            }
            else
            {
                bool resp = this.ComprobarArticuloDgv(articuloActual.Id);
                if (resp)
                {
                    foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                    {
                        if (row.Cells["IdArticulo"].Value != null && Convert.ToInt32(row.Cells["IdArticulo"].Value) == articuloActual.Id)
                        {
                            row.Cells["Cantidad"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value) + 1;
                            this.ActualizarCantidad(articuloActual.Id, Convert.ToInt32(row.Cells["Cantidad"].Value), Convert.ToDecimal(row.Cells["ValorVenta"].Value));
                        }
                    }
                    this.LimpiarValores();
                }
                else
                {
                    this.CargarDataGrid(articuloActual);
                    this.LimpiarValores();
                }
            }
        }

        private void ActualizarCantidad(int idArticulo, int cantidad, decimal valorVenta)
        {
            foreach (var c in this.listaImpuestos)
            {
                foreach (var imp in c)
                {
                    imp.Value.Where(x => x.IdArticulo == idArticulo).ToList().ForEach(x =>
                    {
                        x.Cantidad = cantidad;
                        x.ValorVenta = valorVenta;
                    });
                }
            }
        }
        private void CargarDataGrid(ArticuloDTO articuloActual)
        {

            var existente = listaImpuestos.FirstOrDefault(dic => dic.ContainsKey(articuloActual.ImpuestoArticuloDto.Nombre));
            if (existente != null)
            {
                existente[articuloActual.ImpuestoArticuloDto.Nombre].Add(new ImpuestoArticuloCalculadoDTO
                {
                    NombreImpuesto = articuloActual.ImpuestoArticuloDto.Nombre,
                    IdArticulo = articuloActual.Id,
                    ValorImpuesto = articuloActual.ImpuestoArticuloDto.ValorImpuesto,
                    ValorVenta = articuloActual.ValorVenta,
                    Id = contador,
                    Cantidad = cant
                });
            }
            else
            {
                listaImpuestos.Add(new Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>
                {
                    { articuloActual.ImpuestoArticuloDto.Nombre, new List<ImpuestoArticuloCalculadoDTO>
                        {
                            new ImpuestoArticuloCalculadoDTO
                            {
                                NombreImpuesto = articuloActual.ImpuestoArticuloDto.Nombre,
                                IdArticulo = articuloActual.Id,
                                ValorImpuesto = articuloActual.ImpuestoArticuloDto.ValorImpuesto,
                                ValorVenta = articuloActual.ValorVenta,
                                Id = contador,
                                Cantidad = cant
                            }
                        }
                    }
                });
            }
            int index = this.dgvDetalleCompra.Rows.Add(new object[] {
                contador,
                0,
                articuloActual.Id,
                articuloActual.Nombre,
                articuloActual.Descripcion,
                cant,
                articuloActual.ValorCompra,
                articuloActual.ValorVenta,
                0,
                0,
            });

            DataGridViewRow fila = this.dgvDetalleCompra.Rows[index];
            DataGridViewCell celdaContador = fila.Cells[0];
            decimal valorImpuesto = (cant* articuloActual.ValorVenta)*articuloActual.ImpuestoArticuloDto.ValorImpuesto;
            fila.Cells[8].Value = valorImpuesto;
            fila.Cells[9].Value = articuloActual.ValorVenta * cant;
            contador++;
            
        }

        private void LimpiarValores()
        {
            this.imp = 0;
            this.txtArticuloBusqueda.Text = "";
        }

       /* private decimal CalcularValorImpuesto(int cant, ArticuloDTO articuloActual,int contador)
        {
            decimal tot = 0;
            switch (articuloActual.ImpuestoArticuloDto.Nombre)
            {
                case "12 %":
                    tot = articuloActual.ValorVenta * articuloActual.ImpuestoArticuloDto.ValorImpuesto;
                    this.imp = tot;
                    this.CargarTotales(articuloActual, tot,contador, cant);
                    break;
                case "15 %":
                    tot = articuloActual.ValorVenta * articuloActual.ImpuestoArticuloDto.ValorImpuesto;
                    this.imp = tot;
                    this.CargarTotales(articuloActual, tot, contador, cant);
                    break;
                case "Incluido Iva 15%":
                    tot = articuloActual.ValorVenta * articuloActual.ImpuestoArticuloDto.ValorImpuesto;
                    this.imp =0;
                    this.CargarTotales(articuloActual, tot, contador, cant);
                    break;
                case "Iva 0%":
                    tot = 0;
                    this.imp = tot;
                        this.CargarTotales(articuloActual, tot, contador, cant);
                break;
            }
            return tot;
        }

        private void CargarTotales(ArticuloDTO articuloActual, decimal tot, int contador, int cant)
        {
            var totImpuestos = 0m;
            var existente = listaImpuestos.FirstOrDefault(dic => dic.ContainsKey(articuloActual.ImpuestoArticuloDto.Nombre));
            if (existente != null)
            {
                if (existente[articuloActual.ImpuestoArticuloDto.Nombre].Count(im => im.IdArticulo == articuloActual.Id && im.Id == contador) > cant) {
                    var listaImpuesto = existente[articuloActual.ImpuestoArticuloDto.Nombre];
                    // Buscar el último objeto que coincida con el artículo
                    var ultimoImpuesto = listaImpuesto
                        .LastOrDefault(im => im.IdArticulo == articuloActual.Id && im.Id == contador);

                    if (ultimoImpuesto != null)
                    {
                        listaImpuesto.Remove(ultimoImpuesto);
                    }
                }
                else
                {
                    do
                    {
                        existente[articuloActual.ImpuestoArticuloDto.Nombre].Add(new ImpuestoCalculadoDTO
                        {
                            IdArticulo = articuloActual.Id,
                            ValorImpuesto = tot,
                            Id = contador 
                        });
                    } while (cant > existente[articuloActual.ImpuestoArticuloDto.Nombre].Count(im => im.IdArticulo == articuloActual.Id && im.Id == contador));
                }
            }
            else
            {
                listaImpuestos.Add(new Dictionary<string, List<ImpuestoCalculadoDTO>>
                {
                    { articuloActual.ImpuestoArticuloDto.Nombre, new List<ImpuestoCalculadoDTO>
                        {
                            new ImpuestoCalculadoDTO
                            {
                                IdArticulo = articuloActual.Id,
                                ValorImpuesto = tot,
                                Id = contador
                            }
                        }
                    }
                });

                totImpuestos = tot;
            }
            CalcularTotales();
        }*/
       /* private void CalcularTotales()
        {
            decimal totIva15 = 0m;
            decimal totIva12 = 0m;
            decimal totIvaIncluido15 = 0m;
            decimal totIva0 = 0m;

            foreach (var imp in this.listaImpuestos)
            {
                foreach (var nom in imp)
                {
                    if(nom.Key == "15 %")
                    {
                        totIva15 = nom.Value.Sum(x => x.ValorImpuesto);
                        this.imp = totIva15;
                    }
                    if (nom.Key == "12 %")
                    {
                        totIva12 = nom.Value.Sum(x => x.ValorImpuesto);
                        this.imp = totIva12;
                    }
                    if (nom.Key == "Incluido Iva 15%")
                    {
                        totIva12 = nom.Value.Sum(x => x.ValorImpuesto);
                        this.imp = totIvaIncluido15;
                    }
                    if (nom.Key == "0%")
                    {
                        totIva0 = nom.Value.Sum(x => x.ValorImpuesto);
                        this.imp = totIva0;
                    }
                }
            }
            this.lblIva15.Text = $"Sub. Iva 15%: {totIva15}";
            this.lblIncluidoIva15.Text = $"Sub. Iva 15% Inlcuido: {totIvaIncluido15}";
            this.lblSubSinIva.Text = $"Sub. 0%: {totIva0}";
        }*/
        private void EliminarImpuestoPorId(int id)
        {
            // Recorremos cada diccionario (por cada tipo de impuesto)
            foreach (var dic in listaImpuestos)
            {
                // Obtenemos la clave (nombre del impuesto)
                string nombreImpuesto = dic.Keys.First();

                // Eliminamos todos los ImpuestoCalculadoDTO con ese ID
                dic[nombreImpuesto].RemoveAll(x => x.Id == id);
            }

            // También puedes eliminar el diccionario si la lista quedó vacía
            listaImpuestos.RemoveAll(dic => dic.Values.First().Count == 0);
        }
        private bool ComprobarArticuloDgv(int idArticulo)
        {
            foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
            {
                if (row.Cells["IdArticulo"].Value != null && Convert.ToInt32(row.Cells["IdArticulo"].Value) == idArticulo)
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        private void dgvDetalleCompra_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int cantida;
            decimal valorVenta;
            if (dgvDetalleCompra.Columns[e.ColumnIndex].Name == "Cantidad" || dgvDetalleCompra.Columns[e.ColumnIndex].Name == "ValorVenta")
            {

                DataGridViewRow fila = dgvDetalleCompra.Rows[e.RowIndex];
                if (int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantida) && decimal.TryParse(fila.Cells["ValorVenta"].Value?.ToString(), out valorVenta))
                {
                    //this.CalcularValorImpuestoDgv(Convert.ToInt32(fila.Cells["Cantidad"].Value), Convert.ToInt32(fila.Cells["IdArticulo"].Value), Convert.ToInt32(fila.Cells["Id"].Value), Convert.ToDecimal(fila.Cells["ValorVenta"].Value));
                    fila.Cells["ValorTotal"].Value = cantida * valorVenta;
                    this.ActualizarCantidad(Convert.ToInt32(fila.Cells["IdArticulo"].Value), Convert.ToInt32(fila.Cells["Cantidad"].Value),Convert.ToDecimal(fila.Cells["ValorVenta"].Value));
                }
            }
            this.imp = 0;
        }

        /*private void CalcularValorImpuestoDgv(int cantidad, int idArticulo, int contador, decimal valorVenta = 0)
        {
            ArticuloDTO articuloActual = this.listaArticulos.FirstOrDefault(art => art.Id == idArticulo);
            if(valorVenta == 0)
            {
                this.CalcularValorImpuesto(cantidad, articuloActual, contador);
            }
            else
            {
                articuloActual.ValorVenta = valorVenta;
                this.CalcularValorImpuesto(cantidad, articuloActual, contador);
            }
                
        }
        */
        private void dgvDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvDetalleCompra.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    dgvDetalleCompra.Rows.RemoveAt(e.RowIndex);
                    EliminarImpuestoPorId(Convert.ToInt32(dgvDetalleCompra.Rows[e.RowIndex].Cells["Id"].Value));
                }
            }
            catch
            {
                throw;
            }
        }

        private void dgvDetalleCompra_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (dgvDetalleCompra.Columns[dgvDetalleCompra.CurrentCell.ColumnIndex].Name)
            {
                case "ValorVenta":
                    if (e.Control is TextBox)
                    {
                        TextBox textBox = e.Control as TextBox;
                        textBox.KeyPress -= new KeyPressEventHandler(textBox_KeyPress);
                        textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
                    }
                    break;
                case "Cantidad":
                    if (e.Control is TextBox)
                    {
                        TextBox textBox = e.Control as TextBox;
                        textBox.KeyPress -= new KeyPressEventHandler(textBox_KeyPressPunto);
                        textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPressPunto);
                    }
                    break;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtenemos el separador decimal del sistema
            char separadorDecimal = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            // Permitimos dígitos, el separador decimal y la tecla de retroceso (para borrar)
            if (char.IsDigit(e.KeyChar) || e.KeyChar == separadorDecimal || e.KeyChar == (char)Keys.Back)
            {
                // Permitimos la tecla
                e.Handled = false;
            }
            else
            {
                // Cancelamos la tecla (no la mostramos en la celda)
                e.Handled = true;
            }
        }

        private void textBox_KeyPressPunto(object sender, KeyPressEventArgs e)
        {
            // Permitimos dígitos, y la tecla de retroceso (para borrar)
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Permitimos la tecla
                e.Handled = false;
            }
            else
            {
                // Cancelamos la tecla (no la mostramos en la celda)
                e.Handled = true;
            }
        }

        private void txtIdentificacionProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CargarProveedor(this.txtIdentificacionProveedor.Text);
                e.SuppressKeyPress = true; // Evita el sonido de "ding" al presionar Enter
            }
        }
    }

}
