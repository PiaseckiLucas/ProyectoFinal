namespace Capa_Visual
{
    partial class Form_Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.panel_botones = new System.Windows.Forms.Panel();
            this.boton_Ventas = new FontAwesome.Sharp.IconButton();
            this.boton_Combos = new FontAwesome.Sharp.IconButton();
            this.boton_inventario = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_formulario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Boton_minimizar = new FontAwesome.Sharp.IconButton();
            this.boton_salir = new FontAwesome.Sharp.IconButton();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.panel_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_botones
            // 
            this.panel_botones.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_botones.Controls.Add(this.boton_Ventas);
            this.panel_botones.Controls.Add(this.boton_Combos);
            this.panel_botones.Controls.Add(this.boton_inventario);
            this.panel_botones.Controls.Add(this.pictureBox1);
            this.panel_botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_botones.Location = new System.Drawing.Point(0, 31);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(217, 551);
            this.panel_botones.TabIndex = 0;
            // 
            // boton_Ventas
            // 
            this.boton_Ventas.BackColor = System.Drawing.Color.DarkCyan;
            this.boton_Ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.boton_Ventas.FlatAppearance.BorderSize = 0;
            this.boton_Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.boton_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Ventas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Ventas.ForeColor = System.Drawing.Color.White;
            this.boton_Ventas.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.boton_Ventas.IconColor = System.Drawing.Color.White;
            this.boton_Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_Ventas.IconSize = 45;
            this.boton_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_Ventas.Location = new System.Drawing.Point(0, 204);
            this.boton_Ventas.Name = "boton_Ventas";
            this.boton_Ventas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.boton_Ventas.Size = new System.Drawing.Size(217, 53);
            this.boton_Ventas.TabIndex = 4;
            this.boton_Ventas.Text = "Ventas";
            this.boton_Ventas.UseVisualStyleBackColor = false;
            this.boton_Ventas.Click += new System.EventHandler(this.boton_Ventas_Click);
            // 
            // boton_Combos
            // 
            this.boton_Combos.BackColor = System.Drawing.Color.DarkCyan;
            this.boton_Combos.Dock = System.Windows.Forms.DockStyle.Top;
            this.boton_Combos.FlatAppearance.BorderSize = 0;
            this.boton_Combos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.boton_Combos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Combos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Combos.ForeColor = System.Drawing.Color.White;
            this.boton_Combos.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.boton_Combos.IconColor = System.Drawing.Color.White;
            this.boton_Combos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_Combos.IconSize = 45;
            this.boton_Combos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_Combos.Location = new System.Drawing.Point(0, 151);
            this.boton_Combos.Name = "boton_Combos";
            this.boton_Combos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.boton_Combos.Size = new System.Drawing.Size(217, 53);
            this.boton_Combos.TabIndex = 3;
            this.boton_Combos.Text = "Combos";
            this.boton_Combos.UseVisualStyleBackColor = false;
            this.boton_Combos.Click += new System.EventHandler(this.boton_Combos_Click);
            // 
            // boton_inventario
            // 
            this.boton_inventario.BackColor = System.Drawing.Color.DarkCyan;
            this.boton_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.boton_inventario.FlatAppearance.BorderSize = 0;
            this.boton_inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.boton_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_inventario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_inventario.ForeColor = System.Drawing.Color.White;
            this.boton_inventario.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.boton_inventario.IconColor = System.Drawing.Color.White;
            this.boton_inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_inventario.IconSize = 45;
            this.boton_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_inventario.Location = new System.Drawing.Point(0, 98);
            this.boton_inventario.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.boton_inventario.Name = "boton_inventario";
            this.boton_inventario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.boton_inventario.Size = new System.Drawing.Size(217, 53);
            this.boton_inventario.TabIndex = 2;
            this.boton_inventario.Text = "Inventario";
            this.boton_inventario.UseVisualStyleBackColor = false;
            this.boton_inventario.Click += new System.EventHandler(this.boton_inventario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel_formulario
            // 
            this.panel_formulario.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_formulario.Location = new System.Drawing.Point(217, 31);
            this.panel_formulario.Name = "panel_formulario";
            this.panel_formulario.Size = new System.Drawing.Size(823, 551);
            this.panel_formulario.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.Boton_minimizar);
            this.panel1.Controls.Add(this.boton_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 31);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Boton_minimizar
            // 
            this.Boton_minimizar.BackColor = System.Drawing.Color.DarkCyan;
            this.Boton_minimizar.FlatAppearance.BorderSize = 0;
            this.Boton_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Boton_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_minimizar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_minimizar.ForeColor = System.Drawing.Color.White;
            this.Boton_minimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Boton_minimizar.IconColor = System.Drawing.Color.White;
            this.Boton_minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Boton_minimizar.IconSize = 28;
            this.Boton_minimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Boton_minimizar.Location = new System.Drawing.Point(979, 0);
            this.Boton_minimizar.Name = "Boton_minimizar";
            this.Boton_minimizar.Size = new System.Drawing.Size(32, 31);
            this.Boton_minimizar.TabIndex = 25;
            this.Boton_minimizar.UseVisualStyleBackColor = false;
            this.Boton_minimizar.Click += new System.EventHandler(this.Boton_minimizar_Click);
            // 
            // boton_salir
            // 
            this.boton_salir.BackColor = System.Drawing.Color.DarkCyan;
            this.boton_salir.FlatAppearance.BorderSize = 0;
            this.boton_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.boton_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_salir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_salir.ForeColor = System.Drawing.Color.White;
            this.boton_salir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.boton_salir.IconColor = System.Drawing.Color.White;
            this.boton_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_salir.IconSize = 28;
            this.boton_salir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.boton_salir.Location = new System.Drawing.Point(1008, 0);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(32, 31);
            this.boton_salir.TabIndex = 24;
            this.boton_salir.UseVisualStyleBackColor = false;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1040, 582);
            this.Controls.Add(this.panel_formulario);
            this.Controls.Add(this.panel_botones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Menu";
            this.Text = "Form1";
            this.panel_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_botones;
        private FontAwesome.Sharp.IconButton boton_inventario;
        private System.Windows.Forms.Panel panel_formulario;
        private FontAwesome.Sharp.IconButton boton_Combos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton boton_salir;
        private FontAwesome.Sharp.IconButton Boton_minimizar;
        private FontAwesome.Sharp.IconButton boton_Ventas;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
    }
}

