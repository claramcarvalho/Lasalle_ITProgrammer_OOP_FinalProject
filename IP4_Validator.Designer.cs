namespace Final_Project
{
    partial class IP4_Validator
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
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.bt_Validate = new System.Windows.Forms.Button();
            this.txIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(280, 191);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(105, 36);
            this.bt_Exit.TabIndex = 19;
            this.bt_Exit.Text = "E&xit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reset.Location = new System.Drawing.Point(151, 191);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(105, 36);
            this.bt_Reset.TabIndex = 18;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // bt_Validate
            // 
            this.bt_Validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Validate.Location = new System.Drawing.Point(22, 191);
            this.bt_Validate.Name = "bt_Validate";
            this.bt_Validate.Size = new System.Drawing.Size(105, 36);
            this.bt_Validate.TabIndex = 17;
            this.bt_Validate.Text = "Validate IP";
            this.bt_Validate.UseVisualStyleBackColor = true;
            this.bt_Validate.Click += new System.EventHandler(this.bt_Validate_Click);
            // 
            // txIP
            // 
            this.txIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txIP.Location = new System.Drawing.Point(189, 120);
            this.txIP.Name = "txIP";
            this.txIP.Size = new System.Drawing.Size(196, 26);
            this.txIP.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter IP address:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(18, 49);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(121, 17);
            this.lbDate.TabIndex = 14;
            this.lbDate.Text = "Long Date Format";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // IP4_Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 271);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.bt_Validate);
            this.Controls.Add(this.txIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDate);
            this.Name = "IP4_Validator";
            this.Text = "IP4_Validator";
            this.Load += new System.EventHandler(this.IP4_Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button bt_Validate;
        private System.Windows.Forms.TextBox txIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDate;
    }
}