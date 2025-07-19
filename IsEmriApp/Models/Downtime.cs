namespace IsEmriApp.Models
{
    public class Downtime
    {
        public WorkOrder Order { get; set; }
        public DowntimeReason Reason { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class DownTimeReportModel
    {
        public int OrderNo { get; set; }
        public string ReasonName { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public TimeSpan OrderTotalDuration { get; set; }
    }
}
