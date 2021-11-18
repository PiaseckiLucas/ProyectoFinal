namespace Capa_Visual
{
    partial class Form_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ventas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_detallecombos = new System.Windows.Forms.DataGridView();
            this.dataGridView_combos = new System.Windows.Forms.DataGridView();
            this.boton_vender = new FontAwesome.Sharp.IconButton();
            this.dataGridView_ventas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_detalleVentas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detallecombos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_combos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ventas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detalleVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.dataGridView_detallecombos);
            this.panel1.Controls.Add(this.dataGridView_combos);
            this.panel1.Controls.Add(this.boton_vender);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 234);
            this.panel1.TabIndex = 27;
            // 
            // dataGridView_detallecombos
            // 
            this.dataGridView_detallecombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detallecombos.Location = new System.Drawing.Point(212, 6);
            this.dataGridView_detallecombos.Name = "dataGridView_detallecombos";
            this.dataGridView_detallecombos.ReadOnly = true;
            this.dataGridView_detallecombos.RowHeadersVisible = false;
            this.dataGridView_detallecombos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_detallecombos.Size = new System.Drawing.Size(303, 186);
            this.dataGridView_detallecombos.TabIndex = 29;
            // 
            // dataGridView_combos
            // 
            this.dataGridView_combos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_combos.Location = new System.Drawing.Point(3, 6);
            this.dataGridView_combos.Name = "dataGridView_combos";
            this.dataGridView_combos.ReadOnly = true;
            this.dataGridView_combos.RowHeadersVisible = false;
            this.dataGridView_combos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_combos.Size = new System.Drawing.Size(203, 186);
            this.dataGridView_combos.TabIndex = 11;
            this.dataGridView_combos.SelectionChanged += new System.EventHandler(this.dataGridView_combos_SelectionChanged);
            // 
            // boton_vender
            // 
            this.boton_vender.BackColor = System.Drawing.Color.LightSeaGreen;
            this.boton_vender.FlatAppearance.BorderSize = 0;
            this.boton_vender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.boton_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_vender.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_vender.ForeColor = System.Drawing.Color.White;
            this.boton_vender.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.boton_vender.IconColor = System.Drawing.Color.White;
            this.boton_vender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton_vender.IconSize = 28;
            this.boton_vender.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.boton_vender.Location = new System.Drawing.Point(3, 198);
            this.boton_vender.Name = "boton_vender";
            this.boton_vender.Size = new System.Drawing.Size(512, 30);
            this.boton_vender.TabIndex = 23;
            this.boton_vender.Text = "Vender";
            this.boton_vender.UseVisualStyleBackColor = false;
            this.boton_vender.Click += new System.EventHandler(this.boton_vender_Click);
            // 
            // dataGridView_ventas
            // 
            this.dataGridView_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ventas.Location = new System.Drawing.Point(5, 6);
            this.dataGridView_ventas.Name = "dataGridView_ventas";
            this.dataGridView_ventas.ReadOnly = true;
            this.dataGridView_ventas.RowHeadersVisible = false;
            this.dataGridView_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ventas.Size = new System.Drawing.Size(204, 244);
            this.dataGridView_ventas.TabIndex = 28;
            this.dataGridView_ventas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ventas_CellDoubleClick);
            this.dataGridView_ventas.SelectionChanged += new System.EventHandler(this.dataGridView_ventas_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.dataGridView_detalleVentas);
            this.panel2.Controls.Add(this.dataGridView_ventas);
            this.panel2.Location = new System.Drawing.Point(12, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 256);
            this.panel2.TabIndex = 30;
            // 
            // dataGridView_detalleVentas
            // 
            this.dataGridView_detalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detalleVentas.Location = new System.Drawing.Point(215, 6);
            this.dataGridView_detalleVentas.Name = "dataGridView_detalleVentas";
            this.dataGridView_detalleVentas.ReadOnly = true;
            this.dataGridView_detalleVentas.RowHeadersVisible = false;
            this.dataGridView_detalleVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_detalleVentas.Size = new System.Drawing.Size(265, 244);
            this.dataGridView_detalleVentas.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(506, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(806, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Ventas";
            this.Text = "Form_Inventario";
            this.VisibleChanged += new System.EventHandler(this.Form_Ventas_VisibleChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detallecombos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_combos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ventas)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detalleVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_ventas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_detalleVentas;
        private System.Windows.Forms.DataGridView dataGridView_combos;
        private FontAwesome.Sharp.IconButton boton_vender;
        private System.Windows.Forms.DataGridView dataGridView_detallecombos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}