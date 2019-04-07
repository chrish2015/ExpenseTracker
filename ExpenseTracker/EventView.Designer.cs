namespace ExpenseTracker
{
    partial class EventView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbtPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEvents = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.dataGridEvents = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRecurring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventHandlerBckWrk = new System.ComponentModel.BackgroundWorker();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.rbtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.rbtPanel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateEvents);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEvent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1116, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add  Event";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(999, 43);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 63);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbtPanel
            // 
            this.rbtPanel.Controls.Add(this.label4);
            this.rbtPanel.Controls.Add(this.rbtNo);
            this.rbtPanel.Controls.Add(this.rbtYes);
            this.rbtPanel.Location = new System.Drawing.Point(669, 42);
            this.rbtPanel.Name = "rbtPanel";
            this.rbtPanel.Size = new System.Drawing.Size(219, 63);
            this.rbtPanel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Is this a recurring event";
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(146, 32);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 1;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.Location = new System.Drawing.Point(38, 32);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(43, 17);
            this.rbtYes.TabIndex = 0;
            this.rbtYes.TabStop = true;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // dateEvents
            // 
            this.dateEvents.Location = new System.Drawing.Point(112, 85);
            this.dateEvents.Name = "dateEvents";
            this.dateEvents.Size = new System.Drawing.Size(200, 20);
            this.dateEvents.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Name";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(112, 46);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(200, 20);
            this.txtEvent.TabIndex = 0;
            // 
            // dataGridEvents
            // 
            this.dataGridEvents.AllowUserToAddRows = false;
            this.dataGridEvents.AllowUserToDeleteRows = false;
            this.dataGridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Date,
            this.Description,
            this.IsRecurring});
            this.dataGridEvents.Location = new System.Drawing.Point(12, 161);
            this.dataGridEvents.Name = "dataGridEvents";
            this.dataGridEvents.ReadOnly = true;
            this.dataGridEvents.Size = new System.Drawing.Size(1116, 344);
            this.dataGridEvents.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 200;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // IsRecurring
            // 
            this.IsRecurring.DataPropertyName = "IsRecurring";
            this.IsRecurring.HeaderText = "IsRecurring";
            this.IsRecurring.Name = "IsRecurring";
            this.IsRecurring.ReadOnly = true;
            // 
            // eventHandlerBckWrk
            // 
            this.eventHandlerBckWrk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.eventHandlerBckWrk_DoWork);
            this.eventHandlerBckWrk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.eventHandlerBckWrk_RunWorkerCompleted);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(458, 42);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(173, 64);
            this.txtDesc.TabIndex = 8;
            this.txtDesc.Text = "";
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 521);
            this.Controls.Add(this.dataGridEvents);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "EventView";
            this.Load += new System.EventHandler(this.EventView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rbtPanel.ResumeLayout(false);
            this.rbtPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateEvents;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel rbtPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.DataGridView dataGridEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRecurring;
        private System.ComponentModel.BackgroundWorker eventHandlerBckWrk;
        private System.Windows.Forms.RichTextBox txtDesc;
    }
}