﻿namespace ExpenseTracker
{
    partial class btnGneerate
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrediction = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeneratePrd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predicted Expenses";
            // 
            // lblPrediction
            // 
            this.lblPrediction.AutoSize = true;
            this.lblPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrediction.Location = new System.Drawing.Point(520, 235);
            this.lblPrediction.Name = "lblPrediction";
            this.lblPrediction.Size = new System.Drawing.Size(82, 24);
            this.lblPrediction.TabIndex = 1;
            this.lblPrediction.Text = "Amount";
            this.lblPrediction.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Predicted Amount";
            // 
            // btnGeneratePrd
            // 
            this.btnGeneratePrd.Location = new System.Drawing.Point(521, 377);
            this.btnGeneratePrd.Name = "btnGeneratePrd";
            this.btnGeneratePrd.Size = new System.Drawing.Size(83, 59);
            this.btnGeneratePrd.TabIndex = 2;
            this.btnGeneratePrd.Text = "Generate Prediction";
            this.btnGeneratePrd.UseVisualStyleBackColor = true;
            this.btnGeneratePrd.Click += new System.EventHandler(this.btnGeneratePrd_Click);
            // 
            // btnGneerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 521);
            this.Controls.Add(this.btnGeneratePrd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrediction);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btnGneerate";
            this.Text = "PredictionsForm";
            this.Load += new System.EventHandler(this.PredictionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrediction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeneratePrd;
    }
}