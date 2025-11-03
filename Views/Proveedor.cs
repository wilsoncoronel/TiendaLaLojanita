using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Views
{
    public partial class Proveedor : Form
    {
        private readonly IProveedorService _proveedorService;

        public Proveedor(IProveedorService proveedorService)
        {
            InitializeComponent();
            this._proveedorService = proveedorService;
        }



        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
