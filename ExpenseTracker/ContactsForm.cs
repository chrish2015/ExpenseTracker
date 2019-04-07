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
        readonly ContactsController _contactsController = new ContactsController();
        private TextBox[] _contactsTextBox;
        private RadioButtons[] _radioButtons;

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

            Label[] labels = new Label[(int)this.numberOfContacts.Value];
            _contactsTextBox = new TextBox[(int)this.numberOfContacts.Value];
            _radioButtons = new RadioButtons[(int)this.numberOfContacts.Value];
            Button button = new Button();
            for (int i = 0; i < _contactsTextBox.Length; i++)
            {
                _contactsTextBox[i] = new TextBox();
                System.Drawing.Point p = new System.Drawing.Point(476, 114 + i * 25);
                _contactsTextBox[i].Location = p;
                _contactsTextBox[i].Size = new System.Drawing.Size(183, 20);
                this.Controls.Add(_contactsTextBox[i]);
                labels[i] = new Label();
                System.Drawing.Point pLabel = new System.Drawing.Point(400, 114 + i * 25);
                labels[i].Location = pLabel;
                labels[i].Size = new System.Drawing.Size(80, 13);
                labels[i].Text = @"Contact " + (i + 1).ToString() + ":";
                this.Controls.Add(labels[i]);
                _radioButtons[i] = new RadioButtons();
                _radioButtons[i].Location = new System.Drawing.Point(670, 110 + i * 25);
                this.Controls.Add(_radioButtons[i]);

            }

            button.Text = "Submit";
            button.Click += new System.EventHandler(this.submit_Click);
            button.Location = new System.Drawing.Point(470, 110 + (_contactsTextBox.Length + 1) * 25);
            this.Controls.Add(button);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            _contactsController.SaveContacts(_contactsTextBox, _radioButtons);

        }


    }
}
