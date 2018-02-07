namespace Classes_Part_1
{
    using System;

    class GSMTest
    {
        private static GSM GalaxyA5 = new GSM("Galaxy A5", "Samsung", 380.00M, "Pesho", 8, 3.00, 32, 0, "Non-Removable", 90, 16, 5.2, 16000000);

        private static GSM MotoZ = new GSM("Z", "Moto", 670.00M, "Dave", 8, 4, 32, 1, "Turbo-Charging", 60, 15, 5.5, 16000000);


        private static GSM iPhoneX = new GSM("iPhone X", "Apple", 999.99M, "Steve", 6, 3, 64, 1, "Non-Removable", 90, 21, 5.8, 16000000);

        private static GSM[] testArray = new GSM[] { GalaxyA5, MotoZ, iPhoneX };

        public static void GSMArray(int N)
        {
            Console.WriteLine(testArray[N].ToString());

            Console.WriteLine(GSM.iPhone4S.ToString());
        }
    }
}
