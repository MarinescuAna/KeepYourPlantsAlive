
namespace KeepYourPlantsAlive.Views
{
    partial class FlowerDetailsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValuesRead = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbFlowerName = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValuesRead
            // 
            this.txtValuesRead.Cursor = System.Windows.Forms.Cursors.No;
            this.txtValuesRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuesRead.Location = new System.Drawing.Point(41, 251);
            this.txtValuesRead.Multiline = true;
            this.txtValuesRead.Name = "txtValuesRead";
            this.txtValuesRead.ReadOnly = true;
            this.txtValuesRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValuesRead.Size = new System.Drawing.Size(198, 288);
            this.txtValuesRead.TabIndex = 1;
            this.txtValuesRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(41, 214);
            this.button1.Name = "btnStartRead";
            this.button1.Size = new System.Drawing.Size(198, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Reading";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnStartRead_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::KeepYourPlantsAlive.Properties.Resources.logo;
            this.pictureBox1.Image = global::KeepYourPlantsAlive.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::KeepYourPlantsAlive.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbFlowerName
            // 
            this.lbFlowerName.AutoSize = true;
            this.lbFlowerName.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlowerName.Location = new System.Drawing.Point(105, 71);
            this.lbFlowerName.Name = "lbFlowerName";
            this.lbFlowerName.Size = new System.Drawing.Size(218, 49);
            this.lbFlowerName.TabIndex = 4;
            this.lbFlowerName.Text = "Flower name";
            // 
            // cmbPort
            // 
            this.cmbPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPort.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(41, 178);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(158, 30);
            this.cmbPort.TabIndex = 5;
            this.cmbPort.Text = "--Select port--";
            // 
            // FlowerDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.lbFlowerName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValuesRead);
            this.Name = "FlowerDetailsControl";
            this.Size = new System.Drawing.Size(1096, 808);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValuesRead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbFlowerName;
        private System.Windows.Forms.ComboBox cmbPort;
    }
}
