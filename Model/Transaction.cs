using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCashDraw.Model
{
    public class Transaction
    {
        decimal _AmountOwed;
        decimal _AmountPaid;


        public decimal AmountOwed
        {
            get
            {
                return _AmountOwed;
            }

            set
            {
                _AmountOwed = value;
            }
        }


        public decimal AmountPaid
        {
            get
            {
                return _AmountPaid;
            }

            set
            {
                _AmountPaid = value;
            }
        }

    }
}
