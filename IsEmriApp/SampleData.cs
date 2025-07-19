using IsEmriApp.Models;

namespace IsEmriApp
{
    public static class SampleData
    {
        public static List<DowntimeReason> DowntimeReasons = new List<DowntimeReason>
        {
            new DowntimeReason { ReasonNo = 1, ReasonName = "Arıza" },
            new DowntimeReason { ReasonNo = 2, ReasonName = "Mola" },
            new DowntimeReason { ReasonNo = 3, ReasonName = "Setup" },
            new DowntimeReason { ReasonNo = 4, ReasonName = "Arge" },
        };

        public static List<WorkOrder> WorkOrders = new List<WorkOrder>
        {
            new WorkOrder { OrderNo = 1001, Start = new DateTime(2017, 1, 1, 8, 0, 0), End = new DateTime(2017, 1, 1, 16, 0, 0)},
            new WorkOrder { OrderNo = 1002, Start = new DateTime(2017, 1, 1,16, 0, 0), End = new DateTime(2017, 1, 2, 00, 0, 0)},
            new WorkOrder { OrderNo = 1003, Start = new DateTime(2017, 1, 2,00, 0, 0), End = new DateTime(2017, 1, 2, 8, 0, 0)},
            new WorkOrder { OrderNo = 1004, Start = new DateTime(2017, 1, 1,8, 0, 0), End = new DateTime(2017, 1, 2, 16, 0, 0)},
            new WorkOrder { OrderNo = 1005, Start = new DateTime(2017, 1, 1,16, 0, 0), End = new DateTime(2017, 1, 3, 00, 0, 0)},
            new WorkOrder { OrderNo = 1006, Start = new DateTime(2017, 1, 3,00, 0, 0), End = new DateTime(2017, 1, 3, 8, 0, 0)},
            new WorkOrder { OrderNo = 1007, Start = new DateTime(2017, 1, 3,8, 0, 0), End = new DateTime(2017, 1, 3, 16, 0, 0)},
            new WorkOrder { OrderNo = 1008, Start = new DateTime(2017, 1, 3,16, 0, 0), End = new DateTime(2017, 1, 4, 00, 0, 0)},
            new WorkOrder { OrderNo = 1009, Start = new DateTime(2017, 1, 4,00, 0, 0), End = new DateTime(2017, 1, 4, 8, 0, 0)},
        };

        //public static List<Downtime> Downtimes = new List<Downtime>
        //{
        //    // Order 1
        //    new Downtime { Order = WorkOrders[0], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 1, 10, 0, 0), End = new DateTime(2017, 1, 1, 10, 10, 0) },
        //    new Downtime { Order = WorkOrders[0], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 1, 10, 30, 0), End = new DateTime(2017, 1, 1, 11, 00, 0) },
        //    new Downtime { Order = WorkOrders[0], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 1, 12, 0, 0), End = new DateTime(2017, 1, 1, 12, 30, 0) },
        //    new Downtime { Order = WorkOrders[0], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 1, 14, 0, 0), End = new DateTime(2017, 1, 1, 14, 10, 0) },
        //    new Downtime { Order = WorkOrders[0], Reason = DowntimeReasons[3], Start = new DateTime(2017, 1, 1, 15, 0, 0), End = new DateTime(2017, 1, 1, 16, 30, 0) },

        //    // Order 2
        //    new Downtime { Order = WorkOrders[1], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 1, 18, 0, 0), End = new DateTime(2017, 1, 1, 18, 10, 0) },
        //    new Downtime { Order = WorkOrders[1], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 1, 20, 0, 0), End = new DateTime(2017, 1, 1, 20, 30, 0) },
        //    new Downtime { Order = WorkOrders[1], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 1, 22, 0, 0), End = new DateTime(2017, 1, 1, 22, 10, 0) },
        //    new Downtime { Order = WorkOrders[1], Reason = DowntimeReasons[4], Start = new DateTime(2017, 1, 1, 23, 0, 0), End = new DateTime(2017, 1, 2, 8, 30, 0) },

        //    // Diğer orderlar için benzer şekilde devam eder.
        //    // Order 3
        //    new Downtime { Order = WorkOrders[2], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 2, 10, 00, 0), End = new DateTime(2017, 1, 2, 10, 10, 0) },
        //    new Downtime { Order = WorkOrders[2], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 2, 12, 0, 0), End = new DateTime(2017, 1, 2, 12, 30, 0) },
        //    new Downtime { Order = WorkOrders[2], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 2, 13, 0, 0), End = new DateTime(2017, 1, 2, 13, 45, 0) },
        //    new Downtime { Order = WorkOrders[2], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 2, 14, 0, 0), End = new DateTime(2017, 1, 2, 14, 10, 0) },

        //    // ... Tüm orderlar için 3'er downtime (Toplam 51 downtime)
        //    // Son order (17) için örnek:
        //    new Downtime { Order = WorkOrders[3], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 2, 18, 0, 0), End = new DateTime(2017, 1, 2, 18, 10, 0) },
        //    new Downtime { Order = WorkOrders[3], Reason = DowntimeReasons[4], Start = new DateTime(2017, 1, 2, 20, 0, 0), End = new DateTime(2017, 1, 3, 02, 10, 0) },
        //    new Downtime { Order = WorkOrders[3], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 3, 4, 0, 0), End = new DateTime(2017, 1, 3, 4, 30, 0) }
        //};

