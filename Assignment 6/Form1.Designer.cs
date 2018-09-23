namespace Assignment_6
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
            this.btnCalculateTime = new System.Windows.Forms.Button();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.txtNrOfSeconds = new System.Windows.Forms.TextBox();
            this.lblHoursMinutesSeconds = new System.Windows.Forms.Label();
            this.lblResultHours = new System.Windows.Forms.Label();
            this.lblResultMinutes = new System.Windows.Forms.Label();
            this.lblResultSeconds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateTime
            // 
            this.btnCalculateTime.Location = new System.Drawing.Point(28, 76);
            this.btnCalculateTime.Name = "btnCalculateTime";
            this.btnCalculateTime.Size = new System.Drawing.Size(177, 23);
            this.btnCalculateTime.TabIndex = 0;
            this.btnCalculateTime.Text = "&Calculate Time";
            this.btnCalculateTime.UseVisualStyleBackColor = true;
            this.btnCalculateTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(25, 39);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(52, 13);
            this.lblSeconds.TabIndex = 1;
            this.lblSeconds.Text = "Seconds:";
            // 
            // txtNrOfSeconds
            // 
            this.txtNrOfSeconds.Location = new System.Drawing.Point(105, 35);
            this.txtNrOfSeconds.Name = "txtNrOfSeconds";
            this.txtNrOfSeconds.Size = new System.Drawing.Size(100, 20);
            this.txtNrOfSeconds.TabIndex = 2;
            this.txtNrOfSeconds.TextChanged += new System.EventHandler(this.txtNrOfSeconds_TextChanged);
            // 
            // lblHoursMinutesSeconds
            // 
            this.lblHoursMinutesSeconds.AutoSize = true;
            this.lblHoursMinutesSeconds.Location = new System.Drawing.Point(25, 119);
            this.lblHoursMinutesSeconds.Name = "lblHoursMinutesSeconds";
            this.lblHoursMinutesSeconds.Size = new System.Drawing.Size(127, 13);
            this.lblHoursMinutesSeconds.TabIndex = 3;
            this.lblHoursMinutesSeconds.Text = "hours : minutes : seconds";
            this.lblHoursMinutesSeconds.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblResultHours
            // 
            this.lblResultHours.AutoSize = true;
            this.lblResultHours.Location = new System.Drawing.Point(25, 152);
            this.lblResultHours.Name = "lblResultHours";
            this.lblResultHours.Size = new System.Drawing.Size(19, 13);
            this.lblResultHours.TabIndex = 4;
            this.lblResultHours.Text = "00";
            this.lblResultHours.Click += new System.EventHandler(this.lblResultHours_Click);
            // 
            // lblResultMinutes
            // 
            this.lblResultMinutes.AutoSize = true;
            this.lblResultMinutes.Location = new System.Drawing.Point(50, 152);
            this.lblResultMinutes.Name = "lblResultMinutes";
            this.lblResultMinutes.Size = new System.Drawing.Size(22, 13);
            this.lblResultMinutes.TabIndex = 5;
            this.lblResultMinutes.Text = " 00";
            // 
            // lblResultSeconds
            // 
            this.lblResultSeconds.AutoSize = true;
            this.lblResultSeconds.Location = new System.Drawing.Point(81, 152);
            this.lblResultSeconds.Name = "lblResultSeconds";
            this.lblResultSeconds.Size = new System.Drawing.Size(22, 13);
            this.lblResultSeconds.TabIndex = 6;
            this.lblResultSeconds.Text = " 00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultSeconds);
            this.Controls.Add(this.lblResultMinutes);
            this.Controls.Add(this.lblResultHours);
            this.Controls.Add(this.lblHoursMinutesSeconds);
            this.Controls.Add(this.txtNrOfSeconds);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.btnCalculateTime);
            this.Name = "Form1";
            this.Text = "Assignment 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateTime;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.TextBox txtNrOfSeconds;
        private System.Windows.Forms.Label lblHoursMinutesSeconds;
        private System.Windows.Forms.Label lblResultHours;
        private System.Windows.Forms.Label lblResultMinutes;
        private System.Windows.Forms.Label lblResultSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

