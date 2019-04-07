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

        public void CreateFileWatcher(string path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Application.ExecutablePath;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                                            | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            FillDataTable();
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
            ServiceReference1.EventServiceClient eventService = new EventServiceClient();

            var checkedRecurringOption = rbtPanel.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if (checkedRecurringOption == null || txtEvent.Text.Trim() == "" || dateEvents.Text.Trim() == "")
            {
                MessageBox.Show("Please enter reqired fields", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            eventService.SaveEvent(txtEvent.Text, txtDescription.Text, dateEvents.Text, checkedRecurringOption.Text, MainView.file);
            dataGridEvents.DataSource = _eventController.GetEvents(MainView.file);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDataTable();
        }
    }
}
