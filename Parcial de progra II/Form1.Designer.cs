
namespace Parcial_de_progra_II
{
    partial class Form1
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
            this.btnSalirParcial = new System.Windows.Forms.Button();
            this.lblTituloParcial = new System.Windows.Forms.Label();
            this.txtcantidadconversores = new System.Windows.Forms.TextBox();
            this.lblcantidadconveroresParcial = new System.Windows.Forms.Label();
            this.lblrespuestasconversores = new System.Windows.Forms.Label();
            this.cboaconversoresParcial = new System.Windows.Forms.ComboBox();
            this.lblaconversores = new System.Windows.Forms.Label();
            this.cbodeconversoresParcial = new System.Windows.Forms.ComboBox();
            this.lbldeconversor = new System.Windows.Forms.Label();
            this.btnconvertirconversoresParcial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalirParcial
            // 
            this.btnSalirParcial.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalirParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirParcial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalirParcial.Location = new System.Drawing.Point(345, 205);
            this.btnSalirParcial.Name = "btnSalirParcial";
            this.btnSalirParcial.Size = new System.Drawing.Size(206, 59);
            this.btnSalirParcial.TabIndex = 19;
            this.btnSalirParcial.Text = "Salir";
            this.btnSalirParcial.UseVisualStyleBackColor = false;
            this.btnSalirParcial.Click += new System.EventHandler(this.btnSalirParcial_Click);
            // 
            // lblTituloParcial
            // 
            this.lblTituloParcial.AutoSize = true;
            this.lblTituloParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloParcial.Location = new System.Drawing.Point(46, 18);
            this.lblTituloParcial.Name = "lblTituloParcial";
            this.lblTituloParcial.Size = new System.Drawing.Size(276, 33);
            this.lblTituloParcial.TabIndex = 18;
            this.lblTituloParcial.Text = "Conversor de Área";
            this.lblTituloParcial.Click += new System.EventHandler(this.lblTituloParcial_Click);
            // 
            // txtcantidadconversores
            // 
            this.txtcantidadconversores.Location = new System.Drawing.Point(498, 74);
            this.txtcantidadconversores.Multiline = true;
            this.txtcantidadconversores.Name = "txtcantidadconversores";
            this.txtcantidadconversores.Size = new System.Drawing.Size(290, 34);
            this.txtcantidadconversores.TabIndex = 17;
            this.txtcantidadconversores.TextChanged += new System.EventHandler(this.txtcantidadconversores_TextChanged);
            // 
            // lblcantidadconveroresParcial
            // 
            this.lblcantidadconveroresParcial.AutoSize = true;
            this.lblcantidadconveroresParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadconveroresParcial.Location = new System.Drawing.Point(554, 26);
            this.lblcantidadconveroresParcial.Name = "lblcantidadconveroresParcial";
            this.lblcantidadconveroresParcial.Size = new System.Drawing.Size(113, 25);
            this.lblcantidadconveroresParcial.TabIndex = 16;
            this.lblcantidadconveroresParcial.Text = "Cantidad:";
            this.lblcantidadconveroresParcial.Click += new System.EventHandler(this.lblcantidadconveroresParcial_Click);
            // 
            // lblrespuestasconversores
            // 
            this.lblrespuestasconversores.AutoSize = true;
            this.lblrespuestasconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuestasconversores.Location = new System.Drawing.Point(97, 315);
            this.lblrespuestasconversores.Name = "lblrespuestasconversores";
            this.lblrespuestasconversores.Size = new System.Drawing.Size(138, 25);
            this.lblrespuestasconversores.TabIndex = 15;
            this.lblrespuestasconversores.Text = "Respuesta: ";
            this.lblrespuestasconversores.Click += new System.EventHandler(this.lblrespuestasconversores_Click);
            // 
            // cboaconversoresParcial
            // 
            this.cboaconversoresParcial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaconversoresParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboaconversoresParcial.FormattingEnabled = true;
            this.cboaconversoresParcial.Items.AddRange(new object[] {
            "Metro Cuadrado",
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada ",
            "Tarea",
            "Manzana",
            "Hectárea"});
            this.cboaconversoresParcial.Location = new System.Drawing.Point(77, 126);
            this.cboaconversoresParcial.Name = "cboaconversoresParcial";
            this.cboaconversoresParcial.Size = new System.Drawing.Size(306, 33);
            this.cboaconversoresParcial.TabIndex = 14;
            this.cboaconversoresParcial.SelectedIndexChanged += new System.EventHandler(this.cboaconversoresParcial_SelectedIndexChanged);
            // 
            // lblaconversores
            // 
            this.lblaconversores.AutoSize = true;
            this.lblaconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaconversores.Location = new System.Drawing.Point(23, 134);
            this.lblaconversores.Name = "lblaconversores";
            this.lblaconversores.Size = new System.Drawing.Size(34, 25);
            this.lblaconversores.TabIndex = 13;
            this.lblaconversores.Text = "A:";
            this.lblaconversores.Click += new System.EventHandler(this.lblaconversores_Click);
            // 
            // cbodeconversoresParcial
            // 
            this.cbodeconversoresParcial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodeconversoresParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodeconversoresParcial.FormattingEnabled = true;
            this.cbodeconversoresParcial.Items.AddRange(new object[] {
            "Metro Cuadrado",
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada ",
            "Tarea",
            "Manzana",
            "Hectárea"});
            this.cbodeconversoresParcial.Location = new System.Drawing.Point(77, 71);
            this.cbodeconversoresParcial.Name = "cbodeconversoresParcial";
            this.cbodeconversoresParcial.Size = new System.Drawing.Size(292, 33);
            this.cbodeconversoresParcial.TabIndex = 12;
            this.cbodeconversoresParcial.SelectedIndexChanged += new System.EventHandler(this.cbodeconversoresParcial_SelectedIndexChanged);
            // 
            // lbldeconversor
            // 
            this.lbldeconversor.AutoSize = true;
            this.lbldeconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeconversor.Location = new System.Drawing.Point(23, 74);
            this.lbldeconversor.Name = "lbldeconversor";
            this.lbldeconversor.Size = new System.Drawing.Size(48, 25);
            this.lbldeconversor.TabIndex = 11;
            this.lbldeconversor.Text = "De:";
            this.lbldeconversor.Click += new System.EventHandler(this.lbldeconversor_Click);
            // 
            // btnconvertirconversoresParcial
            // 
            this.btnconvertirconversoresParcial.BackColor = System.Drawing.Color.Aquamarine;
            this.btnconvertirconversoresParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertirconversoresParcial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnconvertirconversoresParcial.Location = new System.Drawing.Point(77, 212);
            this.btnconvertirconversoresParcial.Name = "btnconvertirconversoresParcial";
            this.btnconvertirconversoresParcial.Size = new System.Drawing.Size(170, 41);
            this.btnconvertirconversoresParcial.TabIndex = 10;
            this.btnconvertirconversoresParcial.Text = "Convertir";
            this.btnconvertirconversoresParcial.UseVisualStyleBackColor = false;
            this.btnconvertirconversoresParcial.Click += new System.EventHandler(this.btnconvertirconversoresParcial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirParcial);
            this.Controls.Add(this.lblTituloParcial);
            this.Controls.Add(this.txtcantidadconversores);
            this.Controls.Add(this.lblcantidadconveroresParcial);
            this.Controls.Add(this.lblrespuestasconversores);
            this.Controls.Add(this.cboaconversoresParcial);
            this.Controls.Add(this.lblaconversores);
            this.Controls.Add(this.cbodeconversoresParcial);
            this.Controls.Add(this.lbldeconversor);
            this.Controls.Add(this.btnconvertirconversoresParcial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirParcial;
        private System.Windows.Forms.Label lblTituloParcial;
        private System.Windows.Forms.TextBox txtcantidadconversores;
        private System.Windows.Forms.Label lblcantidadconveroresParcial;
        private System.Windows.Forms.Label lblrespuestasconversores;
        private System.Windows.Forms.ComboBox cboaconversoresParcial;
        private System.Windows.Forms.Label lblaconversores;
        private System.Windows.Forms.ComboBox cbodeconversoresParcial;
        private System.Windows.Forms.Label lbldeconversor;
        private System.Windows.Forms.Button btnconvertirconversoresParcial;
    }
}

