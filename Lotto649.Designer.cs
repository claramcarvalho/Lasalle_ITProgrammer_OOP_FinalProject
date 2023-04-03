namespace Final_Project
{
    partial class Lotto649
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotto649));
            this.lbNums = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.btGenerate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bxNums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNums
            // 
            this.lbNums.AutoSize = true;
            this.lbNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNums.Location = new System.Drawing.Point(23, 304);
            this.lbNums.Name = "lbNums";
            this.lbNums.Size = new System.Drawing.Size(0, 20);
            this.lbNums.TabIndex = 13;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(277, 348);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(110, 31);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "E&xit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRead
            // 
            this.btRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRead.Location = new System.Drawing.Point(152, 348);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(110, 31);
            this.btRead.TabIndex = 11;
            this.btRead.Text = "&Read File";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btGenerate
            // 
            this.btGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerate.Location = new System.Drawing.Point(27, 348);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(110, 31);
            this.btGenerate.TabIndex = 10;
            this.btGenerate.Text = "&Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(27, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 204);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bxNums
            // 
            this.bxNums.Location = new System.Drawing.Point(287, 23);
            this.bxNums.Multiline = true;
            this.bxNums.Name = "bxNums";
            this.bxNums.ReadOnly = true;
            this.bxNums.Size = new System.Drawing.Size(100, 249);
            this.bxNums.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "The winning number are:";
            // 
            // Lotto649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 402);
            this.Controls.Add(this.lbNums);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bxNums);
            this.Controls.Add(this.label1);
            this.Name = "Lotto649";
            this.Text = "Lotto649";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNums;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox bxNums;
        private System.Windows.Forms.Label label1;
    }
}