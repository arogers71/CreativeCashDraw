using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativeCashDraw.Model;
using System.Collections.ObjectModel;
using System.IO;


namespace CreativeCashDraw.Helper
{
    public class FileLoader
    {
        private static FileLoader instance;
        private FileLoader(){}

        public static FileLoader Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FileLoader();
                }
                return instance;
            }
        }

        public ObservableCollection<Transaction> LoadCashFile(string inputPath)
        {
            ObservableCollection<Transaction> transactions = new ObservableCollection<Transaction>();



            //ASR 12/12/2014    Read the text file.
            string[] lines = File.ReadAllLines(inputPath);
            string[][] lineArray = lines.Select(line => line.Split(',').ToArray()).ToArray();


            //ASR 12/12/2014    Load the results into a collection of transactions.
            for (int i=0; i<lineArray.Count(); i++)
            {
                //ASR 12/12/2014    Load each line into a transaction object.
                Transaction transaction = new Transaction();
                transaction.AmountOwed = Convert.ToDecimal(lineArray[i][0]);
                transaction.AmountPaid = Convert.ToDecimal(lineArray[i][1]);



                //ASR 12/12/2014    Add each transaction to the transaction collection.
                transactions.Add(transaction);
            }



            //ASR 12/12/2014    Return the completed collection of transactions.
            return  transactions;
        }
    }
}
