namespace Assignment_5
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
            this.lbl1NumberOne = new System.Windows.Forms.Label();
            this.lbl2NumberTwo = new System.Windows.Forms.Label();
            this.lbl3NumberThree = new System.Windows.Forms.Label();
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.txtNumberThree = new System.Windows.Forms.TextBox();
            this.btnCalculateAvrg = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1NumberOne
            // 
            this.lbl1NumberOne.AutoSize = true;
            this.lbl1NumberOne.Location = new System.Drawing.Point(47, 35);
            this.lbl1NumberOne.Name = "lbl1NumberOne";
            this.lbl1NumberOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl1NumberOne.Size = new System.Drawing.Size(53, 13);
            this.lbl1NumberOne.TabIndex = 0;
            this.lbl1NumberOne.Text = "Number 1";
            this.lbl1NumberOne.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2NumberTwo
            // 
            this.lbl2NumberTwo.AutoSize = true;
            this.lbl2NumberTwo.Location = new System.Drawing.Point(47, 65);
            this.lbl2NumberTwo.Name = "lbl2NumberTwo";
            this.lbl2NumberTwo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl2NumberTwo.Size = new System.Drawing.Size(53, 13);
            this.lbl2NumberTwo.TabIndex = 1;
            this.lbl2NumberTwo.Text = "Number 2";
            this.lbl2NumberTwo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl3NumberThree
            // 
            this.lbl3NumberThree.AutoSize = true;
            this.lbl3NumberThree.Location = new System.Drawing.Point(47, 100);
            this.lbl3NumberThree.Name = "lbl3NumberThree";
            this.lbl3NumberThree.Size = new System.Drawing.Size(53, 13);
            this.lbl3NumberThree.TabIndex = 2;
            this.lbl3NumberThree.Text = "Number 3";
            this.lbl3NumberThree.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(123, 32);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOne.TabIndex = 3;
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(123, 65);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(100, 20);
            this.txtNumberTwo.TabIndex = 4;
            // 
            // txtNumberThree
            // 
            this.txtNumberThree.Location = new System.Drawing.Point(123, 100);
            this.txtNumberThree.Name = "txtNumberThree";
            this.txtNumberThree.Size = new System.Drawing.Size(100, 20);
            this.txtNumberThree.TabIndex = 5;
            // 
            // btnCalculateAvrg
            // 
            this.btnCalculateAvrg.Location = new System.Drawing.Point(50, 146);
            this.btnCalculateAvrg.Name = "btnCalculateAvrg";
            this.btnCalculateAvrg.Size = new System.Drawing.Size(173, 23);
            this.btnCalculateAvrg.TabIndex = 6;
            this.btnCalculateAvrg.Text = "&Calculate Average";
            this.btnCalculateAvrg.UseVisualStyleBackColor = true;
            this.btnCalculateAvrg.Click += new System.EventHandler(this.btnCalculateAvrg_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(47, 198);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "Average:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(188, 198);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "0";
            this.lblResult.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 241);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnCalculateAvrg);
            this.Controls.Add(this.txtNumberThree);
            this.Controls.Add(this.txtNumberTwo);
            this.Controls.Add(this.txtNumberOne);
            this.Controls.Add(this.lbl3NumberThree);
            this.Controls.Add(this.lbl2NumberTwo);
            this.Controls.Add(this.lbl1NumberOne);
            this.Name = "Form1";
            this.Text = "Assignmnet 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1NumberOne;
        private System.Windows.Forms.Label lbl2NumberTwo;
        private System.Windows.Forms.Label lbl3NumberThree;
        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.TextBox txtNumberThree;
        private System.Windows.Forms.Button btnCalculateAvrg;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblResult;
    }
}

