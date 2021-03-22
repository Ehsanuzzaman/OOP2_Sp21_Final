using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Ehsan", "2356", 55000);
            Account a2 = new Account("Zaman", "9872", 12000);
            a1.showInfo();
            a2.showInfo();
            a1.Withdraw(1000);
            a1.Deposit(12000);
            a1.Transfer(a2, 5000);
            a1.showInfo();
            a2.showInfo();
            Transaction t1 = new Transaction(a1, a2, 6000, "Business perpose");
            t1.showInfo();
        }
    }
}