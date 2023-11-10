// Programa Windows Forms

// ARCHIVO DESIGNER.CS
// Archivo generado automaticamente

namespace WindowsForms
{
    partial class FormularioPrincipal { // Clase parcial FormularioPrincipal (Tiene el mismo nombre que el formulario principal)
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null; //  se utiliza para gestionar los componentes que se agregan al formulario, como controles y otros elementos visuales.

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
        private void InitializeComponent() // Metodo que se genera automáticamente y se encarga de inicializar y configurar los controles en el formulario
        {
            this.Label = new System.Windows.Forms.Label();
            this.LabelConDisenio = new System.Windows.Forms.Label();
            this.boton = new System.Windows.Forms.Button();
            this.botonConDisenio = new System.Windows.Forms.Button();
            this.LabelConEnlace = new System.Windows.Forms.LinkLabel();
            this.LabelConEnlaceConDisenio = new System.Windows.Forms.LinkLabel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.checkBoxConDisenio = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCheckBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(143, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "Esto es una Label o Etiqueta";
            this.Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelConDisenio
            // 
            this.LabelConDisenio.AutoSize = true;
            this.LabelConDisenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelConDisenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelConDisenio.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.LabelConDisenio.ForeColor = System.Drawing.Color.Blue;
            this.LabelConDisenio.Location = new System.Drawing.Point(15, 30);
            this.LabelConDisenio.Name = "LabelConDisenio";
            this.LabelConDisenio.Size = new System.Drawing.Size(218, 15);
            this.LabelConDisenio.TabIndex = 1;
            this.LabelConDisenio.Text = "Este es un Label con todas sus propiedades";
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(18, 113);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 2;
            this.boton.Text = "botón";
            this.boton.UseVisualStyleBackColor = true;
            // 
            // botonConDisenio
            // 
            this.botonConDisenio.BackColor = System.Drawing.Color.Green;
            this.botonConDisenio.ForeColor = System.Drawing.Color.PapayaWhip;
            this.botonConDisenio.Location = new System.Drawing.Point(101, 105);
            this.botonConDisenio.Name = "botonConDisenio";
            this.botonConDisenio.Size = new System.Drawing.Size(120, 39);
            this.botonConDisenio.TabIndex = 3;
            this.botonConDisenio.Text = "Botón con diseño";
            this.botonConDisenio.UseVisualStyleBackColor = false;
            this.botonConDisenio.Click += new System.EventHandler(this.botonConDisenio_Click);
            // 
            // LabelConEnlace
            // 
            this.LabelConEnlace.AutoSize = true;
            this.LabelConEnlace.Location = new System.Drawing.Point(13, 53);
            this.LabelConEnlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelConEnlace.Name = "LabelConEnlace";
            this.LabelConEnlace.Size = new System.Drawing.Size(85, 13);
            this.LabelConEnlace.TabIndex = 4;
            this.LabelConEnlace.TabStop = true;
            this.LabelConEnlace.Text = "LabelConEnlace";
            // 
            // LabelConEnlaceConDisenio
            // 
            this.LabelConEnlaceConDisenio.AutoSize = true;
            this.LabelConEnlaceConDisenio.Location = new System.Drawing.Point(13, 76);
            this.LabelConEnlaceConDisenio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelConEnlaceConDisenio.Name = "LabelConEnlaceConDisenio";
            this.LabelConEnlaceConDisenio.Size = new System.Drawing.Size(139, 13);
            this.LabelConEnlaceConDisenio.TabIndex = 5;
            this.LabelConEnlaceConDisenio.TabStop = true;
            this.LabelConEnlaceConDisenio.Text = "LabelConEnlaceConDisenio";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(255, 10);
            this.checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(188, 17);
            this.checkBox.TabIndex = 6;
            this.checkBox.Text = "Checkbox o Casilla de verificacion";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxConDisenio
            // 
            this.checkBoxConDisenio.AutoSize = true;
            this.checkBoxConDisenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxConDisenio.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.checkBoxConDisenio.ForeColor = System.Drawing.Color.Magenta;
            this.checkBoxConDisenio.Location = new System.Drawing.Point(255, 32);
            this.checkBoxConDisenio.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxConDisenio.Name = "checkBoxConDisenio";
            this.checkBoxConDisenio.Size = new System.Drawing.Size(130, 17);
            this.checkBoxConDisenio.TabIndex = 7;
            this.checkBoxConDisenio.Text = "CheckBox con diseño";
            this.checkBoxConDisenio.UseVisualStyleBackColor = false;
            this.checkBoxConDisenio.CheckedChanged += new System.EventHandler(this.checkBoxConDisenio_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Boton de checkbox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCheckBox
            // 
            this.labelCheckBox.AutoSize = true;
            this.labelCheckBox.Location = new System.Drawing.Point(262, 82);
            this.labelCheckBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCheckBox.Name = "labelCheckBox";
            this.labelCheckBox.Size = new System.Drawing.Size(99, 13);
            this.labelCheckBox.TabIndex = 9;
            this.labelCheckBox.Text = "Label de Checkbox";
            // 
            // FormularioPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxConDisenio);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.LabelConEnlaceConDisenio);
            this.Controls.Add(this.LabelConEnlace);
            this.Controls.Add(this.botonConDisenio);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.LabelConDisenio);
            this.Controls.Add(this.Label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormularioPrincipal";
            this.Text = "Titulo de Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label LabelConDisenio;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.Button botonConDisenio;
        private System.Windows.Forms.LinkLabel LabelConEnlace;
        private System.Windows.Forms.LinkLabel LabelConEnlaceConDisenio;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.CheckBox checkBoxConDisenio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCheckBox;
    }
}

