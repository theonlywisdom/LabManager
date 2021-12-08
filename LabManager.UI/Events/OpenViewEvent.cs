using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.UI.Events
{
    public class OpenViewEvent : PubSubEvent<OpenViewEventArgs>
    {
    }

    public class OpenViewEventArgs
    {
        public string ViewModelName { get; set; }
    }
}
