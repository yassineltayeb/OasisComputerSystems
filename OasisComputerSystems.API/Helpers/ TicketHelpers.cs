namespace OasisComputerSystems.API.Helpers
{
    public static class  TicketHelpers
    {
        public class Status
        {
            public static readonly string Waiting = "Waiting";
            public static readonly string Reopened = "Reopened";
            public static readonly string WorkInProgress = "Work In Progress";
            public static readonly string PendingDelivery = "Pending Delivery";
            public static readonly string PendingOnCustomer = "Pending On Customer";
            public static readonly string Resolved = "Resolved";
            public static readonly string Canceled = "Canceled";
        }
    }
}