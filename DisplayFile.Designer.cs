namespace Final_Project
{
    partial class DisplayFile
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
            this.txbx_ContentFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_ContentFile
            // 
            this.txbx_ContentFile.Location = new System.Drawing.Point(15, 28);
            this.txbx_ContentFile.Multiline = true;
            this.txbx_ContentFile.Name = "txbx_ContentFile";
            this.txbx_ContentFile.ReadOnly = true;
            this.txbx_ContentFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbx_ContentFile.Size = new System.Drawing.Size(509, 329);
            this.txbx_ContentFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "The content of your file:";
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(431, 370);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(93, 35);
            this.bt_Exit.TabIndex = 2;
            this.bt_Exit.Text = "OK";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // DisplayFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 417);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_ContentFile);
            this.Name = "DisplayFile";
            this.Text = "File Content";
            this.Load += new System.EventHandler(this.DisplayFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_ContentFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Exit;
    }
}