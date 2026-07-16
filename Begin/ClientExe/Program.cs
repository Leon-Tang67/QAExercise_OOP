using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Finance;


namespace ClientExe {
  class Program {
    static void Main(string[] args) {
            //Finance.Account account = new Finance.Account();
            //Account ac1 = new Account();
            //Account ac2 = new Account();
            //Console.WriteLine(ac1 == ac2);
            Account ac1, ac2;
            ac1 = new Account("Fred", 100);
            ac2 = new Account("Susy", 200);
            Console.WriteLine(ac1.GetDetails());
            Console.WriteLine(ac2.GetDetails());
            ac1.Deposit(100);
            ac2.Withdraw(200);
            Console.WriteLine(ac1.GetDetails());
            Console.WriteLine(ac2.GetDetails());
        }
  }
}
