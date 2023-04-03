namespace Final_Project
{
    partial class TempConv
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
            this.rdCtoF = new System.Windows.Forms.RadioButton();
            this.rdFtoC = new System.Windows.Forms.RadioButton();
            this.txIn = new System.Windows.Forms.TextBox();
            this.txOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_ReadFile = new System.Windows.Forms.Button();
            this.bt_Conv = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdCtoF
            // 
            this.rdCtoF.AutoSize = true;
            this.rdCtoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCtoF.Location = new System.Drawing.Point(140, 13);
            this.rdCtoF.Name = "rdCtoF";
            this.rdCtoF.Size = new System.Drawing.Size(115, 24);
            this.rdCtoF.TabIndex = 0;
            this.rdCtoF.TabStop = true;
            this.rdCtoF.Text = "from C to F";
            this.rdCtoF.UseVisualStyleBackColor = true;
            this.rdCtoF.CheckedChanged += new System.EventHandler(this.rdCtoF_CheckedChanged);
            // 
            // rdFtoC
            // 
            this.rdFtoC.AutoSize = true;
            this.rdFtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFtoC.Location = new System.Drawing.Point(140, 53);
            this.rdFtoC.Name = "rdFtoC";
            this.rdFtoC.Size = new System.Drawing.Size(115, 24);
            this.rdFtoC.TabIndex = 1;
            this.rdFtoC.TabStop = true;
            this.rdFtoC.Text = "from F to C";
            this.rdFtoC.UseVisualStyleBackColor = true;
            this.rdFtoC.CheckedChanged += new System.EventHandler(this.rdFtoC_CheckedChanged);
            // 
            // txIn
            // 
            this.txIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txIn.Location = new System.Drawing.Point(20, 102);
            this.txIn.Name = "txIn";
            this.txIn.Size = new System.Drawing.Size(131, 30);
            this.txIn.TabIndex = 2;
            this.txIn.TextChanged += new System.EventHandler(this.txIn_TextChanged);
            // 
            // txOut
            // 
            this.txOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txOut.Location = new System.Drawing.Point(244, 102);
            this.txOut.Name = "txOut";
            this.txOut.ReadOnly = true;
            this.txOut.Size = new System.Drawing.Size(131, 30);
            this.txOut.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(71, 135);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(28, 25);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "C";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(297, 135);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(25, 25);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "F";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message";
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(270, 319);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(105, 36);
            this.bt_Exit.TabIndex = 13;
            this.bt_Exit.Text = "E&xit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_ReadFile
            // 
            this.bt_ReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ReadFile.Location = new System.Drawing.Point(143, 319);
            this.bt_ReadFile.Name = "bt_ReadFile";
            this.bt_ReadFile.Size = new System.Drawing.Size(105, 36);
            this.bt_ReadFile.TabIndex = 12;
            this.bt_ReadFile.Text = "&Read file";
            this.bt_ReadFile.UseVisualStyleBackColor = true;
            this.bt_ReadFile.Click += new System.EventHandler(this.bt_ReadFile_Click);
            // 
            // bt_Conv
            // 
            this.bt_Conv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Conv.Location = new System.Drawing.Point(20, 319);
            this.bt_Conv.Name = "bt_Conv";
            this.bt_Conv.Size = new System.Drawing.Size(105, 36);
            this.bt_Conv.TabIndex = 11;
            this.bt_Conv.Text = "&Convert";
            this.bt_Conv.UseVisualStyleBackColor = true;
            this.bt_Conv.Click += new System.EventHandler(this.bt_Conv_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(15, 255);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 25);
            this.lbMessage.TabIndex = 14;
            // 
            // TempConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 369);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_ReadFile);
            this.Controls.Add(this.bt_Conv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txOut);
            this.Controls.Add(this.txIn);
            this.Controls.Add(this.rdFtoC);
            this.Controls.Add(this.rdCtoF);
            this.Name = "TempConv";
            this.Text = "Temperature Conversion - Clara";
            this.Load += new System.EventHandler(this.TempConv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdCtoF;
        private System.Windows.Forms.RadioButton rdFtoC;
        private System.Windows.Forms.TextBox txIn;
        private System.Windows.Forms.TextBox txOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_ReadFile;
        private System.Windows.Forms.Button bt_Conv;
        private System.Windows.Forms.Label lbMessage;
    }
}