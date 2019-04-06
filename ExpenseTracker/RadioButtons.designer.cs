namespace DynamicInterfaceTutorial
{
    partial class RadioButtons
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
            this.rbtPayer = new System.Windows.Forms.RadioButton();
            this.rbtPayee = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtPayer
            // 
            this.rbtPayer.AutoSize = true;
            this.rbtPayer.BackColor = System.Drawing.Color.Transparent;
            this.rbtPayer.Location = new System.Drawing.Point(0, 7);
            this.rbtPayer.Name = "rbtPayer";
            this.rbtPayer.Size = new System.Drawing.Size(52, 17);
            this.rbtPayer.TabIndex = 0;
            this.rbtPayer.TabStop = true;
            this.rbtPayer.Text = "Payer";
            this.rbtPayer.UseVisualStyleBackColor = false;
            this.rbtPayer.CheckedChanged += new System.EventHandler(this.radioButtonGreat_CheckedChanged);
            // 
            // rbtPayee
            // 
            this.rbtPayee.AutoSize = true;
            this.rbtPayee.BackColor = System.Drawing.Color.Transparent;
            this.rbtPayee.Location = new System.Drawing.Point(53, 8);
            this.rbtPayee.Name = "rbtPayee";
            this.rbtPayee.Size = new System.Drawing.Size(55, 17);
            this.rbtPayee.TabIndex = 1;
            this.rbtPayee.TabStop = true;
            this.rbtPayee.Text = "Payee";
            this.rbtPayee.UseVisualStyleBackColor = false;
            this.rbtPayee.CheckedChanged += new System.EventHandler(this.radioButtonGood_CheckedChanged);
            // 
            // RadioButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rbtPayee);
            this.Controls.Add(this.rbtPayer);
            this.Name = "RadioButtons";
            this.Size = new System.Drawing.Size(101, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtPayer;
        private System.Windows.Forms.RadioButton rbtPayee;
    }
}
