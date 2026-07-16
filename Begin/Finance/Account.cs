using System.Net.NetworkInformation;

namespace Finance
{
    public class Account
    {
        private string holder;
        private decimal balance;
        private string accNo;
        public Account(string name, decimal balance)
        {
            holder = name;
            this.balance = balance;
            accNo = "SA-" + (++nxtAccNo).ToString().PadLeft(4, '0');
        }
        //private int nxtAccNo; // defaults to 0
        private static int nxtAccNo; // defaults to 0 and is shared
        public string GetDetails()
        {
            return $"{accNo}\t{holder}\t{balance}";
        }
        public void Deposit(decimal amt)
        {
            balance += amt;
        }
        public bool Withdraw(decimal amt)
        {
            bool result = false;
            if (amt <= balance)
            {
                result = true;
                balance -= amt; //change the balance   
            }
            else if (amt - balance <= overdraftLimit)
            {
                result = true;
                balance = 0;
                overdraftLimit = overdraftLimit - (amt - balance);
            }
                return result; // just to make it compile
        }
        public static Decimal overdraftLimit = 500;
    }
}
