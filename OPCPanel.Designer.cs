namespace rspo_2023
{
    partial class OPCPanel
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
            this.groupBoxDevice = new System.Windows.Forms.GroupBox();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.labelRandom = new System.Windows.Forms.Label();
            this.textBoxSine = new System.Windows.Forms.TextBox();
            this.labelSine = new System.Windows.Forms.Label();
            this.textBoxRamp = new System.Windows.Forms.TextBox();
            this.labelRamp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.groupBoxDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDevice
            // 
            this.groupBoxDevice.Controls.Add(this.textBox1);
            this.groupBoxDevice.Controls.Add(this.labelText);
            this.groupBoxDevice.Controls.Add(this.textBoxRandom);
            this.groupBoxDevice.Controls.Add(this.labelRandom);
            this.groupBoxDevice.Controls.Add(this.textBoxSine);
            this.groupBoxDevice.Controls.Add(this.labelSine);
            this.groupBoxDevice.Controls.Add(this.textBoxRamp);
            this.groupBoxDevice.Controls.Add(this.labelRamp);
            this.groupBoxDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDevice.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDevice.Name = "groupBoxDevice";
            this.groupBoxDevice.Size = new System.Drawing.Size(158, 254);
            this.groupBoxDevice.TabIndex = 1;
            this.groupBoxDevice.TabStop = false;
            this.groupBoxDevice.Text = "Device";
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Location = new System.Drawing.Point(29, 158);
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.Size = new System.Drawing.Size(100, 26);
            this.textBoxRandom.TabIndex = 5;
            this.textBoxRandom.Text = "0.00";
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRandom.Location = new System.Drawing.Point(29, 135);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(76, 20);
            this.labelRandom.TabIndex = 4;
            this.labelRandom.Text = "Random";
            // 
            // textBoxSine
            // 
            this.textBoxSine.Location = new System.Drawing.Point(29, 106);
            this.textBoxSine.Name = "textBoxSine";
            this.textBoxSine.Size = new System.Drawing.Size(100, 26);
            this.textBoxSine.TabIndex = 3;
            this.textBoxSine.Text = "0.00";
            // 
            // labelSine
            // 
            this.labelSine.AutoSize = true;
            this.labelSine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSine.Location = new System.Drawing.Point(29, 83);
            this.labelSine.Name = "labelSine";
            this.labelSine.Size = new System.Drawing.Size(45, 20);
            this.labelSine.TabIndex = 2;
            this.labelSine.Text = "Sine";
            // 
            // textBoxRamp
            // 
            this.textBoxRamp.Location = new System.Drawing.Point(29, 54);
            this.textBoxRamp.Name = "textBoxRamp";
            this.textBoxRamp.Size = new System.Drawing.Size(100, 26);
            this.textBoxRamp.TabIndex = 1;
            this.textBoxRamp.Text = "0.00";
            // 
            // labelRamp
            // 
            this.labelRamp.AutoSize = true;
            this.labelRamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRamp.Location = new System.Drawing.Point(29, 31);
            this.labelRamp.Name = "labelRamp";
            this.labelRamp.Size = new System.Drawing.Size(56, 20);
            this.labelRamp.TabIndex = 0;
            this.labelRamp.Text = "Ramp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 7;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.ForeColor = System.Drawing.Color.Green;
            this.labelText.Location = new System.Drawing.Point(29, 189);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(43, 20);
            this.labelText.TabIndex = 6;
            this.labelText.Text = "Text";
            // 
            // OPCPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDevice);
            this.Name = "OPCPanel";
            this.Size = new System.Drawing.Size(164, 261);
            this.groupBoxDevice.ResumeLayout(false);
            this.groupBoxDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDevice;
        private System.Windows.Forms.TextBox textBoxRandom;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.TextBox textBoxSine;
        private System.Windows.Forms.Label labelSine;
        private System.Windows.Forms.TextBox textBoxRamp;
        private System.Windows.Forms.Label labelRamp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelText;
    }
}