        public static List<Downtime> Downtimes = new List<Downtime>
        {
            // Order 1001 (1.01.2017 08:00-16:00)
            new Downtime { Order = WorkOrders[0], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 1, 10, 0, 0), End = new DateTime(2017, 1, 1, 10, 10, 0) },
            new Downtime { Order = WorkOrders[0], Reason = DowntimeReasons[0], Start = new DateTime(2017, 1, 1, 10, 30, 0), End = new DateTime(2017, 1, 1, 11, 0, 0) },
            new Downtime { Order = WorkOrders[0], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 1, 12, 0, 0), End = new DateTime(2017, 1, 1, 12, 30, 0) },
            new Downtime { Order = WorkOrders[0], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 1, 14, 0, 0), End = new DateTime(2017, 1, 1, 14, 10, 0) },
            new Downtime { Order = WorkOrders[0], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 1, 15, 0, 0), End = new DateTime(2017, 1, 1, 16, 30, 0) }, // Setup, iş emri 16:00'da bitiyor

            // Order 1002 (1.01.2017 16:00-2.01.2017 00:00)
            new Downtime { Order = WorkOrders[1], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 1, 18, 0, 0), End = new DateTime(2017, 1, 1, 18, 10, 0) },
            new Downtime { Order = WorkOrders[1], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 1, 20, 0, 0), End = new DateTime(2017, 1, 1, 20, 30, 0) },
            new Downtime { Order = WorkOrders[1], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 1, 22, 0, 0), End = new DateTime(2017, 1, 1, 22, 10, 0) },
            new Downtime { Order = WorkOrders[1], Reason = DowntimeReasons[3], Start = new DateTime(2017, 1, 1, 23, 0, 0), End = new DateTime(2017, 1, 2, 8, 30, 0) }, // Arge, iş emri 00:00'da bitiyor

            // Order 1003 (2.01.2017 00:00-08:00) - Bu zaman aralığında duruş yok

            // Order 1004 (1.01.2017 08:00-2.01.2017 16:00) - Setup'un devamı
            new Downtime { Order = WorkOrders[3], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 1, 16, 0, 0), End = new DateTime(2017, 1, 1, 16, 30, 0) }, // Setup devamı
            new Downtime { Order = WorkOrders[3], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 2, 10, 0, 0), End = new DateTime(2017, 1, 2, 10, 10, 0) },
            new Downtime { Order = WorkOrders[3], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 2, 12, 0, 0), End = new DateTime(2017, 1, 2, 12, 30, 0) },
            new Downtime { Order = WorkOrders[3], Reason = DowntimeReasons[0], Start = new DateTime(2017, 1, 2, 13, 0, 0), End = new DateTime(2017, 1, 2, 13, 45, 0) },
            new Downtime { Order = WorkOrders[3], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 2, 14, 0, 0), End = new DateTime(2017, 1, 2, 14, 10, 0) },
            new Downtime { Order = WorkOrders[3], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 2, 18, 0, 0), End = new DateTime(2017, 1, 2, 18, 10, 0) },

            // Order 1005 (1.01.2017 16:00-3.01.2017 00:00) - Arge'nin devamı
            new Downtime { Order = WorkOrders[4], Reason = DowntimeReasons[3], Start = new DateTime(2017, 1, 2, 0, 0, 0), End = new DateTime(2017, 1, 2, 8, 30, 0) }, // Arge devamı
            new Downtime { Order = WorkOrders[4], Reason = DowntimeReasons[3], Start = new DateTime(2017, 1, 2, 20, 0, 0), End = new DateTime(2017, 1, 3, 0, 0, 0) }, // Arge

            // Order 1006 (3.01.2017 00:00-08:00)
            new Downtime { Order = WorkOrders[5], Reason = DowntimeReasons[3], Start = new DateTime(2017, 1, 3, 0, 0, 0), End = new DateTime(2017, 1, 3, 2, 10, 0) }, // Arge devamı
            new Downtime { Order = WorkOrders[5], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 3, 4, 0, 0), End = new DateTime(2017, 1, 3, 4, 30, 0) },
            new Downtime { Order = WorkOrders[5], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 3, 6, 0, 0), End = new DateTime(2017, 1, 3, 8, 0, 0) }, // Setup

            // Order 1007 (3.01.2017 08:00-16:00)
            new Downtime { Order = WorkOrders[6], Reason = DowntimeReasons[2], Start = new DateTime(2017, 1, 3, 8, 0, 0), End = new DateTime(2017, 1, 3, 9, 30, 0) }, // Setup devamı
            new Downtime { Order = WorkOrders[6], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 3, 10, 0, 0), End = new DateTime(2017, 1, 3, 10, 10, 0) },
            new Downtime { Order = WorkOrders[6], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 3, 12, 0, 0), End = new DateTime(2017, 1, 3, 12, 30, 0) },
            new Downtime { Order = WorkOrders[6], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 3, 14, 0, 0), End = new DateTime(2017, 1, 3, 14, 10, 0) },
            new Downtime { Order = WorkOrders[6], Reason = DowntimeReasons[0], Start = new DateTime(2017, 1, 3, 15, 0, 0), End = new DateTime(2017, 1, 3, 16, 0, 0) }, // Arıza, iş emri 16:00'da bitiyor

            // Order 1008 (3.01.2017 16:00-4.01.2017 00:00)
            new Downtime { Order = WorkOrders[7], Reason = DowntimeReasons[0], Start = new DateTime(2017, 1, 3, 16, 0, 0), End = new DateTime(2017, 1, 3, 18, 45, 0) }, // Arıza devamı
            new Downtime { Order = WorkOrders[7], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 3, 20, 0, 0), End = new DateTime(2017, 1, 3, 20, 30, 0) },
            new Downtime { Order = WorkOrders[7], Reason = DowntimeReasons[1], Start = new DateTime(2017, 1, 3, 22, 0, 0), End = new DateTime(2017, 1, 3, 22, 10, 0) }
        };
    }
}
