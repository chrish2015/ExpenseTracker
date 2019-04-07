using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExpenseTracker
{
    class EventController
    {
        public List<dynamic> GetEvents(String file)
        {

            XDocument document;
            try
            {
             document = XDocument.Load(file);
            }
            catch (Exception e)
            {
                return null;
            }
            var particularStudent = from xml in document.Descendants("Event")
                                    select new
                                    {
                                        name = xml.Element("Name").Value,
                                        description = xml.Element("Description").Value,
                                        isRecurring = xml.Element("IsRecurring").Value,
                                        date = xml.Element("Date").Value
                                    };
            return particularStudent.ToList<dynamic>();
        }

        public List<dynamic> GetWeeklyEvents(String file)
        {
            var dateTime = DateTime.Now.AddDays(-7);
            var todayDateTime = DateTime.Now;
            XDocument document = XDocument.Load(file);
            var particularStudent = from xml in document.Descendants("Event").Where(r => todayDateTime > DateTime.Parse(r.Element("Date").Value) && DateTime.Parse(r.Element("Date").Value) > dateTime)
                                    select new
                                    {
                                        name = xml.Element("Name").Value,
                                        description = xml.Element("Description").Value,
                                        isRecurring = xml.Element("IsRecurring").Value,
                                        date = xml.Element("Date").Value
                                    };
            return particularStudent.ToList<dynamic>();
        }
    }
}
