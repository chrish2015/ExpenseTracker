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
        EventController eventController=new EventController();
        public EventView()
        {
            InitializeComponent();

        }

        private void EventView_Load(object sender, EventArgs e)
        {
          
            dataGridEvents.AutoGenerateColumns = false;
            dataGridEvents.DataSource = eventController.getEvents(MainView.file);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ServiceReference1.EventServiceClient eventService = new EventServiceClient();
            var checkedRecurringOption = rbtPanel.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            eventService.SaveEvent(txtEvent.Text, txtDescription.Text, dateEvents.Text, checkedRecurringOption.Text, MainView.file);
            dataGridEvents.DataSource = eventController.getEvents(MainView.file);
        }

    }
}
