namespace ExpenseTracker
{
    partial class ContactsForm
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
            this.numberOfContacts = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfContacts
            // 
            this.numberOfContacts.Location = new System.Drawing.Point(588, 47);
            this.numberOfContacts.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numberOfContacts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfContacts.Name = "numberOfContacts";
            this.numberOfContacts.Size = new System.Drawing.Size(53, 20);
            this.numberOfContacts.TabIndex = 0;
            this.numberOfContacts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many contacts are you going to add (Max - 8)";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(701, 47);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 521);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactsForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberOfContacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
    }
}