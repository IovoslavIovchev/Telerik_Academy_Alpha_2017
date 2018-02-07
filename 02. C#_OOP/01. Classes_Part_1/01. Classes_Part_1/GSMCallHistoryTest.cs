namespace Classes_Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    static class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            GSM test = new GSM("iPhone X", "Apple", 999.99M, "Steve", 6, 3, 64, 1, "Non-Removable", 90, 21, 5.8, 16000000);

            test.AddCall("0891111111", 150, "02-06-2017", "12:33:12");

            test.AddCall("0891351111", 50, "12-11-2017", "15:43:02");

            foreach (Call c in test.CallHistory)
            {
                Console.WriteLine($"A call to {c.DialedNumber} was made on {c.Date} {c.Time} by {test.Owner}'s {test.Manufacturer} {test.Model}");
            }

            Console.WriteLine(test.CallPrice(0.37M));

            test.ClearCallHistory();

            foreach (Call c in test.CallHistory)
            {
                Console.WriteLine($"A call to {c.DialedNumber} was made on {c.Date} {c.Time} by {test.Owner}'s {test.Manufacturer} {test.Model}");
            }

            Console.WriteLine(test.CallPrice(0.37M));
        }
    }
}
