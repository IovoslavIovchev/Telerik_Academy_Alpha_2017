using System;
using System.Text;

namespace Malko_Kote
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            StringBuilder kote = new StringBuilder();

            int ratio = (s - 6) / 4;

            kote.Append(" " + c + new string(' ', ratio) + c + Environment.NewLine);

            for (int i = 0; i < ratio; i++)
                kote.Append(" " + new string(c, ratio + 2) + Environment.NewLine);

            for (int i = 0; i < ratio; i++)
                kote.Append("  " + new string(c, ratio) + Environment.NewLine); 

            for (int i = 0; i < ratio; i++)
                kote.Append(" " + new string(c, ratio + 2) + Environment.NewLine);

            kote.Append(" " + new string(c, ratio + 2) + "   " + new string(c, ratio + 1) + Environment.NewLine);

            for (int i = 0; i < ratio + 2; i++)
                kote.Append(new string(c, (s + 10) / 4) + "  " + c + Environment.NewLine);

            kote.Append(new string(c, (s + 10) / 4) + " " + new string(c, 2) + Environment.NewLine);
            
            kote.Append(" " + new string(c, ratio + 5) + Environment.NewLine);

            Console.WriteLine(kote);
        }
    }
}
