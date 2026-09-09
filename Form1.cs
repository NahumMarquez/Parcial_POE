using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Form1 : Form
    {
        DataTable reservas = new DataTable();
        Dictionary<string, List<string>> peliculasPorCategoria = new Dictionary<string, List<string>>();
        Dictionary<string, decimal> precioPorCategoria = new Dictionary<string, decimal>();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

            
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPelicula.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbCategoria.Items.Add("Accion");
            cmbCategoria.Items.Add("Terror");
            cmbCategoria.Items.Add("Comedia");

            //Peliculas disponibles segun la categoria

            peliculasPorCategoria.Add("Accion", new List<string> { "Duro de Matar", "Mad Max", "John Wick" });
            peliculasPorCategoria.Add("Terror", new List<string> { "It", "Hereditary", "Insidious" });
            peliculasPorCategoria.Add("Comedia", new List<string> { "Nacho Libre", "Deadpool", "Zoolander" });


            //Precio del boleto segun la categoria

            precioPorCategoria.Add("Accion", 5.00m);
            precioPorCategoria.Add("Terror", 5.50m);
            precioPorCategoria.Add("Comedia", 5.50m);


            //Crear las columnas de la tabla en memoria

            reservas.Columns.Add("Nombre", typeof(string));
            reservas.Columns.Add("DUI", typeof(string));
            reservas.Columns.Add("Categoria", typeof(string));
            reservas.Columns.Add("Pelicula", typeof(string));
            reservas.Columns.Add("Boletos", typeof(int));
            reservas.Columns.Add("Total", typeof(string));

            //Enlazar los datos con el datagridview
            dgvReservas.DataSource = reservas;

            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.ReadOnly = true;
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.MultiSelect = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que todos los campos esten llenos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDUI.Text) ||
                    cmbCategoria.SelectedIndex == -1 ||
                    cmbPelicula.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Por favor, complete todos los campos.",
                        "Campos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                //Agregar la reserva a la tabla a nivel de memoria
                reservas.Rows.Add(
                    txtNombre.Text.Trim().ToUpper(),
                    txtDUI.Text.Trim(),
                    cmbCategoria.Text.ToUpper(),
                    cmbPelicula.Text.ToUpper(),
                    (int)nudcantidad.Value,
                    lblMonto.Text);

                MessageBox.Show(
                    "La reserva se agrego correctamente.",
                    "Informacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                //Limpiar controles

                txtNombre.Clear();
                txtDUI.Clear();
                cmbCategoria.SelectedIndex = -1;
                nudcantidad.Value = nudcantidad.Minimum;
                lblMonto.Text = "$0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrio un error al guardar la reserva: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otra tecla
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {
            // Quitar el guion para trabajar solo con los digitos
            string digitos = txtDUI.Text.Replace("-", "");

            // Limitar a maximo 9 digitos (00000000-0)
            if (digitos.Length > 9)
            {
                digitos = digitos.Substring(0, 9);
            }

            string textoFormateado = digitos;

            // Insertar el guion automaticamente despues del octavo digito
            if (digitos.Length > 8)
            {
                textoFormateado = digitos.Substring(0, 8) + "-" + digitos.Substring(8);
            }

            if (txtDUI.Text != textoFormateado)
            {
                txtDUI.Text = textoFormateado;
                txtDUI.SelectionStart = txtDUI.Text.Length; // mantiene el cursor al final
            }

            ValidarCampos();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDUI.Text = "";
            cmbCategoria.SelectedIndex = -1;
            cmbPelicula.Items.Clear();
            nudcantidad.Value = nudcantidad.Minimum;
            lblMonto.Text = "$0.00";
            btnAgregar.Enabled = false;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPelicula.Items.Clear();

            if (cmbCategoria.SelectedIndex != -1)
            {
                string categoriaSeleccionada = cmbCategoria.Text;

                if (peliculasPorCategoria.ContainsKey(categoriaSeleccionada))
                {
                    foreach (string pelicula in peliculasPorCategoria[categoriaSeleccionada])
                    {
                        cmbPelicula.Items.Add(pelicula);
                    }
                }
            }
            cmbPelicula.SelectedIndex = -1;

            CalcularTotal();
            ValidarCampos();
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
            ValidarCampos();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
            ValidarCampos();
        }

        private void CalcularTotal()
        {
            if (cmbCategoria.SelectedIndex != -1 && precioPorCategoria.ContainsKey(cmbCategoria.Text))
            {
                decimal precioBoleto = precioPorCategoria[cmbCategoria.Text];
                decimal total = precioBoleto * nudcantidad.Value;
                lblMonto.Text = total.ToString("C2");
            }
            else
            {
                lblMonto.Text = "$0.00";
            }
        }

        private void ValidarCampos()
        {
            bool nombreLleno = !string.IsNullOrWhiteSpace(txtNombre.Text);
            bool duiCompleto = txtDUI.Text.Trim().Length == 10; // 00000000-0
            bool categoriaSeleccionada = cmbCategoria.SelectedIndex != -1;
            bool peliculaSeleccionada = cmbPelicula.SelectedIndex != -1;

            btnAgregar.Enabled = nombreLleno && duiCompleto && categoriaSeleccionada && peliculaSeleccionada;
        }

        private void frmReservas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void dgvReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvReservas.Rows[e.RowIndex];

            // Usuario cancela deja color original
            Color colorOriginal = fila.DefaultCellStyle.BackColor;

            //Fila en rojo dato se desee eliminar
            fila.DefaultCellStyle.BackColor = Color.Red;
            fila.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            fila.DefaultCellStyle.ForeColor = Color.White;

            DialogResult resultado = MessageBox.Show(
                "Desea eliminar esta reserva?",
                "Confirmar Eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                //Elimina de la tabla en memoria la fila seleccionada
                reservas.Rows.RemoveAt(e.RowIndex);
            }
            else
            {
                fila.DefaultCellStyle.BackColor = colorOriginal;
                fila.DefaultCellStyle.SelectionBackColor = dgvReservas.DefaultCellStyle.SelectionBackColor;
                fila.DefaultCellStyle.ForeColor = dgvReservas.DefaultCellStyle.ForeColor;
            }
        }
    }
}
