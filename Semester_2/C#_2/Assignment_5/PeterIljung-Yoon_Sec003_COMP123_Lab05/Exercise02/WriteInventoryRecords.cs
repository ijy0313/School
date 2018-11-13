using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise02
{
    class WriteInventoryRecords
    {
        static void Main(string[] args)
        {
            const int END = 000;
            const string DELIM = ",";
            const string FILENAME = @"C:\Users\Peter\Desktop\Txt.Files\Inventory.txt";
            Auction auc = new Auction();
            FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            Console.Write("Enter auction number or " + END + " to quit: ");
            auc.AucNum = Convert.ToInt32(Console.ReadLine());
            while (auc.AucNum != END)
            {
                Console.Write("Enter item description: ");
                auc.Description = Console.ReadLine();
                Console.Write("Enter asking price: ");
                auc.AskPrice = Convert.ToDouble(Console.ReadLine());
                writer.WriteLine(auc.AucNum + DELIM + auc.Description + DELIM + auc.AskPrice);
                Console.Write("Enter next auction number or " + END + " to quit: ");
                auc.AucNum = Convert.ToInt32(Console.ReadLine());
            }
            writer.Close();
            outFile.Close();
        }
    }
    class Auction
    {
        public int AucNum { get; set; }
        public string Description { get; set; }
        public double AskPrice { get; set; }
    }
}
