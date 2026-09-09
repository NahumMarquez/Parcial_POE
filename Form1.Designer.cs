namespace Parcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblMonto = new Label();
            lbTotal = new Label();
            nudcantidad = new NumericUpDown();
            lblCantidad = new Label();
            btnAgregar = new Button();
            cmbPelicula = new ComboBox();
            cmbCategoria = new ComboBox();
            txtDUI = new TextBox();
            txtNombre = new TextBox();
            lbPelicula = new Label();
            lblCategoria = new Label();
            lblDUI = new Label();
            lblNombre = new Label();
            panel2 = new Panel();
            TapPage = new TabControl();
            tabPage = new TabPage();
            dgvReservas = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudcantidad).BeginInit();
            panel2.SuspendLayout();
            TapPage.SuspendLayout();
            tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(nudcantidad);
            panel1.Controls.Add(lblCantidad);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(cmbPelicula);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(txtDUI);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lbPelicula);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblDUI);
            panel1.Controls.Add(lblNombre);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 646);
            panel1.TabIndex = 0;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(356, 257);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 16);
            lblMonto.TabIndex = 12;
            lblMonto.Text = "$0.00";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(209, 257);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(87, 16);
            lbTotal.TabIndex = 11;
            lbTotal.Text = "Total pago:";
            // 
            // nudcantidad
            // 
            nudcantidad.Location = new Point(200, 180);
            nudcantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudcantidad.Name = "nudcantidad";
            nudcantidad.Size = new Size(46, 22);
            nudcantidad.TabIndex = 5;
            nudcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudcantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(57, 187);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 16);
            lblCantidad.TabIndex = 9;
            lblCantidad.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(306, 309);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 41);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbPelicula
            // 
            cmbPelicula.FormattingEnabled = true;
            cmbPelicula.Location = new Point(200, 137);
            cmbPelicula.Name = "cmbPelicula";
            cmbPelicula.Size = new Size(307, 24);
            cmbPelicula.TabIndex = 4;
            cmbPelicula.SelectedIndexChanged += cmbPelicula_SelectedIndexChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(200, 96);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(307, 24);
            cmbCategoria.TabIndex = 3;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // txtDUI
            // 
            txtDUI.Location = new Point(200, 58);
            txtDUI.Name = "txtDUI";
            txtDUI.Size = new Size(307, 22);
            txtDUI.TabIndex = 1;
            txtDUI.TextChanged += txtDUI_TextChanged;
            txtDUI.KeyPress += txtDUI_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(200, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(307, 22);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lbPelicula
            // 
            lbPelicula.AutoSize = true;
            lbPelicula.Location = new Point(57, 145);
            lbPelicula.Name = "lbPelicula";
            lbPelicula.Size = new Size(63, 16);
            lbPelicula.TabIndex = 3;
            lbPelicula.Text = "Pelicula";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(57, 104);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(75, 16);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // lblDUI
            // 
            lblDUI.AutoSize = true;
            lblDUI.Location = new Point(57, 64);
            lblDUI.Name = "lblDUI";
            lblDUI.Size = new Size(37, 16);
            lblDUI.TabIndex = 1;
            lblDUI.Text = "DUI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(57, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(66, 16);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.Controls.Add(TapPage);
            panel2.Location = new Point(12, 366);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 268);
            panel2.TabIndex = 1;
            // 
            // TapPage
            // 
            TapPage.Controls.Add(tabPage);
            TapPage.Dock = DockStyle.Fill;
            TapPage.Location = new Point(0, 0);
            TapPage.Name = "TapPage";
            TapPage.SelectedIndex = 0;
            TapPage.Size = new Size(876, 268);
            TapPage.TabIndex = 0;
            // 
            // tabPage
            // 
            tabPage.Controls.Add(dgvReservas);
            tabPage.Location = new Point(4, 25);
            tabPage.Name = "tabPage";
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(868, 239);
            tabPage.TabIndex = 1;
            tabPage.Text = "Reservas";
            tabPage.UseVisualStyleBackColor = true;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Dock = DockStyle.Fill;
            dgvReservas.Location = new Point(3, 3);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.RowTemplate.Height = 24;
            dgvReservas.Size = new Size(862, 233);
            dgvReservas.TabIndex = 0;
            dgvReservas.CellDoubleClick += dgvReservas_CellDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 646);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Reservas";
            Load += frmReservas_Load;
            KeyDown += frmReservas_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudcantidad).EndInit();
            panel2.ResumeLayout(false);
            TapPage.ResumeLayout(false);
            tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbPelicula;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.TabControl TapPage;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudcantidad;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lbTotal;
    }
}

