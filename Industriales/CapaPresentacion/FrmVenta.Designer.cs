namespace CapaPresentacion
{
    partial class FrmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnCtaCte = new System.Windows.Forms.RadioButton();
            this.rbnTarjeta = new System.Windows.Forms.RadioButton();
            this.rbnContado = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataCliente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProductoNuevo = new System.Windows.Forms.Button();
            this.dataListadoProductos = new System.Windows.Forms.DataGridView();
            this.dataVentas = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtBuscarProductos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.btnBusarCliente = new System.Windows.Forms.Button();
            this.IdD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnCtaCte);
            this.groupBox1.Controls.Add(this.rbnTarjeta);
            this.groupBox1.Controls.Add(this.rbnContado);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Facturación:";
            // 
            // rbnCtaCte
            // 
            this.rbnCtaCte.AutoSize = true;
            this.rbnCtaCte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnCtaCte.Location = new System.Drawing.Point(85, 23);
            this.rbnCtaCte.Name = "rbnCtaCte";
            this.rbnCtaCte.Size = new System.Drawing.Size(76, 18);
            this.rbnCtaCte.TabIndex = 1;
            this.rbnCtaCte.Text = "Cta. Cte.";
            this.rbnCtaCte.UseVisualStyleBackColor = true;
            this.rbnCtaCte.CheckedChanged += new System.EventHandler(this.rbnCtaCte_CheckedChanged);
            // 
            // rbnTarjeta
            // 
            this.rbnTarjeta.AutoSize = true;
            this.rbnTarjeta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTarjeta.Location = new System.Drawing.Point(181, 23);
            this.rbnTarjeta.Name = "rbnTarjeta";
            this.rbnTarjeta.Size = new System.Drawing.Size(66, 18);
            this.rbnTarjeta.TabIndex = 0;
            this.rbnTarjeta.Text = "Tarjeta";
            this.rbnTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbnContado
            // 
            this.rbnContado.AutoSize = true;
            this.rbnContado.Checked = true;
            this.rbnContado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnContado.Location = new System.Drawing.Point(5, 23);
            this.rbnContado.Name = "rbnContado";
            this.rbnContado.Size = new System.Drawing.Size(74, 18);
            this.rbnContado.TabIndex = 1;
            this.rbnContado.TabStop = true;
            this.rbnContado.Text = "Contado";
            this.rbnContado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaVenta);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1075, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de Venta:";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(28, 23);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(117, 23);
            this.dtpFechaVenta.TabIndex = 0;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(467, 30);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(16, 20);
            this.txtIdentificador.TabIndex = 5;
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarApellido.Location = new System.Drawing.Point(180, 30);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(284, 20);
            this.txtBuscarApellido.TabIndex = 3;
            this.txtBuscarApellido.TextChanged += new System.EventHandler(this.txtBuscarApellido_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Cyan;
            this.lblCliente.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(8, 54);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(100, 27);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarDni.Location = new System.Drawing.Point(180, 4);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(151, 20);
            this.txtBuscarDni.TabIndex = 1;
            this.txtBuscarDni.TextChanged += new System.EventHandler(this.txtBuscarDni_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionar por nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar con documento:";
            // 
            // dataCliente
            // 
            this.dataCliente.AllowUserToAddRows = false;
            this.dataCliente.AllowUserToDeleteRows = false;
            this.dataCliente.AllowUserToOrderColumns = true;
            this.dataCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCliente.BackgroundColor = System.Drawing.Color.Teal;
            this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCliente.Location = new System.Drawing.Point(602, 2);
            this.dataCliente.Name = "dataCliente";
            this.dataCliente.ReadOnly = true;
            this.dataCliente.Size = new System.Drawing.Size(614, 101);
            this.dataCliente.TabIndex = 5;
            this.dataCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCliente_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNumeroFactura);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Location = new System.Drawing.Point(410, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 58);
            this.panel1.TabIndex = 6;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNumeroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(0, 29);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(433, 29);
            this.lblNumeroFactura.TabIndex = 7;
            this.lblNumeroFactura.Text = "111199";
            this.lblNumeroFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.GreenYellow;
            this.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(0, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(433, 29);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "NUMERO DE FACTURA";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblSubTotal);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnProductoNuevo);
            this.panel2.Controls.Add(this.dataListadoProductos);
            this.panel2.Controls.Add(this.dataVentas);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCantidadProducto);
            this.panel2.Controls.Add(this.txtBuscarProductos);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(15, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 472);
            this.panel2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::CapaPresentacion.Properties.Resources.confirmar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(826, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 24);
            this.button3.TabIndex = 42;
            this.button3.Text = "&Confirmar Venta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnProductoNuevo
            // 
            this.btnProductoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoNuevo.Image = global::CapaPresentacion.Properties.Resources.productoNuevo;
            this.btnProductoNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoNuevo.Location = new System.Drawing.Point(632, 148);
            this.btnProductoNuevo.Name = "btnProductoNuevo";
            this.btnProductoNuevo.Size = new System.Drawing.Size(179, 24);
            this.btnProductoNuevo.TabIndex = 41;
            this.btnProductoNuevo.Text = "&Producto Nuevo";
            this.btnProductoNuevo.UseVisualStyleBackColor = true;
            this.btnProductoNuevo.Click += new System.EventHandler(this.btnProductoNuevo_Click_1);
            // 
            // dataListadoProductos
            // 
            this.dataListadoProductos.AllowUserToAddRows = false;
            this.dataListadoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListadoProductos.BackgroundColor = System.Drawing.Color.Gray;
            this.dataListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoProductos.GridColor = System.Drawing.Color.DimGray;
            this.dataListadoProductos.Location = new System.Drawing.Point(43, 29);
            this.dataListadoProductos.Name = "dataListadoProductos";
            this.dataListadoProductos.Size = new System.Drawing.Size(962, 112);
            this.dataListadoProductos.TabIndex = 3;
            // 
            // dataVentas
            // 
            this.dataVentas.AllowUserToAddRows = false;
            this.dataVentas.BackgroundColor = System.Drawing.Color.Gray;
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdD,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5,
            this.Column6});
            this.dataVentas.GridColor = System.Drawing.Color.DimGray;
            this.dataVentas.Location = new System.Drawing.Point(43, 175);
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.Size = new System.Drawing.Size(962, 294);
            this.dataVentas.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::CapaPresentacion.Properties.Resources.carrito;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(438, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 24);
            this.button2.TabIndex = 38;
            this.button2.Text = "&Agregar al carrito";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(40, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Buscar Productos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 14);
            this.label3.TabIndex = 30;
            this.label3.Text = "Introducir la cantidad:";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadProducto.Location = new System.Drawing.Point(306, 149);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(104, 20);
            this.txtCantidadProducto.TabIndex = 31;
            // 
            // txtBuscarProductos
            // 
            this.txtBuscarProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProductos.Location = new System.Drawing.Point(180, 5);
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.Size = new System.Drawing.Size(357, 20);
            this.txtBuscarProductos.TabIndex = 2;
            this.txtBuscarProductos.TextChanged += new System.EventHandler(this.txtBuscarProductos_TextChanged_1);
            this.txtBuscarProductos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBuscarProductos_MouseDown_1);
            this.txtBuscarProductos.MouseEnter += new System.EventHandler(this.txtBuscarProductos_MouseEnter_1);
            this.txtBuscarProductos.MouseLeave += new System.EventHandler(this.txtBuscarProductos_MouseLeave_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(543, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ingresar codigo en forma manual:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CapaPresentacion.Properties.Resources.lupa1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1009, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar&Producto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(788, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 22);
            this.textBox2.TabIndex = 4;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Cyan;
            this.lblStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(44, 147);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(63, 22);
            this.lblStock.TabIndex = 34;
            this.lblStock.Text = "Stock";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.lblHabilitado);
            this.panel3.Controls.Add(this.txtBuscarApellido);
            this.panel3.Controls.Add(this.txtIdentificador);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dataCliente);
            this.panel3.Controls.Add(this.txtBuscarDni);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblCliente);
            this.panel3.Controls.Add(this.btnBusarCliente);
            this.panel3.Location = new System.Drawing.Point(15, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 108);
            this.panel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::CapaPresentacion.Properties.Resources.clienteNuevo;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(465, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 26);
            this.button4.TabIndex = 7;
            this.button4.Text = "&Nuevo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.AutoSize = true;
            this.lblHabilitado.BackColor = System.Drawing.Color.Yellow;
            this.lblHabilitado.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilitado.Location = new System.Drawing.Point(3, 53);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(198, 55);
            this.lblHabilitado.TabIndex = 6;
            this.lblHabilitado.Text = "Cliente";
            this.lblHabilitado.Visible = false;
            // 
            // btnBusarCliente
            // 
            this.btnBusarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusarCliente.Image = global::CapaPresentacion.Properties.Resources.buscar_cliente1;
            this.btnBusarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusarCliente.Location = new System.Drawing.Point(333, 2);
            this.btnBusarCliente.Name = "btnBusarCliente";
            this.btnBusarCliente.Size = new System.Drawing.Size(131, 26);
            this.btnBusarCliente.TabIndex = 2;
            this.btnBusarCliente.Text = "&Buscar";
            this.btnBusarCliente.UseVisualStyleBackColor = false;
            this.btnBusarCliente.Click += new System.EventHandler(this.btnBusarCliente_Click);
            // 
            // IdD
            // 
            this.IdD.HeaderText = "IdV";
            this.IdD.Name = "IdD";
            this.IdD.ReadOnly = true;
            this.IdD.Visible = false;
            this.IdD.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CANT.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "D  E  S  C  R  I  P  C  I  Ó  N";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 625;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "P. UNIT.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "IMPORTE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "IdP";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 30;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IGV";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(1022, 248);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(85, 18);
            this.lblSubTotal.TabIndex = 43;
            this.lblSubTotal.Text = "Sub Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1022, 277);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 18);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "Total:";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 678);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmVenta";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnTarjeta;
        private System.Windows.Forms.RadioButton rbnContado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnBusarCliente;
        private System.Windows.Forms.DataGridView dataCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHabilitado;
        private System.Windows.Forms.Button btnProductoNuevo;
        private System.Windows.Forms.DataGridView dataListadoProductos;
        private System.Windows.Forms.DataGridView dataVentas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.TextBox txtBuscarProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rbnCtaCte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}