
namespace KeepYourPlantsAlive.Views
{
    partial class AddFlowerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFlowerName = new System.Windows.Forms.TextBox();
            this.btnSaveFlower = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSaveFlower);
            this.panel1.Controls.Add(this.txtFlowerName);
            this.panel1.Location = new System.Drawing.Point(557, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 198);
            this.panel1.TabIndex = 0;
            // 
            // txtFlowerName
            // 
            this.txtFlowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlowerName.Location = new System.Drawing.Point(37, 77);
            this.txtFlowerName.Name = "txtFlowerName";
            this.txtFlowerName.Size = new System.Drawing.Size(222, 29);
            this.txtFlowerName.TabIndex = 0;
            // 
            // btnSaveFlower
            // 
            this.btnSaveFlower.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSaveFlower.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFlower.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveFlower.Location = new System.Drawing.Point(98, 134);
            this.btnSaveFlower.Name = "btnSaveFlower";
            this.btnSaveFlower.Size = new System.Drawing.Size(108, 36);
            this.btnSaveFlower.TabIndex = 1;
            this.btnSaveFlower.Text = "Save";
            this.btnSaveFlower.UseVisualStyleBackColor = false;
            this.btnSaveFlower.Click += new System.EventHandler(this.btnSaveFlower_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flower name";
            // 
            // AddFlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KeepYourPlantsAlive.Properties.Resources.backgroundStart;
            this.ClientSize = new System.Drawing.Size(949, 552);
            this.Controls.Add(this.panel1);
            this.Name = "AddFlowerForm";
            this.Text = "AddFlowerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveFlower;
        private System.Windows.Forms.TextBox txtFlowerName;
    }
}