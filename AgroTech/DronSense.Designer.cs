namespace AgroTech
{
    partial class DronSense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DronSense));
            this.listBoxHallazgo = new System.Windows.Forms.ListBox();
            this.hallazgoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFresa = new System.Windows.Forms.PictureBox();
            this.pictureBoxDronSector = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hallazgoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDronSector)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxHallazgo
            // 
            this.listBoxHallazgo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxHallazgo.DataSource = this.hallazgoBindingSource;
            this.listBoxHallazgo.DisplayMember = "Url";
            this.listBoxHallazgo.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHallazgo.ForeColor = System.Drawing.Color.White;
            this.listBoxHallazgo.FormattingEnabled = true;
            this.listBoxHallazgo.ItemHeight = 16;
            this.listBoxHallazgo.Location = new System.Drawing.Point(12, 54);
            this.listBoxHallazgo.Name = "listBoxHallazgo";
            this.listBoxHallazgo.Size = new System.Drawing.Size(450, 116);
            this.listBoxHallazgo.TabIndex = 0;
            this.listBoxHallazgo.ValueMember = "Url";
            this.listBoxHallazgo.SelectedIndexChanged += new System.EventHandler(this.listBoxHallazgo_SelectedIndexChanged);
            // 
            // hallazgoBindingSource
            // 
            this.hallazgoBindingSource.DataSource = typeof(AgroTech.Clase.Hallazgo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hallazgos";
            // 
            // pictureBoxFresa
            // 
            this.pictureBoxFresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxFresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFresa.Location = new System.Drawing.Point(12, 194);
            this.pictureBoxFresa.Name = "pictureBoxFresa";
            this.pictureBoxFresa.Size = new System.Drawing.Size(450, 388);
            this.pictureBoxFresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFresa.TabIndex = 2;
            this.pictureBoxFresa.TabStop = false;
            // 
            // pictureBoxDronSector
            // 
            this.pictureBoxDronSector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxDronSector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxDronSector.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDronSector.Image")));
            this.pictureBoxDronSector.Location = new System.Drawing.Point(484, 54);
            this.pictureBoxDronSector.Name = "pictureBoxDronSector";
            this.pictureBoxDronSector.Size = new System.Drawing.Size(556, 528);
            this.pictureBoxDronSector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDronSector.TabIndex = 3;
            this.pictureBoxDronSector.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // DronSense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.pictureBoxDronSector);
            this.Controls.Add(this.pictureBoxFresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxHallazgo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DronSense";
            this.Text = "DronSense";
            ((System.ComponentModel.ISupportInitialize)(this.hallazgoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDronSector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHallazgo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxFresa;
        private System.Windows.Forms.PictureBox pictureBoxDronSector;
        private System.Windows.Forms.BindingSource hallazgoBindingSource;
        private System.Windows.Forms.Timer timer2;
    }
}