using Prism.Events;


namespace Inse.Fiproject.Events
{
    enum ContentType
    {
        Login,
        Check,
        Main
    }

    internal class SwitchContentEvent : PubSubEvent<ContentType> { }
}
