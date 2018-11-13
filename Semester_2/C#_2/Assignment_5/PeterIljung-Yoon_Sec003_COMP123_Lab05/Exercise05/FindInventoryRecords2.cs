using System;
using System.IO;
class FindInventoryRecords2
{
    static void Main()
    {
        const char DELIM = ',';
        const int END = 000;
        const string FILENAME = @"C:\Users\Peter\Desktop\Txt.Files\Inventory.txt";
        Auction auc = new Auction();
        FileStream inFile = new FileStream(FILENAME,
        FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);
        string recordIn;
        string[] fields;
        double minAskPrice;
        Console.Write("Enter minimum selling price to find or " + END + " to quit: ");
        minAskPrice = Convert.ToDouble(Console.ReadLine());
        while (minAskPrice != END)
        {
            Console.WriteLine("\n{0,0}{1,13}{2,13}\n",
               "Num", "Description", "Ask Price");
            inFile.Seek(0, SeekOrigin.Begin);
            recordIn = reader.ReadLine();
            while (recordIn != null)
            {
                fields = recordIn.Split(DELIM);
                auc.AucNum = Convert.ToInt32(fields[0]);
                auc.Description = fields[1];
                auc.AskPrice = Convert.ToDouble(fields[2]);
                if (auc.AskPrice >= minAskPrice)
                    Console.WriteLine("{0,0}{1,13}{2,13}",
                       auc.AucNum, auc.Description,
                          auc.AskPrice.ToString("C"));
                recordIn = reader.ReadLine();
            }
            Console.Write("\nEnter minimum selling price to find or " + END + " to quit >> ");
            minAskPrice = Convert.ToDouble(Console.ReadLine());
        }
        reader.Close();  // Error occurs if
        inFile.Close(); //these two statements are reversed
    }
}
class Auction
{
    public int AucNum { get; set; }
    public string Description { get; set; }
    public double AskPrice { get; set; }
}