using AccountEventDeligate.Models;
using System.Security.Principal;

namespace AccountEventDeligate
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
           Account account1 = new Account() {AccountId=1,AccountName="Akash",AccountBalance=500,};
            account1.AccountBalanceChange += SendSms;
            account1.AccountBalanceChange += SendEmail;
            account1.AccountBalanceChange += (a) =>
            {
                Console.WriteLine($"sending Whatsapp{a.AccountName} of deposited{a.AccountBalance}");
            };
            account1.DepositeAccount(200);
            account1.DepositeAccount(100);
        }
        static void SendSms(Account account)
        {
            Console.WriteLine($"sending sms{account.AccountName} of deposited{account.AccountBalance}");
        }
        static void SendEmail(Account account)
        {
            Console.WriteLine($"sending Email{account.AccountName} of deposited{account.AccountBalance}");
        }
    }
}