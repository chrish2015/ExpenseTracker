using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExpenseTrackerWCF
{
    [ServiceContract]
    public interface IEventService
    {
        [OperationContract]
        string SaveEvent(string eventName, string details, string date, string recurring, string file);


    }
}
