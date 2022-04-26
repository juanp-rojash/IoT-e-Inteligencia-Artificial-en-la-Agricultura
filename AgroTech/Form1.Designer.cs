namespace AgroTech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSensoriado = new System.Windows.Forms.Button();
            this.buttonDron = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMenu.Controls.Add(this.buttonDron);
            this.panelMenu.Controls.Add(this.buttonSensoriado);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 611);
            this.panelMenu.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Teal;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1064, 611);
            this.panelContenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSensoriado
            // 
            this.buttonSensoriado.FlatAppearance.BorderSize = 0;
            this.buttonSensoriado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonSensoriado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSensoriado.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSensoriado.ForeColor = System.Drawing.Color.White;
            this.buttonSensoriado.Image = ((System.Drawing.Image)(resources.GetObject("buttonSensoriado.Image")));
            this.buttonSensoriado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSensoriado.Location = new System.Drawing.Point(3, 120);
            this.buttonSensoriado.Name = "buttonSensoriado";
            this.buttonSensoriado.Size = new System.Drawing.Size(214, 33);
            this.buttonSensoriado.TabIndex = 0;
            this.buttonSensoriado.Text = "Sensoriado";
            this.buttonSensoriado.UseVisualStyleBackColor = true;
            this.buttonSensoriado.Click += new System.EventHandler(this.buttonSensoriado_Click);
            // 
            // buttonDron
            // 
            this.buttonDron.FlatAppearance.BorderSize = 0;
            this.buttonDron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonDron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDron.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDron.ForeColor = System.Drawing.Color.White;
            this.buttonDron.Image = ((System.Drawing.Image)(resources.GetObject("buttonDron.Image")));
            this.buttonDron.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDron.Location = new System.Drawing.Point(3, 179);
            this.buttonDron.Name = "buttonDron";
            this.buttonDron.Size = new System.Drawing.Size(214, 33);
            this.buttonDron.TabIndex = 1;
            this.buttonDron.Text = "Dron Sense";
            this.buttonDron.UseVisualStyleBackColor = true;
            this.buttonDron.Click += new System.EventHandler(this.buttonDron_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonDron;
        private System.Windows.Forms.Button buttonSensoriado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

