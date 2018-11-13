using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise03
{
    class ReadInventoryRecords
    {
        static void Main(string[] args)
        {
            const char DELIM = ',';
            const string FILENAME = @"C:\Users\Peter\Desktop\Txt.Files\Inventory.txt";
            Auction auc = new Auction();
            try
            {
                FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);
                string recordIn;
                string[] fields;
                Console.WriteLine("\n{0,0}{1,13}{2,13}\n", "Item#", "Description", "Ask Price");
                recordIn = reader.ReadLine();
                while (recordIn != null)
                {
                    fields = recordIn.Split(DELIM);
                    auc.AucNum = Convert.ToInt32(fields[0]);
                    auc.Description = fields[1];
                    auc.AskPrice = Convert.ToDouble(fields[2]);
                    //double sum = emp.Salary++;
                    //double average = 
                    Console.WriteLine("{0,0}{1,12}{2,14}", auc.AucNum, auc.Description, auc.AskPrice.ToString("C"));
                    recordIn = reader.ReadLine();
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
    class Auction
    {
        public int AucNum { get; set; }
        public string Description { get; set; }
        public double AskPrice { get; set; }
    }
}
