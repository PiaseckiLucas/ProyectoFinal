namespace Capa_Visual
{
    partial class Form_Combos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_combos = new System.Windows.Forms.DataGridView();
            this.boton_agregar = new FontAwesome.Sharp.IconButton();
            this.boton_editar = new FontAwesome.Sharp.IconButton();
            this.boton_borrar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_articulos = new System.Windows.Forms.DataGridView();
            this.textBox_descripcion1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_detallecombos = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown_cantidad = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_descripcion2 = new System.Windows.Forms.TextBox();
            this.checkBox_descripcion = new System.Windows.Forms.CheckBox();
            this.textBox_nombre2 = new System.Windows.Forms.TextBox();
            this.boton_buscar = new FontAwesome.Sharp.IconButton();
            this.checkBox_nombre = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_combos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detallecombos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cantidad)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_nombre1
            // 
            this.textbox_nombre1.Location = new System.Drawing.Point(119, 6);
            this.textbox_nombre1.Name = "textbox_nombre1";
            this.textbox_nombre1.Size = new System.Drawing.Size(120, 20);
            this.textbox_nombre1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre: ";
            // 
            // dataGridView_combos
            // 
            this.dataGridView_combos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_combos.Location = new System.Drawing.Point(246, 6);
            this.dataGridView_combos.Name = "dataGridView_combos";
            this.dataGridView_combos.ReadOnly = true;
            this.dataGridView_combos.RowHeadersVisible = false;
            this.dataGridView_combos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_combos.Size = new System.Drawing.Size(204, 206);
            this.dataGridView_combos.TabIndex = 11;
            this.dataGridView_combos.SelectionChanged += new System.EventHandler(this.dataGridView_combos_SelectionChanged);
            // 
            // boton_agregar
            // 
            this.boton_agregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.boton_agregar.FlatAppearance.BorderSize = 0;
            this.boton_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.boton_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_agregar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_agregar.ForeColor = System.Drawing.Color.White;
            this.boton_agregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.boton_agregar.IconColor = System.Drawing.Color.White;
            this.boton_agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_agregar.IconSize = 28;
            this.boton_agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.boton_agregar.Location = new System.Drawing.Point(6, 126);
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
            this.boton_editar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_editar.ForeColor = System.Drawing.Color.White;
            this.boton_editar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.boton_editar.IconColor = System.Drawing.Color.White;
            this.boton_editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_editar.IconSize = 30;
            this.boton_editar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.boton_editar.Location = new System.Drawing.Point(6, 162);
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
            this.boton_borrar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_borrar.ForeColor = System.Drawing.Color.White;
            this.boton_borrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.boton_borrar.IconColor = System.Drawing.Color.White;
            this.boton_borrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_borrar.IconSize = 28;
            this.boton_borrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.boton_borrar.Location = new System.Drawing.Point(6, 198);
            this.boton_borrar.Name = "boton_borrar";
            this.boton_borrar.Size = new System.Drawing.Size(238, 30);
            this.boton_borrar.TabIndex = 25;
            this.boton_borrar.Text = "Borrar";
            this.boton_borrar.UseVisualStyleBackColor = false;
            this.boton_borrar.Click += new System.EventHandler(this.boton_borrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.dataGridView_articulos);
            this.panel1.Controls.Add(this.textBox_descripcion1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textbox_nombre1);
            this.panel1.Controls.Add(this.boton_borrar);
            this.panel1.Controls.Add(this.boton_editar);
            this.panel1.Controls.Add(this.boton_agregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 234);
            this.panel1.TabIndex = 27;
            // 
            // dataGridView_articulos
            // 
            this.dataGridView_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_articulos.Location = new System.Drawing.Point(260, 3);
            this.dataGridView_articulos.Name = "dataGridView_articulos";
            this.dataGridView_articulos.ReadOnly = true;
            this.dataGridView_articulos.RowHeadersVisible = false;
            this.dataGridView_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_articulos.Size = new System.Drawing.Size(503, 225);
            this.dataGridView_articulos.TabIndex = 29;
            // 
            // textBox_descripcion1
            // 
            this.textBox_descripcion1.Location = new System.Drawing.Point(6, 48);
            this.textBox_descripcion1.Multiline = true;
            this.textBox_descripcion1.Name = "textBox_descripcion1";
            this.textBox_descripcion1.Size = new System.Drawing.Size(236, 72);
            this.textBox_descripcion1.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Descripcion:";
            // 
            // dataGridView_detallecombos
            // 
            this.dataGridView_detallecombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detallecombos.Location = new System.Drawing.Point(452, 6);
            this.dataGridView_detallecombos.Name = "dataGridView_detallecombos";
            this.dataGridView_detallecombos.ReadOnly = true;
            this.dataGridView_detallecombos.RowHeadersVisible = false;
            this.dataGridView_detallecombos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_detallecombos.Size = new System.Drawing.Size(311, 206);
            this.dataGridView_detallecombos.TabIndex = 28;
            this.dataGridView_detallecombos.SelectionChanged += new System.EventHandler(this.dataGridView_detallecombos_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(567, 506);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "Cantidad:";
            // 
            // numericUpDown_cantidad
            // 
            this.numericUpDown_cantidad.Location = new System.Drawing.Point(633, 502);
            this.numericUpDown_cantidad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_cantidad.Name = "numericUpDown_cantidad";
            this.numericUpDown_cantidad.Size = new System.Drawing.Size(148, 20);
            this.numericUpDown_cantidad.TabIndex = 48;
            this.numericUpDown_cantidad.ValueChanged += new System.EventHandler(this.numericUpDown_cantidad_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.textBox_descripcion2);
            this.panel2.Controls.Add(this.checkBox_descripcion);
            this.panel2.Controls.Add(this.dataGridView_detallecombos);
            this.panel2.Controls.Add(this.textBox_nombre2);
            this.panel2.Controls.Add(this.dataGridView_combos);
            this.panel2.Controls.Add(this.boton_buscar);
            this.panel2.Controls.Add(this.checkBox_nombre);
            this.panel2.Location = new System.Drawing.Point(12, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 227);
            this.panel2.TabIndex = 30;
            // 
            // textBox_descripcion2
            // 
            this.textBox_descripcion2.Location = new System.Drawing.Point(6, 60);
            this.textBox_descripcion2.Multiline = true;
            this.textBox_descripcion2.Name = "textBox_descripcion2";
            this.textBox_descripcion2.Size = new System.Drawing.Size(233, 72);
            this.textBox_descripcion2.TabIndex = 28;
            // 
            // checkBox_descripcion
            // 
            this.checkBox_descripcion.AutoSize = true;
            this.checkBox_descripcion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_descripcion.ForeColor = System.Drawing.Color.White;
            this.checkBox_descripcion.Location = new System.Drawing.Point(6, 36);
            this.checkBox_descripcion.Name = "checkBox_descripcion";
            this.checkBox_descripcion.Size = new System.Drawing.Size(97, 20);
            this.checkBox_descripcion.TabIndex = 23;
            this.checkBox_descripcion.Text = "Descripcion: ";
            this.checkBox_descripcion.UseVisualStyleBackColor = true;
            // 
            // textBox_nombre2
            // 
            this.textBox_nombre2.Location = new System.Drawing.Point(119, 11);
            this.textBox_nombre2.Name = "textBox_nombre2";
            this.textBox_nombre2.Size = new System.Drawing.Size(120, 20);
            this.textBox_nombre2.TabIndex = 1;
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
            this.boton_buscar.Location = new System.Drawing.Point(9, 168);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(233, 44);
            this.boton_buscar.TabIndex = 22;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = false;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // checkBox_nombre
            // 
            this.checkBox_nombre.AutoSize = true;
            this.checkBox_nombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_nombre.ForeColor = System.Drawing.Color.White;
            this.checkBox_nombre.Location = new System.Drawing.Point(6, 10);
            this.checkBox_nombre.Name = "checkBox_nombre";
            this.checkBox_nombre.Size = new System.Drawing.Size(75, 20);
            this.checkBox_nombre.TabIndex = 17;
            this.checkBox_nombre.Text = "Nombre: ";
            this.checkBox_nombre.UseVisualStyleBackColor = true;
            // 
            // Form_Combos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(806, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDown_cantidad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Combos";
            this.Text = "Form_Inventario";
            this.VisibleChanged += new System.EventHandler(this.Form_Combos_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_combos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detallecombos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_nombre1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_combos;
        private FontAwesome.Sharp.IconButton boton_agregar;
        private FontAwesome.Sharp.IconButton boton_editar;
        private FontAwesome.Sharp.IconButton boton_borrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_descripcion1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_detallecombos;
        private System.Windows.Forms.DataGridView dataGridView_articulos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_cantidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_descripcion2;
        private System.Windows.Forms.CheckBox checkBox_descripcion;
        private System.Windows.Forms.TextBox textBox_nombre2;
        private FontAwesome.Sharp.IconButton boton_buscar;
        private System.Windows.Forms.CheckBox checkBox_nombre;
    }
}