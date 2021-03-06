﻿namespace ExpenseTracker
{
    partial class MainView
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
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnPredictions = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnWeeklyView = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(12, 15);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(124, 41);
            this.btnTransactions.TabIndex = 0;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnPredictions
            // 
            this.btnPredictions.Location = new System.Drawing.Point(152, 15);
            this.btnPredictions.Name = "btnPredictions";
            this.btnPredictions.Size = new System.Drawing.Size(124, 41);
            this.btnPredictions.TabIndex = 1;
            this.btnPredictions.Text = "Predictions";
            this.btnPredictions.UseVisualStyleBackColor = true;
            this.btnPredictions.Click += new System.EventHandler(this.btnPredictions_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(292, 15);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(124, 41);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnWeeklyView
            // 
            this.btnWeeklyView.Location = new System.Drawing.Point(432, 15);
            this.btnWeeklyView.Name = "btnWeeklyView";
            this.btnWeeklyView.Size = new System.Drawing.Size(124, 41);
            this.btnWeeklyView.TabIndex = 3;
            this.btnWeeklyView.Text = "Weekly View";
            this.btnWeeklyView.UseVisualStyleBackColor = true;
            this.btnWeeklyView.Click += new System.EventHandler(this.btnWeeklyView_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(572, 15);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(124, 41);
            this.btnContacts.TabIndex = 4;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(12, 72);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1140, 521);
            this.pnlMain.TabIndex = 5;
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(712, 15);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(124, 41);
            this.btnEvents.TabIndex = 6;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 605);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnWeeklyView);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnPredictions);
            this.Controls.Add(this.btnTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.btnExitProgram_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnPredictions;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnWeeklyView;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnEvents;
    }
}