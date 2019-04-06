namespace ExpenseTracker
{
    partial class TransactionForm
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
            this.dataGridTransactions = new System.Windows.Forms.DataGridView();
            this.transactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRecurring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.datePickerTransactions = new System.Windows.Forms.DateTimePicker();
            this.pnlRecurring = new System.Windows.Forms.Panel();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.pnlType = new System.Windows.Forms.Panel();
            this.btnIncome = new System.Windows.Forms.RadioButton();
            this.btnExpense = new System.Windows.Forms.RadioButton();
            this.lblContact = new System.Windows.Forms.Label();
            this.cmbBoxContacts = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).BeginInit();
            this.pnlRecurring.SuspendLayout();
            this.pnlType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridTransactions
            // 
            this.dataGridTransactions.AllowUserToDeleteRows = false;
            this.dataGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionId,
            this.transactionName,
            this.date,
            this.value,
            this.transactionType,
            this.description,
            this.isRecurring,
            this.contactName,
            this.contactId,
            this.userId});
            this.dataGridTransactions.Location = new System.Drawing.Point(337, 12);
            this.dataGridTransactions.Name = "dataGridTransactions";
            this.dataGridTransactions.ReadOnly = true;
            this.dataGridTransactions.Size = new System.Drawing.Size(791, 497);
            this.dataGridTransactions.TabIndex = 0;
            this.dataGridTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTransactions_CellContentClick);
            this.dataGridTransactions.Click += new System.EventHandler(this.income_Clicked);
            this.dataGridTransactions.DoubleClick += new System.EventHandler(this.dataGridTransactions_DoubleClick);
            // 
            // transactionId
            // 
            this.transactionId.DataPropertyName = "transactionId";
            this.transactionId.HeaderText = "Transaction ID";
            this.transactionId.Name = "transactionId";
            this.transactionId.ReadOnly = true;
            this.transactionId.Visible = false;
            // 
            // transactionName
            // 
            this.transactionName.DataPropertyName = "transactionName";
            this.transactionName.HeaderText = "Name";
            this.transactionName.Name = "transactionName";
            this.transactionName.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // value
            // 
            this.value.DataPropertyName = "value";
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // transactionType
            // 
            this.transactionType.DataPropertyName = "transactionType";
            this.transactionType.HeaderText = "Transaction Type";
            this.transactionType.Name = "transactionType";
            this.transactionType.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // isRecurring
            // 
            this.isRecurring.DataPropertyName = "isRecurring";
            this.isRecurring.HeaderText = "Is Recurring";
            this.isRecurring.Name = "isRecurring";
            this.isRecurring.ReadOnly = true;
            // 
            // contactName
            // 
            this.contactName.DataPropertyName = "contactName";
            this.contactName.HeaderText = "Contact";
            this.contactName.Name = "contactName";
            this.contactName.ReadOnly = true;
            // 
            // contactId
            // 
            this.contactId.DataPropertyName = "contactId";
            this.contactId.HeaderText = "Contact ID";
            this.contactId.Name = "contactId";
            this.contactId.ReadOnly = true;
            this.contactId.Visible = false;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "User ID";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 20);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(82, 121);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(236, 20);
            this.txtValue.TabIndex = 8;
            this.txtValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtValue_Validating);
            this.txtValue.Validated += new System.EventHandler(this.txtValue_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.expense_Checked);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(243, 424);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(139, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(29, 424);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Is This A Recurring Transaction";
            // 
            // datePickerTransactions
            // 
            this.datePickerTransactions.Location = new System.Drawing.Point(82, 44);
            this.datePickerTransactions.Name = "datePickerTransactions";
            this.datePickerTransactions.Size = new System.Drawing.Size(236, 20);
            this.datePickerTransactions.TabIndex = 20;
            this.datePickerTransactions.ValueChanged += new System.EventHandler(this.datePickerTransactions_ValueChanged);
            // 
            // pnlRecurring
            // 
            this.pnlRecurring.Controls.Add(this.rbtNo);
            this.pnlRecurring.Controls.Add(this.rbtYes);
            this.pnlRecurring.Controls.Add(this.label6);
            this.pnlRecurring.Location = new System.Drawing.Point(29, 263);
            this.pnlRecurring.Name = "pnlRecurring";
            this.pnlRecurring.Size = new System.Drawing.Size(289, 100);
            this.pnlRecurring.TabIndex = 22;
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(204, 58);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 18;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.Checked = true;
            this.rbtYes.Location = new System.Drawing.Point(73, 58);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(43, 17);
            this.rbtYes.TabIndex = 17;
            this.rbtYes.TabStop = true;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = true;
            // 
            // pnlType
            // 
            this.pnlType.Controls.Add(this.btnIncome);
            this.pnlType.Controls.Add(this.btnExpense);
            this.pnlType.Location = new System.Drawing.Point(82, 70);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(236, 41);
            this.pnlType.TabIndex = 23;
            // 
            // btnIncome
            // 
            this.btnIncome.AutoSize = true;
            this.btnIncome.Location = new System.Drawing.Point(161, 12);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(60, 17);
            this.btnIncome.TabIndex = 1;
            this.btnIncome.Text = "Income";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.income_Clicked);
            // 
            // btnExpense
            // 
            this.btnExpense.AutoSize = true;
            this.btnExpense.Location = new System.Drawing.Point(10, 11);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(66, 17);
            this.btnExpense.TabIndex = 0;
            this.btnExpense.Text = "Expense";
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.Click += new System.EventHandler(this.expense_Checked);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(26, 165);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(37, 13);
            this.lblContact.TabIndex = 24;
            this.lblContact.Text = "Payee";
            // 
            // cmbBoxContacts
            // 
            this.cmbBoxContacts.FormattingEnabled = true;
            this.cmbBoxContacts.Location = new System.Drawing.Point(82, 165);
            this.cmbBoxContacts.Name = "cmbBoxContacts";
            this.cmbBoxContacts.Size = new System.Drawing.Size(236, 21);
            this.cmbBoxContacts.TabIndex = 25;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(92, 201);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(226, 52);
            this.txtDescription.TabIndex = 26;
            this.txtDescription.Text = "";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 521);
            this.ControlBox = false;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbBoxContacts);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.pnlType);
            this.Controls.Add(this.pnlRecurring);
            this.Controls.Add(this.datePickerTransactions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).EndInit();
            this.pnlRecurring.ResumeLayout(false);
            this.pnlRecurring.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerTransactions;
        private System.Windows.Forms.Panel pnlRecurring;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.Panel pnlType;
        private System.Windows.Forms.RadioButton btnIncome;
        private System.Windows.Forms.RadioButton btnExpense;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.ComboBox cmbBoxContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRecurring;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}