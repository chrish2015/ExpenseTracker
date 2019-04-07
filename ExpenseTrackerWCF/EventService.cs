using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ExpenseTrackerWCF
{
    public class EventService : IEventService
    {
        public string SaveEvent(string eventName, string details, string date, string recurring, string file)
        {
            var t = new Thread(() => save(eventName, details, date, recurring, file));
            t.Start();
            return string.Format("Successfully Added ", eventName);
        }

        private void save(string eventName, string details, string date, string recurring, string file)
        {
            XDocument document = null;

            try
            {
                document = XDocument.Load(file);
            }
            catch (Exception exception)
            {
                createAndLoadXML(file);
                document = XDocument.Load(file);
            }

            XElement school = document.Element("Events");
            school.Add(new XElement("Event",
                new XElement("Name", eventName),
                new XElement("Description",details),
                new XElement("IsRecurring", recurring),
                new XElement("Date", date)));
            document.Save(file);
        }

        private void createAndLoadXML(string file)
        {
            // Method to create XML file based on name entered by user

            // Create XDocument
            XDocument document = new XDocument(
                new XDeclaration("1.0", "utf8", "yes"),
                new XComment("Events.xml"),
                new XElement("Events"
                ));
            document.Save(file);
        }
    }
}
