namespace rspo_2023
{
    partial class FormSettings
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCacnel = new System.Windows.Forms.Button();
            this.labelMachineName = new System.Windows.Forms.Label();
            this.textBoxMachineName = new System.Windows.Forms.TextBox();
            this.textBoxUpdateRate = new System.Windows.Forms.TextBox();
            this.labelUpdateRate = new System.Windows.Forms.Label();
            this.textBoxServerClass = new System.Windows.Forms.TextBox();
            this.labelServerClass = new System.Windows.Forms.Label();
            this.listBoxOPCTags = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(156, 270);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 32);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCacnel
            // 
            this.buttonCacnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCacnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCacnel.Location = new System.Drawing.Point(262, 270);
            this.buttonCacnel.Name = "buttonCacnel";
            this.buttonCacnel.Size = new System.Drawing.Size(100, 32);
            this.buttonCacnel.TabIndex = 6;
            this.buttonCacnel.Text = "CANCEL";
            this.buttonCacnel.UseVisualStyleBackColor = true;
            this.buttonCacnel.Click += new System.EventHandler(this.buttonCacnel_Click);
            // 
            // labelMachineName
            // 
            this.labelMachineName.AutoSize = true;
            this.labelMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMachineName.Location = new System.Drawing.Point(12, 9);
            this.labelMachineName.Name = "labelMachineName";
            this.labelMachineName.Size = new System.Drawing.Size(115, 20);
            this.labelMachineName.TabIndex = 7;
            this.labelMachineName.Text = "Machine Name";
            // 
            // textBoxMachineName
            // 
            this.textBoxMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMachineName.Location = new System.Drawing.Point(16, 32);
            this.textBoxMachineName.Name = "textBoxMachineName";
            this.textBoxMachineName.Size = new System.Drawing.Size(240, 26);
            this.textBoxMachineName.TabIndex = 8;
            // 
            // textBoxUpdateRate
            // 
            this.textBoxUpdateRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUpdateRate.Location = new System.Drawing.Point(262, 32);
            this.textBoxUpdateRate.Name = "textBoxUpdateRate";
            this.textBoxUpdateRate.Size = new System.Drawing.Size(100, 26);
            this.textBoxUpdateRate.TabIndex = 10;
            // 
            // labelUpdateRate
            // 
            this.labelUpdateRate.AutoSize = true;
            this.labelUpdateRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUpdateRate.Location = new System.Drawing.Point(258, 9);
            this.labelUpdateRate.Name = "labelUpdateRate";
            this.labelUpdateRate.Size = new System.Drawing.Size(101, 20);
            this.labelUpdateRate.TabIndex = 9;
            this.labelUpdateRate.Text = "Update Rate";
            // 
            // textBoxServerClass
            // 
            this.textBoxServerClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxServerClass.Location = new System.Drawing.Point(16, 84);
            this.textBoxServerClass.Name = "textBoxServerClass";
            this.textBoxServerClass.Size = new System.Drawing.Size(346, 26);
            this.textBoxServerClass.TabIndex = 12;
            // 
            // labelServerClass
            // 
            this.labelServerClass.AutoSize = true;
            this.labelServerClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelServerClass.Location = new System.Drawing.Point(12, 61);
            this.labelServerClass.Name = "labelServerClass";
            this.labelServerClass.Size = new System.Drawing.Size(98, 20);
            this.labelServerClass.TabIndex = 11;
            this.labelServerClass.Text = "Server Class";
            // 
            // listBoxOPCTags
            // 
            this.listBoxOPCTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOPCTags.FormattingEnabled = true;
            this.listBoxOPCTags.ItemHeight = 20;
            this.listBoxOPCTags.Location = new System.Drawing.Point(16, 116);
            this.listBoxOPCTags.Name = "listBoxOPCTags";
            this.listBoxOPCTags.Size = new System.Drawing.Size(346, 124);
            this.listBoxOPCTags.TabIndex = 13;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 314);
            this.Controls.Add(this.listBoxOPCTags);
            this.Controls.Add(this.textBoxServerClass);
            this.Controls.Add(this.labelServerClass);
            this.Controls.Add(this.textBoxUpdateRate);
            this.Controls.Add(this.labelUpdateRate);
            this.Controls.Add(this.textBoxMachineName);
            this.Controls.Add(this.labelMachineName);
            this.Controls.Add(this.buttonCacnel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCacnel;
        private System.Windows.Forms.Label labelMachineName;
        private System.Windows.Forms.TextBox textBoxMachineName;
        private System.Windows.Forms.TextBox textBoxUpdateRate;
        private System.Windows.Forms.Label labelUpdateRate;
        private System.Windows.Forms.TextBox textBoxServerClass;
        private System.Windows.Forms.Label labelServerClass;
        private System.Windows.Forms.ListBox listBoxOPCTags;
    }
}