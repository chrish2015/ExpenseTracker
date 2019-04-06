using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ExpenseTrackerWCF
{
    public class EventService : IEventService
    {
        public string SaveEvent(string eventName, string details, string date, string recurring, string file)
        {
            save(eventName, details, date, recurring, file);
            return string.Format("You entered: {0}", eventName);
        }


        public void save(string eventName, string details, string date, string recurring,string file)
        {

            // Create a new file in the working directory
            XmlTextWriter textWriter = new XmlTextWriter(file, Encoding.UTF8);
            // Opens the document
            textWriter.WriteStartDocument();
            // Write comments
            textWriter.WriteComment("EventsXML.xml");
            // Write first element
            textWriter.WriteStartElement("Events");
            textWriter.WriteStartElement("Event");
            // Write next element
            textWriter.WriteStartElement("eventName", "");
            textWriter.WriteString(eventName);
            textWriter.WriteEndElement();
            // Write some more elements
            textWriter.WriteStartElement("details", "");
            textWriter.WriteString(details);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("date", "");
            textWriter.WriteString(date);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("isRecurring", "");
            textWriter.WriteString(recurring);
            //nested element
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            // Ends the document.
            textWriter.WriteEndDocument();
            // close writer
            textWriter.Close();
            Console.ReadLine();
        }
    }
}
