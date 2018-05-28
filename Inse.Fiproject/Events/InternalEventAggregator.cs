using Prism.Events;


namespace Inse.Fiproject.Events
{
    internal static class InternalEventAggregator 
    {
        private static readonly EventAggregator current = new EventAggregator();

        public static EventAggregator Current
        {
            get { return current; }
        }
    }
}
