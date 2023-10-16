using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventDeligate.Models
{
    //delegate void DBalanceChange(Account account);
    internal class Account
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public double AccountBalance { get; set; }

        public event Action<Account> AccountBalanceChange;

        public void DepositeAccount(double accountBalance)
        {
            AccountBalance += accountBalance;
            if (AccountBalanceChange != null)
                AccountBalanceChange(this);
        }

    }
}
