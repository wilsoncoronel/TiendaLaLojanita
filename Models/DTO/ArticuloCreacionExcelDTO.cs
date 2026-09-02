using System;

namespace TiendaLaLojanita.Models.DTO
{
    // Clase derivada usada únicamente al procesar archivos Excel
    // Contiene información adicional del origen del registro (fila en Excel)
    public class ArticuloCreacionExcelDTO : ArticuloCreacionDTO
    {
        public int FilaExcel { get; set; }
    }
}
