using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CreativeCashDraw.Model;
using CreativeCashDraw.Helper;


namespace CreativeCashDraw.Controllers
{
    class CashDraw
    {

        static Random _random = new Random();
        public ObservableCollection<Transaction> transactions { get; set; }
        private string _inputFile = string.Empty;
        private string _outputPath = string.Empty;


        #region Constructors
        public CashDraw(string inputFile, string outputFile)
        {
            _inputFile = inputFile;
            _outputPath = outputFile;
        }


        public CashDraw()
        {}
        #endregion



        /// <summary>
        /// Index is the main controller for the application.
        /// </summary>
        public void Index()
        {
            try
            {
                StringBuilder outputText = new StringBuilder();

                

                //ASR 12/10/2014    Load data file.
                transactions = FileLoader.Instance.LoadCashFile(_inputFile);


               
                //ASR 12/8/2014     Loop through inputs.
                foreach (Transaction transaction in transactions)
                { 
                    //ASR 12/8/2014     Calculate difference, determine denominations to use, and create output string. 
                    outputText.AppendLine(DenominationsToUse(transaction.AmountPaid - transaction.AmountOwed,100*transaction.AmountOwed % 3 ==0));
                }


                //ASR Write Output file.
                WriteOutput.Instance.WriteOutputFile(_outputPath, outputText.ToString());
            }
            catch (Exception ex)
            {
                //ASR 12/8/2014     Write error message to ouput file.  In a larger system, a call to a global error log would be made here.
                WriteOutput.Instance.WriteOutputFile(_outputPath, ex.Message);
            }
        }



        private string DenominationsToUse(decimal targetValue, bool random)
        {
            string returnString = string.Empty;
            var denominations = new[]{
                    new {pluralname = "hundreds",singularname = "hundred", value = 100m},
                    new {pluralname = "fifties", singularname = "fifty",value = 20m},
                    new {pluralname = "twenties", singularname = "twenty", value = 20m},
                    new {pluralname = "tens", singularname = "ten",value = 10m},
                    new {pluralname = "fives", singularname = "five",value = 5m},
                    new {pluralname = "dollars", singularname = "dollar",value = 1m},
                    new {pluralname = "quarters",singularname = "quarter", value = .25m},
                    new {pluralname = "dimes", singularname = "dime",value = .1m},
                    new {pluralname = "nickels", singularname = "nickel",value = .05m},
                    new {pluralname = "pennies", singularname = "penny", value = .01m}
            };

            


            StringBuilder change = new StringBuilder();
            decimal remainingValue = targetValue;



            //ASR 12/10/2014    Shuffle the denominations to randomize output.  This is done if the amount owed is divisible by 3.
            if(random)
            {
                denominations = ShuffleDenominations(denominations);
            }



            //ASR 12/10/2014    Calculate the denominations of change to give and build output string.
            foreach (var denomination in denominations )
            {
                int coinCounter = (int)(remainingValue / denomination.value);
                remainingValue -= coinCounter * denomination.value;

                if (coinCounter>1)
                    change.AppendFormat("{0} {1}, ", coinCounter, denomination.pluralname);
                else if (coinCounter==1)  //ASR 12/12/2014  Skip any coin counts of zero.
                    change.AppendFormat("{0} {1}, ", coinCounter, denomination.singularname);
            }

            //ASR 12/12/2014    Remove last comma in string.
            returnString = change.ToString();
            int index = returnString.LastIndexOf(',');
            returnString = returnString.Remove(index);



            return returnString;
        }
        

        /// <summary>
        /// Shuffle the list of denominations using the Fisher-Yates method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        private T[]  ShuffleDenominations<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i<n;i++)
            {
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }

            return array;
        }

    }
}
