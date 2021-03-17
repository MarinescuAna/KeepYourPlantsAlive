
namespace KeepYourPlantsAlive
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFlowers = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAddPlant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackgroundImage = global::KeepYourPlantsAlive.Properties.Resources.backgroundStart;
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1097, 811);
            this.panelMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbFlowers);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnAddPlant);
            this.panel2.Location = new System.Drawing.Point(650, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 254);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a flower";
            // 
            // cmbFlowers
            // 
            this.cmbFlowers.AccessibleName = "";
            this.cmbFlowers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFlowers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFlowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFlowers.FormattingEnabled = true;
            this.cmbFlowers.Location = new System.Drawing.Point(76, 99);
            this.cmbFlowers.Name = "cmbFlowers";
            this.cmbFlowers.Size = new System.Drawing.Size(275, 28);
            this.cmbFlowers.TabIndex = 2;
            this.cmbFlowers.Text = "--Select--";
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.DarkGreen;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnView.Location = new System.Drawing.Point(198, 176);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(177, 61);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Plant";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAddPlant
            // 
            this.btnAddPlant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPlant.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddPlant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPlant.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPlant.Location = new System.Drawing.Point(19, 176);
            this.btnAddPlant.Name = "btnAddPlant";
            this.btnAddPlant.Size = new System.Drawing.Size(173, 61);
            this.btnAddPlant.TabIndex = 0;
            this.btnAddPlant.Text = "Add a new plant";
            this.btnAddPlant.UseVisualStyleBackColor = false;
            this.btnAddPlant.Click += new System.EventHandler(this.btnAddPlant_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(355, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 97);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keep Your Plants Alive ";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 808);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "KeepYourPlantsAlive";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFlowers;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAddPlant;
        private System.Windows.Forms.Label label1;
    }
}

