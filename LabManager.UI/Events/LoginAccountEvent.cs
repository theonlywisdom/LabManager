using Prism.Events;

namespace LabManager.UI.Events
{
    public class LoginAccountEvent : PubSubEvent<LoginAccountEventArgs>
    {

    }

    public class LoginAccountEventArgs
    {
        public string UserPassword { get; set; }
    }
}
