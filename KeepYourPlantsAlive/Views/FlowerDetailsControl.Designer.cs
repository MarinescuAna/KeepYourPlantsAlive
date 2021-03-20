
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
            this.components = new System.ComponentModel.Container();
            this.txtValuesRead = new System.Windows.Forms.TextBox();
            this.btnStartReading = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbFlowerName = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.chkKeyboard = new System.Windows.Forms.CheckBox();
            this.chkArduino = new System.Windows.Forms.CheckBox();
            this.btnWriteValue = new System.Windows.Forms.Button();
            this.txtValuesKeyboard = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.picFlowers = new System.Windows.Forms.PictureBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnGiveWater = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValuesRead
            // 
            this.txtValuesRead.Cursor = System.Windows.Forms.Cursors.No;
            this.txtValuesRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuesRead.Location = new System.Drawing.Point(41, 294);
            this.txtValuesRead.Multiline = true;
            this.txtValuesRead.Name = "txtValuesRead";
            this.txtValuesRead.ReadOnly = true;
            this.txtValuesRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValuesRead.Size = new System.Drawing.Size(198, 288);
            this.txtValuesRead.TabIndex = 1;
            this.txtValuesRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStartReading
            // 
            this.btnStartReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStartReading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartReading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStartReading.Location = new System.Drawing.Point(41, 248);
            this.btnStartReading.Name = "btnStartReading";
            this.btnStartReading.Size = new System.Drawing.Size(198, 31);
            this.btnStartReading.TabIndex = 2;
            this.btnStartReading.Text = "Start Reading";
            this.btnStartReading.UseVisualStyleBackColor = false;
            this.btnStartReading.Click += new System.EventHandler(this.BtnStartRead_Click);
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
            this.cmbPort.Location = new System.Drawing.Point(41, 212);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(158, 30);
            this.cmbPort.TabIndex = 5;
            this.cmbPort.Text = "--Select port--";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(368, 545);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 8;
            // 
            // chkKeyboard
            // 
            this.chkKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkKeyboard.AutoSize = true;
            this.chkKeyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkKeyboard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chkKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkKeyboard.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKeyboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkKeyboard.Location = new System.Drawing.Point(840, 18);
            this.chkKeyboard.Name = "chkKeyboard";
            this.chkKeyboard.Size = new System.Drawing.Size(234, 26);
            this.chkKeyboard.TabIndex = 9;
            this.chkKeyboard.Text = "Read Data From Keyboard";
            this.chkKeyboard.UseVisualStyleBackColor = false;
            this.chkKeyboard.CheckedChanged += new System.EventHandler(this.ChkKeyboard_CheckedChanged);
            // 
            // chkArduino
            // 
            this.chkArduino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkArduino.AutoSize = true;
            this.chkArduino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkArduino.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chkArduino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkArduino.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArduino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkArduino.Location = new System.Drawing.Point(840, 50);
            this.chkArduino.Name = "chkArduino";
            this.chkArduino.Size = new System.Drawing.Size(224, 26);
            this.chkArduino.TabIndex = 10;
            this.chkArduino.Text = "Read Data From Arduino";
            this.chkArduino.UseVisualStyleBackColor = false;
            this.chkArduino.CheckedChanged += new System.EventHandler(this.ChkArduino_CheckedChanged);
            // 
            // btnWriteValue
            // 
            this.btnWriteValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnWriteValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWriteValue.Location = new System.Drawing.Point(41, 248);
            this.btnWriteValue.Name = "btnWriteValue";
            this.btnWriteValue.Size = new System.Drawing.Size(198, 31);
            this.btnWriteValue.TabIndex = 11;
            this.btnWriteValue.Text = "Write value";
            this.btnWriteValue.UseVisualStyleBackColor = false;
            this.btnWriteValue.Click += new System.EventHandler(this.BtnWriteValue_Click);
            // 
            // txtValuesKeyboard
            // 
            this.txtValuesKeyboard.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuesKeyboard.Location = new System.Drawing.Point(41, 178);
            this.txtValuesKeyboard.Name = "txtValuesKeyboard";
            this.txtValuesKeyboard.Size = new System.Drawing.Size(198, 28);
            this.txtValuesKeyboard.TabIndex = 12;
            this.txtValuesKeyboard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValuesKeyboard_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(41, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(198, 31);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // picFlowers
            // 
            this.picFlowers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picFlowers.Location = new System.Drawing.Point(324, 166);
            this.picFlowers.Name = "picFlowers";
            this.picFlowers.Size = new System.Drawing.Size(297, 301);
            this.picFlowers.TabIndex = 15;
            this.picFlowers.TabStop = false;
            // 
            // btnGiveWater
            // 
            this.btnGiveWater.BackColor = System.Drawing.Color.Chartreuse;
            this.btnGiveWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiveWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveWater.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGiveWater.Location = new System.Drawing.Point(41, 626);
            this.btnGiveWater.Name = "btnGiveWater";
            this.btnGiveWater.Size = new System.Drawing.Size(198, 71);
            this.btnGiveWater.TabIndex = 17;
            this.btnGiveWater.Text = "Give Water";
            this.btnGiveWater.UseVisualStyleBackColor = false;
            this.btnGiveWater.Click += new System.EventHandler(this.BtnGiveWater_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(673, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 541);
            this.dataGridView1.TabIndex = 18;
            // 
            // FlowerDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGiveWater);
            this.Controls.Add(this.picFlowers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtValuesKeyboard);
            this.Controls.Add(this.btnWriteValue);
            this.Controls.Add(this.chkArduino);
            this.Controls.Add(this.chkKeyboard);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.lbFlowerName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStartReading);
            this.Controls.Add(this.txtValuesRead);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "FlowerDetailsControl";
            this.Size = new System.Drawing.Size(1096, 808);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValuesRead;
        private System.Windows.Forms.Button btnStartReading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbFlowerName;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.CheckBox chkKeyboard;
        private System.Windows.Forms.CheckBox chkArduino;
        private System.Windows.Forms.Button btnWriteValue;
        private System.Windows.Forms.TextBox txtValuesKeyboard;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picFlowers;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnGiveWater;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
