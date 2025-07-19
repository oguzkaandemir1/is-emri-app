using IsEmriApp.Models;

namespace IsEmriApp.Reports
{
    public class DowntimeReports
    {
        public static List<DownTimeReportModel> GetDowntimeReport(List<Downtime> downtimes)
        {
            // 1. Adım: Önce her OrderNo için toplam süreyi hesapla (sözlük olarak)
            var orderTotalDowntime = SampleData.Downtimes
                .GroupBy(d => d.Order.OrderNo)
                .ToDictionary(
                    g => g.Key,
                    g => TimeSpan.FromMinutes(g.Sum(dt => (dt.End - dt.Start).TotalMinutes))
                );

            // 2. Adım: Asıl raporu oluştururken sözlükteki toplam süreyi ekle
            return SampleData.Downtimes
                .GroupBy(d => new
                {
                    ReasonName = d.Reason.ReasonName,
                    OrderNo = d.Order.OrderNo
                })
                .Select(g => new DownTimeReportModel
                {
                    OrderNo = g.Key.OrderNo,
                    ReasonName = g.Key.ReasonName,
                    TotalDuration = TimeSpan.FromMinutes(g.Sum(d => (d.End - d.Start).TotalMinutes)),
                    OrderTotalDuration = orderTotalDowntime[g.Key.OrderNo] // Sözlükten ilgili OrderNo'nun toplamını getir
                })
                .OrderBy(x => x.OrderNo)
                .ThenBy(x => x.ReasonName)
                .ToList();
        }
    }
}
