using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using ExpenseTracker.ServiceReference1;

namespace ExpenseTracker
{
    public partial class EventView : Form
    {
        private readonly EventController _eventController = new EventController();
        public EventView()
        {
            InitializeComponent();
        }

        private void EventView_Load(object sender, EventArgs e)
        {
            dataGridEvents.AutoGenerateColumns = false;
            FillDataTable();
        }

        private void FillDataTable()
        {
            var list = _eventController.GetEvents(MainView.file);
            if (list != null)
                dataGridEvents.DataSource = list;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!eventHandlerBckWrk.IsBusy)
            {
                String textDescription = txtDesc.Text;
                eventHandlerBckWrk.RunWorkerAsync(argument: textDescription);
            }
            else
            {
                MessageBox.Show("Backgroud worker is still busy", "Warning");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDataTable();
        }

        private void eventHandlerBckWrk_DoWork(object sender, DoWorkEventArgs e)
        {
            string description = (string)e.Argument;
            ServiceReference1.EventServiceClient eventService = new EventServiceClient();
            var checkedRecurringOption = rbtPanel.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if (checkedRecurringOption == null || txtEvent.Text.Trim() == "" || dateEvents.Text.Trim() == "")
            {
                MessageBox.Show("Please enter reqired fields", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            eventService.SaveEvent(txtEvent.Text, description, dateEvents.Text, checkedRecurringOption.Text, MainView.file);
            e.Result = "Success";
        }

        private void eventHandlerBckWrk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result == "Success")
                dataGridEvents.DataSource = _eventController.GetEvents(MainView.file);

        }
    }
}
