using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicInterfaceTutorial;

namespace ExpenseTracker
{
    public partial class ContactsForm : Form
    {
        ContactsController contactsController = new ContactsController();
        private TextBox[] contactsTextBox;
        private RadioButtons[] radioButtons;

        public ContactsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (this.Controls.Count > 3)
            {
                this.Controls.RemoveAt(3);
            }

            //create an array of text boxes and labels
            Label[] labels = new Label[(int)this.numericUpDownNumComp.Value];
            contactsTextBox = new TextBox[(int)this.numericUpDownNumComp.Value];
            radioButtons = new RadioButtons[(int)this.numericUpDownNumComp.Value];
            Button button = new Button();
            for (int i = 0; i < contactsTextBox.Length; i++)
            {
                //instantiate and configure the text boxes
                contactsTextBox[i] = new TextBox();
                System.Drawing.Point p = new System.Drawing.Point(476, 114 + i * 25);
                contactsTextBox[i].Location = p;
                contactsTextBox[i].Size = new System.Drawing.Size(183, 20);
                this.Controls.Add(contactsTextBox[i]);
                //instantiate and configure the labels
                labels[i] = new Label();
                System.Drawing.Point pLabel = new System.Drawing.Point(400, 114 + i * 25);
                labels[i].Location = pLabel;
                labels[i].Size = new System.Drawing.Size(80, 13);
                labels[i].Text = @"Contact " + (i + 1).ToString() + ":";
                this.Controls.Add(labels[i]);
                //add some mouse events for the text boxes
                //add the radio buttons - these are already sized so just need to place at a point
                radioButtons[i] = new RadioButtons();
                radioButtons[i].Location = new System.Drawing.Point(670, 110 + i * 25);
                this.Controls.Add(radioButtons[i]);

            }

            button.Text = "Submit";
            button.Click += new System.EventHandler(this.submit_Click);
            button.Location = new System.Drawing.Point(470, 110 + (contactsTextBox.Length + 1) * 25);
            this.Controls.Add(button);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            contactsController.SaveContacts(contactsTextBox, radioButtons);

        }


    }
}
