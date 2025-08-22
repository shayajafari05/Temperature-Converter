namespace Temperature_Converter
{
    partial class frmTemperature
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
            this.vsbTemp = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTempF = new System.Windows.Forms.Label();
            this.lblTempC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btmExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vsbTemp
            // 
            this.vsbTemp.Location = new System.Drawing.Point(320, 116);
            this.vsbTemp.Minimum = -60;
            this.vsbTemp.Name = "vsbTemp";
            this.vsbTemp.Size = new System.Drawing.Size(167, 500);
            this.vsbTemp.TabIndex = 0;
            this.vsbTemp.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbTemp_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Celsius";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempF
            // 
            this.lblTempF.BackColor = System.Drawing.Color.White;
            this.lblTempF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempF.Location = new System.Drawing.Point(91, 220);
            this.lblTempF.Name = "lblTempF";
            this.lblTempF.Size = new System.Drawing.Size(192, 65);
            this.lblTempF.TabIndex = 3;
            this.lblTempF.Text = "32";
            this.lblTempF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempC
            // 
            this.lblTempC.BackColor = System.Drawing.Color.White;
            this.lblTempC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempC.Location = new System.Drawing.Point(523, 220);
            this.lblTempC.Name = "lblTempC";
            this.lblTempC.Size = new System.Drawing.Size(194, 65);
            this.lblTempC.TabIndex = 4;
            this.lblTempC.Text = "0";
            this.lblTempC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fahrenheit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(110, 633);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(206, 125);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btmExit
            // 
            this.btmExit.BackColor = System.Drawing.Color.Red;
            this.btmExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmExit.Location = new System.Drawing.Point(500, 633);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(198, 125);
            this.btmExit.TabIndex = 7;
            this.btmExit.Text = "Exit";
            this.btmExit.UseVisualStyleBackColor = false;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // frmTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 783);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTempC);
            this.Controls.Add(this.lblTempF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vsbTemp);
            this.Name = "frmTemperature";
            this.Text = "Temperature Conversion";
            this.Load += new System.EventHandler(this.frmTemperature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vsbTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTempF;
        private System.Windows.Forms.Label lblTempC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btmExit;
    }
}

