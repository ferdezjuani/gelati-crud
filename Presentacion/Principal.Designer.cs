namespace Presentacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dgv_Principal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Notificaciones = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Borrar = new System.Windows.Forms.RadioButton();
            this.rb_Editar = new System.Windows.Forms.RadioButton();
            this.rb_Agregar = new System.Windows.Forms.RadioButton();
            this.gb_Agregar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_AgFecha = new System.Windows.Forms.DateTimePicker();
            this.tb_AgDescripcion = new System.Windows.Forms.TextBox();
            this.cb_AgCategoria = new System.Windows.Forms.ComboBox();
            this.nud_AdCant = new System.Windows.Forms.NumericUpDown();
            this.tb_AgNombre = new System.Windows.Forms.TextBox();
            this.btn_AgLimpiar = new System.Windows.Forms.Button();
            this.btn_AgAgregar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_BusqBorrar = new System.Windows.Forms.Button();
            this.btn_BusqBuscar = new System.Windows.Forms.Button();
            this.tb_Buscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Cerrar = new System.Windows.Forms.Label();
            this.gb_Editar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_EdFecha = new System.Windows.Forms.DateTimePicker();
            this.tb_EdDescripcion = new System.Windows.Forms.TextBox();
            this.cb_EdCategoria = new System.Windows.Forms.ComboBox();
            this.nud_EdCant = new System.Windows.Forms.NumericUpDown();
            this.tb_EdNombre = new System.Windows.Forms.TextBox();
            this.btn_EdLimpiar = new System.Windows.Forms.Button();
            this.btn_EdEditar = new System.Windows.Forms.Button();
            this.gb_Borrar = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp_BoFecha = new System.Windows.Forms.DateTimePicker();
            this.tb_BoDescripcion = new System.Windows.Forms.TextBox();
            this.cb_BoCategoria = new System.Windows.Forms.ComboBox();
            this.nud_BoCant = new System.Windows.Forms.NumericUpDown();
            this.tb_BoNombre = new System.Windows.Forms.TextBox();
            this.btn_BoLimpiar = new System.Windows.Forms.Button();
            this.btn_BoBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Principal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_Agregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AdCant)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Editar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EdCant)).BeginInit();
            this.gb_Borrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BoCant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Principal
            // 
            this.dgv_Principal.AllowUserToAddRows = false;
            this.dgv_Principal.AllowUserToDeleteRows = false;
            this.dgv_Principal.AllowUserToResizeColumns = false;
            this.dgv_Principal.AllowUserToResizeRows = false;
            this.dgv_Principal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Principal.Location = new System.Drawing.Point(12, 12);
            this.dgv_Principal.MultiSelect = false;
            this.dgv_Principal.Name = "dgv_Principal";
            this.dgv_Principal.ReadOnly = true;
            this.dgv_Principal.RowHeadersVisible = false;
            this.dgv_Principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Principal.Size = new System.Drawing.Size(363, 314);
            this.dgv_Principal.TabIndex = 0;
            this.dgv_Principal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Principal_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_Notificaciones);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notificaciones";
            // 
            // lbl_Notificaciones
            // 
            this.lbl_Notificaciones.Location = new System.Drawing.Point(17, 17);
            this.lbl_Notificaciones.Name = "lbl_Notificaciones";
            this.lbl_Notificaciones.Size = new System.Drawing.Size(324, 26);
            this.lbl_Notificaciones.TabIndex = 0;
            this.lbl_Notificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rb_Borrar);
            this.groupBox2.Controls.Add(this.rb_Editar);
            this.groupBox2.Controls.Add(this.rb_Agregar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(381, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acción";
            // 
            // rb_Borrar
            // 
            this.rb_Borrar.AutoSize = true;
            this.rb_Borrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rb_Borrar.Location = new System.Drawing.Point(156, 19);
            this.rb_Borrar.Name = "rb_Borrar";
            this.rb_Borrar.Size = new System.Drawing.Size(59, 17);
            this.rb_Borrar.TabIndex = 2;
            this.rb_Borrar.TabStop = true;
            this.rb_Borrar.Text = "Borrar";
            this.rb_Borrar.UseVisualStyleBackColor = true;
            this.rb_Borrar.CheckedChanged += new System.EventHandler(this.rb_Borrar_CheckedChanged);
            // 
            // rb_Editar
            // 
            this.rb_Editar.AutoSize = true;
            this.rb_Editar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rb_Editar.Location = new System.Drawing.Point(86, 19);
            this.rb_Editar.Name = "rb_Editar";
            this.rb_Editar.Size = new System.Drawing.Size(58, 17);
            this.rb_Editar.TabIndex = 1;
            this.rb_Editar.Text = "Editar";
            this.rb_Editar.UseVisualStyleBackColor = true;
            this.rb_Editar.CheckedChanged += new System.EventHandler(this.rb_Editar_CheckedChanged);
            // 
            // rb_Agregar
            // 
            this.rb_Agregar.AutoSize = true;
            this.rb_Agregar.Checked = true;
            this.rb_Agregar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rb_Agregar.Location = new System.Drawing.Point(8, 19);
            this.rb_Agregar.Name = "rb_Agregar";
            this.rb_Agregar.Size = new System.Drawing.Size(69, 17);
            this.rb_Agregar.TabIndex = 0;
            this.rb_Agregar.TabStop = true;
            this.rb_Agregar.Text = "Agregar";
            this.rb_Agregar.UseVisualStyleBackColor = true;
            this.rb_Agregar.CheckedChanged += new System.EventHandler(this.rb_Agregar_CheckedChanged);
            // 
            // gb_Agregar
            // 
            this.gb_Agregar.BackColor = System.Drawing.Color.Transparent;
            this.gb_Agregar.Controls.Add(this.label5);
            this.gb_Agregar.Controls.Add(this.label4);
            this.gb_Agregar.Controls.Add(this.label3);
            this.gb_Agregar.Controls.Add(this.label2);
            this.gb_Agregar.Controls.Add(this.label1);
            this.gb_Agregar.Controls.Add(this.dtp_AgFecha);
            this.gb_Agregar.Controls.Add(this.tb_AgDescripcion);
            this.gb_Agregar.Controls.Add(this.cb_AgCategoria);
            this.gb_Agregar.Controls.Add(this.nud_AdCant);
            this.gb_Agregar.Controls.Add(this.tb_AgNombre);
            this.gb_Agregar.Controls.Add(this.btn_AgLimpiar);
            this.gb_Agregar.Controls.Add(this.btn_AgAgregar);
            this.gb_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Agregar.Location = new System.Drawing.Point(381, 164);
            this.gb_Agregar.Name = "gb_Agregar";
            this.gb_Agregar.Size = new System.Drawing.Size(218, 281);
            this.gb_Agregar.TabIndex = 3;
            this.gb_Agregar.TabStop = false;
            this.gb_Agregar.Text = "Agregar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cant.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de carga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del producto:";
            // 
            // dtp_AgFecha
            // 
            this.dtp_AgFecha.CustomFormat = "dd/MM/yyyy";
            this.dtp_AgFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_AgFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_AgFecha.Location = new System.Drawing.Point(6, 123);
            this.dtp_AgFecha.Name = "dtp_AgFecha";
            this.dtp_AgFecha.Size = new System.Drawing.Size(144, 20);
            this.dtp_AgFecha.TabIndex = 5;
            // 
            // tb_AgDescripcion
            // 
            this.tb_AgDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AgDescripcion.Location = new System.Drawing.Point(6, 163);
            this.tb_AgDescripcion.Multiline = true;
            this.tb_AgDescripcion.Name = "tb_AgDescripcion";
            this.tb_AgDescripcion.Size = new System.Drawing.Size(203, 82);
            this.tb_AgDescripcion.TabIndex = 7;
            // 
            // cb_AgCategoria
            // 
            this.cb_AgCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AgCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AgCategoria.FormattingEnabled = true;
            this.cb_AgCategoria.Location = new System.Drawing.Point(6, 82);
            this.cb_AgCategoria.Name = "cb_AgCategoria";
            this.cb_AgCategoria.Size = new System.Drawing.Size(203, 21);
            this.cb_AgCategoria.TabIndex = 4;
            // 
            // nud_AdCant
            // 
            this.nud_AdCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_AdCant.Location = new System.Drawing.Point(156, 123);
            this.nud_AdCant.Name = "nud_AdCant";
            this.nud_AdCant.Size = new System.Drawing.Size(53, 20);
            this.nud_AdCant.TabIndex = 6;
            // 
            // tb_AgNombre
            // 
            this.tb_AgNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AgNombre.Location = new System.Drawing.Point(6, 39);
            this.tb_AgNombre.Name = "tb_AgNombre";
            this.tb_AgNombre.Size = new System.Drawing.Size(203, 20);
            this.tb_AgNombre.TabIndex = 3;
            // 
            // btn_AgLimpiar
            // 
            this.btn_AgLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgLimpiar.Location = new System.Drawing.Point(110, 251);
            this.btn_AgLimpiar.Name = "btn_AgLimpiar";
            this.btn_AgLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_AgLimpiar.TabIndex = 9;
            this.btn_AgLimpiar.Text = "Limpiar";
            this.btn_AgLimpiar.UseVisualStyleBackColor = true;
            this.btn_AgLimpiar.Click += new System.EventHandler(this.btn_AgLimpiar_Click);
            // 
            // btn_AgAgregar
            // 
            this.btn_AgAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgAgregar.Location = new System.Drawing.Point(29, 251);
            this.btn_AgAgregar.Name = "btn_AgAgregar";
            this.btn_AgAgregar.Size = new System.Drawing.Size(75, 23);
            this.btn_AgAgregar.TabIndex = 8;
            this.btn_AgAgregar.Text = "Agregar";
            this.btn_AgAgregar.UseVisualStyleBackColor = true;
            this.btn_AgAgregar.Click += new System.EventHandler(this.btn_AgAgregar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btn_BusqBorrar);
            this.groupBox4.Controls.Add(this.btn_BusqBuscar);
            this.groupBox4.Controls.Add(this.tb_Buscar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 54);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscador de productos";
            // 
            // btn_BusqBorrar
            // 
            this.btn_BusqBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BusqBorrar.Location = new System.Drawing.Point(294, 19);
            this.btn_BusqBorrar.Name = "btn_BusqBorrar";
            this.btn_BusqBorrar.Size = new System.Drawing.Size(61, 23);
            this.btn_BusqBorrar.TabIndex = 12;
            this.btn_BusqBorrar.Text = "Borrar";
            this.btn_BusqBorrar.UseVisualStyleBackColor = true;
            this.btn_BusqBorrar.Click += new System.EventHandler(this.btn_BusqBorrar_Click);
            // 
            // btn_BusqBuscar
            // 
            this.btn_BusqBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BusqBuscar.Location = new System.Drawing.Point(232, 19);
            this.btn_BusqBuscar.Name = "btn_BusqBuscar";
            this.btn_BusqBuscar.Size = new System.Drawing.Size(61, 23);
            this.btn_BusqBuscar.TabIndex = 11;
            this.btn_BusqBuscar.Text = "Buscar";
            this.btn_BusqBuscar.UseVisualStyleBackColor = true;
            this.btn_BusqBuscar.Click += new System.EventHandler(this.btn_BusqBuscar_Click);
            // 
            // tb_Buscar
            // 
            this.tb_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Buscar.Location = new System.Drawing.Point(8, 21);
            this.tb_Buscar.Name = "tb_Buscar";
            this.tb_Buscar.Size = new System.Drawing.Size(218, 20);
            this.tb_Buscar.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.LogoHelado1;
            this.pictureBox1.Location = new System.Drawing.Point(381, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Cerrar
            // 
            this.lbl_Cerrar.AutoSize = true;
            this.lbl_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cerrar.Font = new System.Drawing.Font("Arcon Rounded-", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Cerrar.Location = new System.Drawing.Point(583, 0);
            this.lbl_Cerrar.Name = "lbl_Cerrar";
            this.lbl_Cerrar.Size = new System.Drawing.Size(23, 23);
            this.lbl_Cerrar.TabIndex = 2;
            this.lbl_Cerrar.Text = "X";
            this.lbl_Cerrar.Click += new System.EventHandler(this.lbl_Cerrar_Click);
            // 
            // gb_Editar
            // 
            this.gb_Editar.BackColor = System.Drawing.Color.Transparent;
            this.gb_Editar.Controls.Add(this.label6);
            this.gb_Editar.Controls.Add(this.label7);
            this.gb_Editar.Controls.Add(this.label8);
            this.gb_Editar.Controls.Add(this.label9);
            this.gb_Editar.Controls.Add(this.label10);
            this.gb_Editar.Controls.Add(this.dtp_EdFecha);
            this.gb_Editar.Controls.Add(this.tb_EdDescripcion);
            this.gb_Editar.Controls.Add(this.cb_EdCategoria);
            this.gb_Editar.Controls.Add(this.nud_EdCant);
            this.gb_Editar.Controls.Add(this.tb_EdNombre);
            this.gb_Editar.Controls.Add(this.btn_EdLimpiar);
            this.gb_Editar.Controls.Add(this.btn_EdEditar);
            this.gb_Editar.Enabled = false;
            this.gb_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Editar.Location = new System.Drawing.Point(381, 164);
            this.gb_Editar.Name = "gb_Editar";
            this.gb_Editar.Size = new System.Drawing.Size(218, 281);
            this.gb_Editar.TabIndex = 11;
            this.gb_Editar.TabStop = false;
            this.gb_Editar.Text = "Editar";
            this.gb_Editar.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cant.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Última modificación:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Categoría:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nombre del producto:";
            // 
            // dtp_EdFecha
            // 
            this.dtp_EdFecha.CustomFormat = "dd/MM/yyyy";
            this.dtp_EdFecha.Enabled = false;
            this.dtp_EdFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EdFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EdFecha.Location = new System.Drawing.Point(6, 123);
            this.dtp_EdFecha.Name = "dtp_EdFecha";
            this.dtp_EdFecha.Size = new System.Drawing.Size(144, 20);
            this.dtp_EdFecha.TabIndex = 5;
            // 
            // tb_EdDescripcion
            // 
            this.tb_EdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EdDescripcion.Location = new System.Drawing.Point(6, 163);
            this.tb_EdDescripcion.Multiline = true;
            this.tb_EdDescripcion.Name = "tb_EdDescripcion";
            this.tb_EdDescripcion.Size = new System.Drawing.Size(203, 82);
            this.tb_EdDescripcion.TabIndex = 7;
            // 
            // cb_EdCategoria
            // 
            this.cb_EdCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EdCategoria.FormattingEnabled = true;
            this.cb_EdCategoria.Location = new System.Drawing.Point(6, 82);
            this.cb_EdCategoria.Name = "cb_EdCategoria";
            this.cb_EdCategoria.Size = new System.Drawing.Size(203, 21);
            this.cb_EdCategoria.TabIndex = 4;
            // 
            // nud_EdCant
            // 
            this.nud_EdCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_EdCant.Location = new System.Drawing.Point(156, 123);
            this.nud_EdCant.Name = "nud_EdCant";
            this.nud_EdCant.Size = new System.Drawing.Size(53, 20);
            this.nud_EdCant.TabIndex = 6;
            // 
            // tb_EdNombre
            // 
            this.tb_EdNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EdNombre.Location = new System.Drawing.Point(6, 39);
            this.tb_EdNombre.Name = "tb_EdNombre";
            this.tb_EdNombre.Size = new System.Drawing.Size(203, 20);
            this.tb_EdNombre.TabIndex = 3;
            // 
            // btn_EdLimpiar
            // 
            this.btn_EdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EdLimpiar.Location = new System.Drawing.Point(110, 251);
            this.btn_EdLimpiar.Name = "btn_EdLimpiar";
            this.btn_EdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_EdLimpiar.TabIndex = 9;
            this.btn_EdLimpiar.Text = "Limpiar";
            this.btn_EdLimpiar.UseVisualStyleBackColor = true;
            this.btn_EdLimpiar.Click += new System.EventHandler(this.btn_EdLimpiar_Click);
            // 
            // btn_EdEditar
            // 
            this.btn_EdEditar.Enabled = false;
            this.btn_EdEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EdEditar.Location = new System.Drawing.Point(29, 251);
            this.btn_EdEditar.Name = "btn_EdEditar";
            this.btn_EdEditar.Size = new System.Drawing.Size(75, 23);
            this.btn_EdEditar.TabIndex = 8;
            this.btn_EdEditar.Text = "Editar";
            this.btn_EdEditar.UseVisualStyleBackColor = true;
            this.btn_EdEditar.Click += new System.EventHandler(this.btn_EdEditar_Click);
            // 
            // gb_Borrar
            // 
            this.gb_Borrar.BackColor = System.Drawing.Color.Transparent;
            this.gb_Borrar.Controls.Add(this.label11);
            this.gb_Borrar.Controls.Add(this.label12);
            this.gb_Borrar.Controls.Add(this.label13);
            this.gb_Borrar.Controls.Add(this.label14);
            this.gb_Borrar.Controls.Add(this.label15);
            this.gb_Borrar.Controls.Add(this.dtp_BoFecha);
            this.gb_Borrar.Controls.Add(this.tb_BoDescripcion);
            this.gb_Borrar.Controls.Add(this.cb_BoCategoria);
            this.gb_Borrar.Controls.Add(this.nud_BoCant);
            this.gb_Borrar.Controls.Add(this.tb_BoNombre);
            this.gb_Borrar.Controls.Add(this.btn_BoLimpiar);
            this.gb_Borrar.Controls.Add(this.btn_BoBorrar);
            this.gb_Borrar.Enabled = false;
            this.gb_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Borrar.Location = new System.Drawing.Point(381, 164);
            this.gb_Borrar.Name = "gb_Borrar";
            this.gb_Borrar.Size = new System.Drawing.Size(218, 281);
            this.gb_Borrar.TabIndex = 12;
            this.gb_Borrar.TabStop = false;
            this.gb_Borrar.Text = "Borrar";
            this.gb_Borrar.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Descripción:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(153, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Cant.:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Última modificación:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Categoría:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Nombre del producto:";
            // 
            // dtp_BoFecha
            // 
            this.dtp_BoFecha.CustomFormat = "dd/MM/yyyy";
            this.dtp_BoFecha.Enabled = false;
            this.dtp_BoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_BoFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_BoFecha.Location = new System.Drawing.Point(6, 123);
            this.dtp_BoFecha.Name = "dtp_BoFecha";
            this.dtp_BoFecha.Size = new System.Drawing.Size(144, 20);
            this.dtp_BoFecha.TabIndex = 5;
            // 
            // tb_BoDescripcion
            // 
            this.tb_BoDescripcion.Enabled = false;
            this.tb_BoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BoDescripcion.Location = new System.Drawing.Point(6, 163);
            this.tb_BoDescripcion.Multiline = true;
            this.tb_BoDescripcion.Name = "tb_BoDescripcion";
            this.tb_BoDescripcion.Size = new System.Drawing.Size(203, 82);
            this.tb_BoDescripcion.TabIndex = 7;
            // 
            // cb_BoCategoria
            // 
            this.cb_BoCategoria.Enabled = false;
            this.cb_BoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BoCategoria.FormattingEnabled = true;
            this.cb_BoCategoria.Location = new System.Drawing.Point(6, 82);
            this.cb_BoCategoria.Name = "cb_BoCategoria";
            this.cb_BoCategoria.Size = new System.Drawing.Size(203, 21);
            this.cb_BoCategoria.TabIndex = 4;
            // 
            // nud_BoCant
            // 
            this.nud_BoCant.Enabled = false;
            this.nud_BoCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_BoCant.Location = new System.Drawing.Point(156, 123);
            this.nud_BoCant.Name = "nud_BoCant";
            this.nud_BoCant.Size = new System.Drawing.Size(53, 20);
            this.nud_BoCant.TabIndex = 6;
            // 
            // tb_BoNombre
            // 
            this.tb_BoNombre.Enabled = false;
            this.tb_BoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BoNombre.Location = new System.Drawing.Point(6, 39);
            this.tb_BoNombre.Name = "tb_BoNombre";
            this.tb_BoNombre.Size = new System.Drawing.Size(203, 20);
            this.tb_BoNombre.TabIndex = 3;
            // 
            // btn_BoLimpiar
            // 
            this.btn_BoLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BoLimpiar.Location = new System.Drawing.Point(110, 251);
            this.btn_BoLimpiar.Name = "btn_BoLimpiar";
            this.btn_BoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_BoLimpiar.TabIndex = 9;
            this.btn_BoLimpiar.Text = "Limpiar";
            this.btn_BoLimpiar.UseVisualStyleBackColor = true;
            this.btn_BoLimpiar.Click += new System.EventHandler(this.btn_BoLimpiar_Click);
            // 
            // btn_BoBorrar
            // 
            this.btn_BoBorrar.Enabled = false;
            this.btn_BoBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BoBorrar.Location = new System.Drawing.Point(29, 251);
            this.btn_BoBorrar.Name = "btn_BoBorrar";
            this.btn_BoBorrar.Size = new System.Drawing.Size(75, 23);
            this.btn_BoBorrar.TabIndex = 8;
            this.btn_BoBorrar.Text = "Borrar";
            this.btn_BoBorrar.UseVisualStyleBackColor = true;
            this.btn_BoBorrar.Click += new System.EventHandler(this.btn_BoBorrar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.lbl_Cerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Principal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_Borrar);
            this.Controls.Add(this.gb_Agregar);
            this.Controls.Add(this.gb_Editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Principal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_Agregar.ResumeLayout(false);
            this.gb_Agregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AdCant)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Editar.ResumeLayout(false);
            this.gb_Editar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EdCant)).EndInit();
            this.gb_Borrar.ResumeLayout(false);
            this.gb_Borrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BoCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Principal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb_Agregar;
        private System.Windows.Forms.RadioButton rb_Borrar;
        private System.Windows.Forms.RadioButton rb_Editar;
        private System.Windows.Forms.RadioButton rb_Agregar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_AgLimpiar;
        private System.Windows.Forms.Button btn_AgAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Cerrar;
        private System.Windows.Forms.DateTimePicker dtp_AgFecha;
        private System.Windows.Forms.TextBox tb_AgDescripcion;
        private System.Windows.Forms.ComboBox cb_AgCategoria;
        private System.Windows.Forms.NumericUpDown nud_AdCant;
        private System.Windows.Forms.TextBox tb_AgNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Editar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_EdFecha;
        private System.Windows.Forms.TextBox tb_EdDescripcion;
        private System.Windows.Forms.ComboBox cb_EdCategoria;
        private System.Windows.Forms.NumericUpDown nud_EdCant;
        private System.Windows.Forms.TextBox tb_EdNombre;
        private System.Windows.Forms.Button btn_EdLimpiar;
        private System.Windows.Forms.Button btn_EdEditar;
        private System.Windows.Forms.GroupBox gb_Borrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp_BoFecha;
        private System.Windows.Forms.TextBox tb_BoDescripcion;
        private System.Windows.Forms.ComboBox cb_BoCategoria;
        private System.Windows.Forms.NumericUpDown nud_BoCant;
        private System.Windows.Forms.TextBox tb_BoNombre;
        private System.Windows.Forms.Button btn_BoLimpiar;
        private System.Windows.Forms.Button btn_BoBorrar;
        private System.Windows.Forms.Label lbl_Notificaciones;
        private System.Windows.Forms.TextBox tb_Buscar;
        private System.Windows.Forms.Button btn_BusqBorrar;
        private System.Windows.Forms.Button btn_BusqBuscar;
    }
}

