namespace Capa_Visual
{
    partial class Form_Articulos
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
            this.textbox_nombre1 = new System.Windows.Forms.TextBox();
            this.numericUpDown_stock1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_precio1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_articulos = new System.Windows.Forms.DataGridView();
            this.checkBox_nombre = new System.Windows.Forms.CheckBox();
            this.checkBox_stock = new System.Windows.Forms.CheckBox();
            this.checkBox_precio = new System.Windows.Forms.CheckBox();
            this.boton_buscar = new FontAwesome.Sharp.IconButton();
            this.boton_agregar = new FontAwesome.Sharp.IconButton();
            this.boton_editar = new FontAwesome.Sharp.IconButton();
            this.boton_borrar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_es_hamburguesa1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_pepino = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_cebolla = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_tomate = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_lechuga = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_queso = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_patypollo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_patycarne = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown_pan = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_descripcion1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_descripcion2 = new System.Windows.Forms.TextBox();
            this.checkBox_descripcion = new System.Windows.Forms.CheckBox();
            this.textBox_nombre2 = new System.Windows.Forms.TextBox();
            this.numericUpDown_stock2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_precio2 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView_hamburguesa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_precio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articulos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pepino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cebolla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tomate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lechuga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_queso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_patypollo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_patycarne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_precio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hamburguesa)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_nombre1
            // 
            this.textbox_nombre1.Location = new System.Drawing.Point(119, 3);
            this.textbox_nombre1.Name = "textbox_nombre1";
            this.textbox_nombre1.Size = new System.Drawing.Size(120, 20);
            this.textbox_nombre1.TabIndex = 1;
            // 
            // numericUpDown_stock1
            // 
            this.numericUpDown_stock1.Location = new System.Drawing.Point(120, 29);
            this.numericUpDown_stock1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_stock1.Name = "numericUpDown_stock1";
            this.numericUpDown_stock1.Size = new System.Drawing.Size(119, 20);
            this.numericUpDown_stock1.TabIndex = 2;
            // 
            // numericUpDown_precio1
            // 
            this.numericUpDown_precio1.DecimalPlaces = 2;
            this.numericUpDown_precio1.Location = new System.Drawing.Point(120, 55);
            this.numericUpDown_precio1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_precio1.Name = "numericUpDown_precio1";
            this.numericUpDown_precio1.Size = new System.Drawing.Size(119, 20);
            this.numericUpDown_precio1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stock: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio:";
            // 
            // dataGridView_articulos
            // 
            this.dataGridView_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_articulos.Location = new System.Drawing.Point(12, 308);
            this.dataGridView_articulos.Name = "dataGridView_articulos";
            this.dataGridView_articulos.ReadOnly = true;
            this.dataGridView_articulos.RowHeadersVisible = false;
            this.dataGridView_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_articulos.Size = new System.Drawing.Size(504, 225);
            this.dataGridView_articulos.TabIndex = 11;
            this.dataGridView_articulos.SelectionChanged += new System.EventHandler(this.dataGridView_articulos_SelectionChanged);
            // 
            // checkBox_nombre
            // 
            this.checkBox_nombre.AutoSize = true;
            this.checkBox_nombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_nombre.ForeColor = System.Drawing.Color.White;
            this.checkBox_nombre.Location = new System.Drawing.Point(3, 2);
            this.checkBox_nombre.Name = "checkBox_nombre";
            this.checkBox_nombre.Size = new System.Drawing.Size(75, 20);
            this.checkBox_nombre.TabIndex = 17;
            this.checkBox_nombre.Text = "Nombre: ";
            this.checkBox_nombre.UseVisualStyleBackColor = true;
            // 
            // checkBox_stock
            // 
            this.checkBox_stock.AutoSize = true;
            this.checkBox_stock.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_stock.ForeColor = System.Drawing.Color.White;
            this.checkBox_stock.Location = new System.Drawing.Point(3, 27);
            this.checkBox_stock.Name = "checkBox_stock";
            this.checkBox_stock.Size = new System.Drawing.Size(65, 20);
            this.checkBox_stock.TabIndex = 18;
            this.checkBox_stock.Text = "Stock: ";
            this.checkBox_stock.UseVisualStyleBackColor = true;
            // 
            // checkBox_precio
            // 
            this.checkBox_precio.AutoSize = true;
            this.checkBox_precio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_precio.ForeColor = System.Drawing.Color.White;
            this.checkBox_precio.Location = new System.Drawing.Point(3, 53);
            this.checkBox_precio.Name = "checkBox_precio";
            this.checkBox_precio.Size = new System.Drawing.Size(67, 20);
            this.checkBox_precio.TabIndex = 20;
            this.checkBox_precio.Text = "Precio: ";
            this.checkBox_precio.UseVisualStyleBackColor = true;
            // 
            // boton_buscar
            // 
            this.boton_buscar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.boton_buscar.FlatAppearance.BorderSize = 0;
            this.boton_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.boton_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_buscar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_buscar.ForeColor = System.Drawing.Color.White;
            this.boton_buscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.boton_buscar.IconColor = System.Drawing.Color.White;
            this.boton_buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_buscar.IconSize = 40;
            this.boton_buscar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.boton_buscar.Location = new System.Drawing.Point(3, 239);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(268, 44);
            this.boton_buscar.TabIndex = 22;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = false;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // boton_agregar
            // 
            this.boton_agregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.boton_agregar.FlatAppearance.BorderSize = 0;
            this.boton_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.boton_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_agregar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_agregar.ForeColor = System.Drawing.Color.White;
            this.boton_agregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.boton_agregar.IconColor = System.Drawing.Color.White;
            this.boton_agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_agregar.IconSize = 28;
            this.boton_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_agregar.Location = new System.Drawing.Point(3, 181);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(238, 30);
            this.boton_agregar.TabIndex = 23;
            this.boton_agregar.Text = "Agregar";
            this.boton_agregar.UseVisualStyleBackColor = false;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // boton_editar
            // 
            this.boton_editar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.boton_editar.FlatAppearance.BorderSize = 0;
            this.boton_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.boton_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_editar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_editar.ForeColor = System.Drawing.Color.White;
            this.boton_editar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.boton_editar.IconColor = System.Drawing.Color.White;
            this.boton_editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_editar.IconSize = 30;
            this.boton_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_editar.Location = new System.Drawing.Point(3, 217);
            this.boton_editar.Name = "boton_editar";
            this.boton_editar.Size = new System.Drawing.Size(238, 30);
            this.boton_editar.TabIndex = 24;
            this.boton_editar.Text = "Editar";
            this.boton_editar.UseVisualStyleBackColor = false;
            this.boton_editar.Click += new System.EventHandler(this.boton_editar_Click);
            // 
            // boton_borrar
            // 
            this.boton_borrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.boton_borrar.FlatAppearance.BorderSize = 0;
            this.boton_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.boton_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_borrar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_borrar.ForeColor = System.Drawing.Color.White;
            this.boton_borrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.boton_borrar.IconColor = System.Drawing.Color.White;
            this.boton_borrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_borrar.IconSize = 28;
            this.boton_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_borrar.Location = new System.Drawing.Point(2, 253);
            this.boton_borrar.Name = "boton_borrar";
            this.boton_borrar.Size = new System.Drawing.Size(238, 30);
            this.boton_borrar.TabIndex = 25;
            this.boton_borrar.Text = "Borrar";
            this.boton_borrar.UseVisualStyleBackColor = false;
            this.boton_borrar.Click += new System.EventHandler(this.boton_borrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.checkBox_es_hamburguesa1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.numericUpDown_pepino);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numericUpDown_cebolla);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.numericUpDown_tomate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numericUpDown_lechuga);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDown_queso);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDown_patypollo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDown_patycarne);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.numericUpDown_pan);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox_descripcion1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textbox_nombre1);
            this.panel1.Controls.Add(this.numericUpDown_stock1);
            this.panel1.Controls.Add(this.boton_borrar);
            this.panel1.Controls.Add(this.boton_editar);
            this.panel1.Controls.Add(this.numericUpDown_precio1);
            this.panel1.Controls.Add(this.boton_agregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 290);
            this.panel1.TabIndex = 27;
            // 
            // checkBox_es_hamburguesa1
            // 
            this.checkBox_es_hamburguesa1.AutoSize = true;
            this.checkBox_es_hamburguesa1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_es_hamburguesa1.ForeColor = System.Drawing.Color.White;
            this.checkBox_es_hamburguesa1.Location = new System.Drawing.Point(263, 3);
            this.checkBox_es_hamburguesa1.Name = "checkBox_es_hamburguesa1";
            this.checkBox_es_hamburguesa1.Size = new System.Drawing.Size(107, 20);
            this.checkBox_es_hamburguesa1.TabIndex = 62;
            this.checkBox_es_hamburguesa1.Text = "Hamburguesa: ";
            this.checkBox_es_hamburguesa1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(259, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 61;
            this.label11.Text = "Pepino:";
            // 
            // numericUpDown_pepino
            // 
            this.numericUpDown_pepino.Location = new System.Drawing.Point(372, 263);
            this.numericUpDown_pepino.Name = "numericUpDown_pepino";
            this.numericUpDown_pepino.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_pepino.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(259, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "Cebolla:";
            // 
            // numericUpDown_cebolla
            // 
            this.numericUpDown_cebolla.Location = new System.Drawing.Point(372, 237);
            this.numericUpDown_cebolla.Name = "numericUpDown_cebolla";
            this.numericUpDown_cebolla.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_cebolla.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(259, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Tomate:";
            // 
            // numericUpDown_tomate
            // 
            this.numericUpDown_tomate.Location = new System.Drawing.Point(372, 211);
            this.numericUpDown_tomate.Name = "numericUpDown_tomate";
            this.numericUpDown_tomate.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_tomate.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(259, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Lechuga:";
            // 
            // numericUpDown_lechuga
            // 
            this.numericUpDown_lechuga.Location = new System.Drawing.Point(372, 185);
            this.numericUpDown_lechuga.Name = "numericUpDown_lechuga";
            this.numericUpDown_lechuga.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_lechuga.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(259, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Queso:";
            // 
            // numericUpDown_queso
            // 
            this.numericUpDown_queso.Location = new System.Drawing.Point(372, 159);
            this.numericUpDown_queso.Name = "numericUpDown_queso";
            this.numericUpDown_queso.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_queso.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(259, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Paty de pollo:";
            // 
            // numericUpDown_patypollo
            // 
            this.numericUpDown_patypollo.Location = new System.Drawing.Point(372, 133);
            this.numericUpDown_patypollo.Name = "numericUpDown_patypollo";
            this.numericUpDown_patypollo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_patypollo.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(259, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Paty de carne:";
            // 
            // numericUpDown_patycarne
            // 
            this.numericUpDown_patycarne.Location = new System.Drawing.Point(372, 107);
            this.numericUpDown_patycarne.Name = "numericUpDown_patycarne";
            this.numericUpDown_patycarne.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_patycarne.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(259, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Pan:";
            // 
            // numericUpDown_pan
            // 
            this.numericUpDown_pan.Location = new System.Drawing.Point(372, 81);
            this.numericUpDown_pan.Name = "numericUpDown_pan";
            this.numericUpDown_pan.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_pan.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(259, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 21);
            this.label13.TabIndex = 45;
            this.label13.Text = "Partes de Hamburguesa:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_descripcion1
            // 
            this.textBox_descripcion1.Location = new System.Drawing.Point(3, 103);
            this.textBox_descripcion1.Multiline = true;
            this.textBox_descripcion1.Name = "textBox_descripcion1";
            this.textBox_descripcion1.Size = new System.Drawing.Size(236, 72);
            this.textBox_descripcion1.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Descripcion:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.textBox_descripcion2);
            this.panel2.Controls.Add(this.checkBox_descripcion);
            this.panel2.Controls.Add(this.textBox_nombre2);
            this.panel2.Controls.Add(this.numericUpDown_stock2);
            this.panel2.Controls.Add(this.boton_buscar);
            this.panel2.Controls.Add(this.checkBox_precio);
            this.panel2.Controls.Add(this.numericUpDown_precio2);
            this.panel2.Controls.Add(this.checkBox_stock);
            this.panel2.Controls.Add(this.checkBox_nombre);
            this.panel2.Location = new System.Drawing.Point(522, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 290);
            this.panel2.TabIndex = 28;
            // 
            // textBox_descripcion2
            // 
            this.textBox_descripcion2.Location = new System.Drawing.Point(3, 103);
            this.textBox_descripcion2.Multiline = true;
            this.textBox_descripcion2.Name = "textBox_descripcion2";
            this.textBox_descripcion2.Size = new System.Drawing.Size(268, 102);
            this.textBox_descripcion2.TabIndex = 28;
            // 
            // checkBox_descripcion
            // 
            this.checkBox_descripcion.AutoSize = true;
            this.checkBox_descripcion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_descripcion.ForeColor = System.Drawing.Color.White;
            this.checkBox_descripcion.Location = new System.Drawing.Point(3, 79);
            this.checkBox_descripcion.Name = "checkBox_descripcion";
            this.checkBox_descripcion.Size = new System.Drawing.Size(97, 20);
            this.checkBox_descripcion.TabIndex = 23;
            this.checkBox_descripcion.Text = "Descripcion: ";
            this.checkBox_descripcion.UseVisualStyleBackColor = true;
            // 
            // textBox_nombre2
            // 
            this.textBox_nombre2.Location = new System.Drawing.Point(151, 3);
            this.textBox_nombre2.Name = "textBox_nombre2";
            this.textBox_nombre2.Size = new System.Drawing.Size(120, 20);
            this.textBox_nombre2.TabIndex = 1;
            // 
            // numericUpDown_stock2
            // 
            this.numericUpDown_stock2.Location = new System.Drawing.Point(152, 29);
            this.numericUpDown_stock2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_stock2.Name = "numericUpDown_stock2";
            this.numericUpDown_stock2.Size = new System.Drawing.Size(119, 20);
            this.numericUpDown_stock2.TabIndex = 2;
            // 
            // numericUpDown_precio2
            // 
            this.numericUpDown_precio2.DecimalPlaces = 2;
            this.numericUpDown_precio2.Location = new System.Drawing.Point(152, 55);
            this.numericUpDown_precio2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_precio2.Name = "numericUpDown_precio2";
            this.numericUpDown_precio2.Size = new System.Drawing.Size(119, 20);
            this.numericUpDown_precio2.TabIndex = 4;
            // 
            // dataGridView_hamburguesa
            // 
            this.dataGridView_hamburguesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hamburguesa.Location = new System.Drawing.Point(522, 308);
            this.dataGridView_hamburguesa.Name = "dataGridView_hamburguesa";
            this.dataGridView_hamburguesa.ReadOnly = true;
            this.dataGridView_hamburguesa.RowHeadersVisible = false;
            this.dataGridView_hamburguesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_hamburguesa.Size = new System.Drawing.Size(274, 225);
            this.dataGridView_hamburguesa.TabIndex = 29;
            // 
            // Form_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(808, 545);
            this.Controls.Add(this.dataGridView_hamburguesa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_articulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Articulos";
            this.Text = "Form_Inventario";
            this.VisibleChanged += new System.EventHandler(this.Form_Articulos_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_precio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pepino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cebolla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tomate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lechuga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_queso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_patypollo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_patycarne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_precio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hamburguesa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_nombre1;
        private System.Windows.Forms.NumericUpDown numericUpDown_stock1;
        private System.Windows.Forms.NumericUpDown numericUpDown_precio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_articulos;
        private System.Windows.Forms.CheckBox checkBox_nombre;
        private System.Windows.Forms.CheckBox checkBox_stock;
        private System.Windows.Forms.CheckBox checkBox_precio;
        private FontAwesome.Sharp.IconButton boton_buscar;
        private FontAwesome.Sharp.IconButton boton_agregar;
        private FontAwesome.Sharp.IconButton boton_editar;
        private FontAwesome.Sharp.IconButton boton_borrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_nombre2;
        private System.Windows.Forms.NumericUpDown numericUpDown_stock2;
        private System.Windows.Forms.NumericUpDown numericUpDown_precio2;
        private System.Windows.Forms.TextBox textBox_descripcion1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_descripcion;
        private System.Windows.Forms.TextBox textBox_descripcion2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_pepino;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_cebolla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_tomate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_lechuga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_queso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_patypollo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_patycarne;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_pan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView_hamburguesa;
        private System.Windows.Forms.CheckBox checkBox_es_hamburguesa1;
    }
}