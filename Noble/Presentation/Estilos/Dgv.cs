using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Estilos
{
    public class Dgv
    {
        //public static void AplicarEstilosSiBotones(DataGridView dgv)
        //{
        //    dgv.EnableHeadersVisualStyles = false; // Desactivar los estilos visuales predeterminados de los encabezados
        //    dgv.BackgroundColor = Color.FromArgb(255, 255, 255);  // color de fondo del dgv blanco 
        //    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(42, 54, 75); // Color de fondo
        //    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // Color de las letras
        //    dgv.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular); // Cambiar el tamaño de la letra para las celdas
        //    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular); // Cambiar el tamaño de la letra y hacerla negrita para los encabezados de columna
        //    dgv.RowHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular); // Cambiar el tamaño de la letra para los encabezados de fila (si aplicable)
        //    dgv.DefaultCellStyle.ForeColor = Color.Black; // color de las letras de las filas a negro

        //    // Ocultar la primera columna (row headers)
        //    dgv.RowHeadersVisible = false;

        //    // Desactivar la capacidad de cambiar la altura de las filas
        //    dgv.AllowUserToResizeRows = false;

        //    // Verificar si el DataGridView tiene contenido
        //    if (dgv.Rows.Count > 0)
        //    {
        //        // Verificar si ya existen columnas con los nombres "Editar" y "Eliminar"
        //        bool existeColumnaEditar = dgv.Columns.Cast<DataGridViewColumn>().Any(col => col.HeaderText == "Editar");
        //        bool existeColumnaEliminar = dgv.Columns.Cast<DataGridViewColumn>().Any(col => col.HeaderText == "Eliminar");

        //        // Crear columna "Editar" si no existe
        //        if (!existeColumnaEditar)
        //        {
        //            DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
        //            columnaEditar.HeaderText = "Editar";
        //            columnaEditar.Name = "Editar"; // Nombre de la columna
        //            columnaEditar.Image = Properties.Resources.editar;
        //            columnaEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
        //            dgv.Columns.Add(columnaEditar);
        //        }

        //        // Crear columna "Eliminar" si no existe
        //        if (!existeColumnaEliminar)
        //        {
        //            DataGridViewImageColumn columnaEliminar = new DataGridViewImageColumn();
        //            columnaEliminar.HeaderText = "Eliminar";
        //            columnaEliminar.Name = "Eliminar"; // Nombre de la columna
        //            columnaEliminar.Image = Properties.Resources.eliminar;
        //            columnaEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
        //            dgv.Columns.Add(columnaEliminar);
        //        }

        //    }
        //}
        public static void AplicarEstilosNoBotones(DataGridView dgv)
        {
            // Desactivar estilos visuales de los encabezados de columna
            dgv.EnableHeadersVisualStyles = false;

            // Establecer el color de fondo del DataGridView y de las filas
            dgv.BackgroundColor = Color.FromArgb(229, 229, 229);
            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);

            // Establecer el color de fondo de los encabezados de columna
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(252, 163, 17);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Establecer la fuente para las celdas
            dgv.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dgv.RowHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            // Agregar padding al contenido de las celdas
            dgv.DefaultCellStyle.Padding = new Padding(10);

            // Ocultar la primera columna (row headers)
            dgv.RowHeadersVisible = false;

            // Desactivar la capacidad de cambiar la altura de las filas
            dgv.AllowUserToResizeRows = false;

            // Desactivar la capacidad de agregar, editar y eliminar filas
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            // Desactivar la capacidad de reordenar columnas
            dgv.AllowUserToOrderColumns = false;

            // Ajustar automáticamente la altura de las filas según su contenido
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Ajustar automáticamente el ancho de las columnas según su contenido y luego agregar 50
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].Width += 0;
            }

            // Quitar la línea de división vertical entre las columnas
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Establecer el color de las líneas que separan los encabezados de columna
            dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;

            // Quitar la línea de división entre las columnas
            dgv.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dgv.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

        }

        public static void AplicarEstilosBtnAgregar(DataGridView dgv)
        {
            // Desactivar estilos visuales de los encabezados de columna
            dgv.EnableHeadersVisualStyles = false;

            // Establecer el color de fondo del DataGridView y de las filas
            dgv.BackgroundColor = Color.White;

            // Establecer el color de fondo de las filas
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            // Establecer el color de selección de toda la fila
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 229, 229);
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 31, 61);

            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(252, 163, 17);
            // Configurar el modo de selección para toda la fila
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Establecer el color de fondo de los encabezados de columna
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(252, 163, 17);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Establecer la fuente para las celdas
            dgv.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dgv.RowHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            // Agregar padding al contenido de las celdas
            dgv.DefaultCellStyle.Padding = new Padding(10);

            // Ocultar la primera columna (row headers)
            dgv.RowHeadersVisible = false;

            // Desactivar la capacidad de cambiar la altura de las filas
            dgv.AllowUserToResizeRows = false;

            // Desactivar la capacidad de agregar, editar y eliminar filas
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            // Desactivar la capacidad de reordenar columnas
            dgv.AllowUserToOrderColumns = false;

            // Ajustar automáticamente la altura de las filas según su contenido
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Ajustar automáticamente el ancho de las columnas según su contenido y luego agregar 50
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].Width += 0;
            }

            // Quitar la línea de división vertical entre las columnas
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Establecer el color de las líneas que separan los encabezados de columna
            dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            dgv.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dgv.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            // Verificar si ya existe una columna con el nombre "Agregar"
            bool existeColumnaAgregar = dgv.Columns.Cast<DataGridViewColumn>().Any(col => col.HeaderText == "Agregar");

            // Crear columna "Agregar" si no existe
            if (!existeColumnaAgregar)
            {
                DataGridViewImageColumn columnaAgregar = new DataGridViewImageColumn();
                columnaAgregar.HeaderText = "+";
                columnaAgregar.Name = "Agregar"; // Nombre de la columna
                columnaAgregar.Image = Properties.Resources.mas; // Aquí debes proporcionar la imagen que deseas utilizar
                columnaAgregar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv.Columns.Insert(0, columnaAgregar); // Insertar la columna al principio
            }


        }










    }
}
