using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay08.Problem6
{
    internal struct Account
    {
        private int AccountId;
        private string AccountHolder;
        private double Balance;


        // Public properties
        public int Id
        {
            get { return AccountId; }
            set { AccountId = value; }
        }

        public string Holder
        {
            get { return AccountHolder; }
            set { AccountHolder = value; }
        }

        public double AccountBalance
        {
            get { return Balance; }
            set { Balance = value; }
        }


    }
}
