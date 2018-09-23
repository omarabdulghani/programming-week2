namespace Assignment_8
{
    partial class Form1
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
            this.lblStartKm = new System.Windows.Forms.Label();
            this.lblEndKm = new System.Windows.Forms.Label();
            this.lblPricePerKm = new System.Windows.Forms.Label();
            this.txtInputStartKm = new System.Windows.Forms.TextBox();
            this.txtInputEndKm = new System.Windows.Forms.TextBox();
            this.txtInputPricePerKm = new System.Windows.Forms.TextBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPriceExclVAT = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblPriceInclVAT = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStartKm
            // 
            this.lblStartKm.AutoSize = true;
            this.lblStartKm.Location = new System.Drawing.Point(25, 38);
            this.lblStartKm.Name = "lblStartKm";
            this.lblStartKm.Size = new System.Drawing.Size(46, 13);
            this.lblStartKm.TabIndex = 0;
            this.lblStartKm.Text = "Start km";
            this.lblStartKm.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEndKm
            // 
            this.lblEndKm.AutoSize = true;
            this.lblEndKm.Location = new System.Drawing.Point(25, 83);
            this.lblEndKm.Name = "lblEndKm";
            this.lblEndKm.Size = new System.Drawing.Size(43, 13);
            this.lblEndKm.TabIndex = 1;
            this.lblEndKm.Text = "End km";
            // 
            // lblPricePerKm
            // 
            this.lblPricePerKm.AutoSize = true;
            this.lblPricePerKm.Location = new System.Drawing.Point(25, 130);
            this.lblPricePerKm.Name = "lblPricePerKm";
            this.lblPricePerKm.Size = new System.Drawing.Size(53, 13);
            this.lblPricePerKm.TabIndex = 2;
            this.lblPricePerKm.Text = "Price /km";
            // 
            // txtInputStartKm
            // 
            this.txtInputStartKm.Location = new System.Drawing.Point(85, 37);
            this.txtInputStartKm.Name = "txtInputStartKm";
            this.txtInputStartKm.Size = new System.Drawing.Size(100, 20);
            this.txtInputStartKm.TabIndex = 3;
            this.txtInputStartKm.TextChanged += new System.EventHandler(this.txtInputStartKm_TextChanged);
            // 
            // txtInputEndKm
            // 
            this.txtInputEndKm.Location = new System.Drawing.Point(85, 83);
            this.txtInputEndKm.Name = "txtInputEndKm";
            this.txtInputEndKm.Size = new System.Drawing.Size(100, 20);
            this.txtInputEndKm.TabIndex = 4;
            // 
            // txtInputPricePerKm
            // 
            this.txtInputPricePerKm.Location = new System.Drawing.Point(85, 127);
            this.txtInputPricePerKm.Name = "txtInputPricePerKm";
            this.txtInputPricePerKm.Size = new System.Drawing.Size(100, 20);
            this.txtInputPricePerKm.TabIndex = 5;
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(231, 38);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(102, 23);
            this.btnErase.TabIndex = 6;
            this.btnErase.Text = "&Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(231, 127);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPriceExclVAT
            // 
            this.lblPriceExclVAT.AutoSize = true;
            this.lblPriceExclVAT.Location = new System.Drawing.Point(25, 236);
            this.lblPriceExclVAT.Name = "lblPriceExclVAT";
            this.lblPriceExclVAT.Size = new System.Drawing.Size(13, 13);
            this.lblPriceExclVAT.TabIndex = 8;
            this.lblPriceExclVAT.Text = "0";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(163, 236);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(13, 13);
            this.lblVAT.TabIndex = 9;
            this.lblVAT.Text = "0";
            // 
            // lblPriceInclVAT
            // 
            this.lblPriceInclVAT.AutoSize = true;
            this.lblPriceInclVAT.Location = new System.Drawing.Point(262, 235);
            this.lblPriceInclVAT.Name = "lblPriceInclVAT";
            this.lblPriceInclVAT.Size = new System.Drawing.Size(13, 13);
            this.lblPriceInclVAT.TabIndex = 10;
            this.lblPriceInclVAT.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(25, 200);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(77, 13);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Price excl VAT";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(163, 200);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(28, 13);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "VAT";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(262, 199);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(71, 13);
            this.lbl3.TabIndex = 13;
            this.lbl3.Text = "Pice incl VAT";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(28, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "_____________________________________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblPriceInclVAT);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblPriceExclVAT);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.txtInputPricePerKm);
            this.Controls.Add(this.txtInputEndKm);
            this.Controls.Add(this.txtInputStartKm);
            this.Controls.Add(this.lblPricePerKm);
            this.Controls.Add(this.lblEndKm);
            this.Controls.Add(this.lblStartKm);
            this.Name = "Form1";
            this.Text = "Assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartKm;
        private System.Windows.Forms.Label lblEndKm;
        private System.Windows.Forms.Label lblPricePerKm;
        private System.Windows.Forms.TextBox txtInputStartKm;
        private System.Windows.Forms.TextBox txtInputEndKm;
        private System.Windows.Forms.TextBox txtInputPricePerKm;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPriceExclVAT;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblPriceInclVAT;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
    }
}

