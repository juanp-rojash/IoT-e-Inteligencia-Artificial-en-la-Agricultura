namespace AgroTech
{
    partial class Sensoriado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sensoriado));
            this.comboBoxTipoSensor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.pictureBoxSensorSector = new System.Windows.Forms.PictureBox();
            this.listBoxSugerencia = new System.Windows.Forms.ListBox();
            this.sugerenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSugerencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sugerenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipoSensor
            // 
            this.comboBoxTipoSensor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxTipoSensor.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoSensor.ForeColor = System.Drawing.Color.White;
            this.comboBoxTipoSensor.FormattingEnabled = true;
            this.comboBoxTipoSensor.Location = new System.Drawing.Point(12, 31);
            this.comboBoxTipoSensor.Name = "comboBoxTipoSensor";
            this.comboBoxTipoSensor.Size = new System.Drawing.Size(189, 24);
            this.comboBoxTipoSensor.TabIndex = 0;
            this.comboBoxTipoSensor.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoSensor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sensores";
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewInfo.Location = new System.Drawing.Point(224, 12);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.Size = new System.Drawing.Size(244, 590);
            this.dataGridViewInfo.TabIndex = 2;
            this.dataGridViewInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInfo_CellClick);
            // 
            // pictureBoxSensorSector
            // 
            this.pictureBoxSensorSector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxSensorSector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSensorSector.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSensorSector.Image")));
            this.pictureBoxSensorSector.Location = new System.Drawing.Point(493, 12);
            this.pictureBoxSensorSector.Name = "pictureBoxSensorSector";
            this.pictureBoxSensorSector.Size = new System.Drawing.Size(540, 388);
            this.pictureBoxSensorSector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSensorSector.TabIndex = 3;
            this.pictureBoxSensorSector.TabStop = false;
            // 
            // listBoxSugerencia
            // 
            this.listBoxSugerencia.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxSugerencia.DataSource = this.sugerenciaBindingSource;
            this.listBoxSugerencia.DisplayMember = "TipoSensor";
            this.listBoxSugerencia.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSugerencia.ForeColor = System.Drawing.Color.White;
            this.listBoxSugerencia.FormattingEnabled = true;
            this.listBoxSugerencia.ItemHeight = 16;
            this.listBoxSugerencia.Location = new System.Drawing.Point(493, 438);
            this.listBoxSugerencia.Name = "listBoxSugerencia";
            this.listBoxSugerencia.Size = new System.Drawing.Size(137, 164);
            this.listBoxSugerencia.TabIndex = 4;
            this.listBoxSugerencia.ValueMember = "TipoSensor";
            this.listBoxSugerencia.SelectedIndexChanged += new System.EventHandler(this.listBoxSugerencia_SelectedIndexChanged);
            // 
            // sugerenciaBindingSource
            // 
            this.sugerenciaBindingSource.DataSource = typeof(AgroTech.Clase.Sugerencia);
            // 
            // textBoxSugerencia
            // 
            this.textBoxSugerencia.BackColor = System.Drawing.Color.White;
            this.textBoxSugerencia.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSugerencia.ForeColor = System.Drawing.Color.Black;
            this.textBoxSugerencia.Location = new System.Drawing.Point(636, 406);
            this.textBoxSugerencia.Multiline = true;
            this.textBoxSugerencia.Name = "textBoxSugerencia";
            this.textBoxSugerencia.ReadOnly = true;
            this.textBoxSugerencia.Size = new System.Drawing.Size(397, 196);
            this.textBoxSugerencia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(507, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sugerencias";
            // 
            // timer1
            // 
            this.timer1.Interval = 150000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(12, 565);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(206, 34);
            this.buttonBorrar.TabIndex = 7;
            this.buttonBorrar.Text = "Borrar Sugerencia";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // Sensoriado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSugerencia);
            this.Controls.Add(this.listBoxSugerencia);
            this.Controls.Add(this.pictureBoxSensorSector);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTipoSensor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sensoriado";
            this.Text = "Sensoriado";
            this.Load += new System.EventHandler(this.Sensoriado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sugerenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoSensor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.PictureBox pictureBoxSensorSector;
        private System.Windows.Forms.ListBox listBoxSugerencia;
        private System.Windows.Forms.TextBox textBoxSugerencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sugerenciaBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonBorrar;
    }
}