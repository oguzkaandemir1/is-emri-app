// See https://aka.ms/new-console-template for more information
using IsEmriApp;
using IsEmriApp.Reports;

var downtimeReport = DowntimeReports.GetDowntimeReport(SampleData.Downtimes);

Console.WriteLine("|----------Durus Raporu----------|");
Console.WriteLine("|-------|--------|------|--------|");
Console.WriteLine("| Order | Reason | Süre | Toplam |");
Console.WriteLine("|-------|--------|------|--------|");

foreach (var item in downtimeReport)
{
    Console.WriteLine($"| {item.OrderNo,5} " +
                      $"| {item.ReasonName,-6} " +
                      $"| {item.TotalDuration.ToString(@"mm"),4} " +
                      $"| {item.OrderTotalDuration.ToString(@"mm"),6} |");
}

Console.WriteLine("|-------------------------------------------|");
Console.WriteLine("|-------|-----------------|-----------------|");
Console.WriteLine("| Order |    Baslangic    |      Bitis      |");
Console.WriteLine("|-------|-----------------|-----------------|");

foreach (var item in SampleData.WorkOrders)
{
    Console.WriteLine($"| {item.OrderNo,5} " +
                  $"| {item.Start,-6} " +
                  $"| {item.End,-6} |");
}
Console.WriteLine("|------------------------------------------------------------|");
Console.WriteLine("| Duruş Nedeni   | Başlangıç           | Bitiş               |");
Console.WriteLine("|----------------|---------------------|---------------------|");

foreach (var item in SampleData.Downtimes)
{
    string reason = item.Reason?.ReasonName ?? "-";
    string start = item.Start.ToString("dd.MM.yyyy HH:mm:ss");
    string end = item.End.ToString("dd.MM.yyyy HH:mm:ss");

    Console.WriteLine($"| {reason,-14} | {start,-19} | {end,-19} |");
}
