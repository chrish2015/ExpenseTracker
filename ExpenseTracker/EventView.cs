using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public EventView()
        {
            InitializeComponent();
        }

        private void EventView_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ServiceReference1.EventServiceClient a = new EventServiceClient();
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string file = System.IO.Path.Combine(path, "Events.xml");
            var checkedRecurringOption = rbtPanel.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            a.SaveEvent(txtEvent.Text, txtDescription.Text, dateEvents.Text, checkedRecurringOption.Text, file);
        }

    }
}
