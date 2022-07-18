using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Account
    {
        // 속성
        public string bank;
        public string id;
        public string name;
        public int balance;

        // 기능
        public void Deposit(int money) 
        {
            this.balance += money;
        }
        public void Withdraw(int money) 
        {
            this.balance -= money;        
        }
        public void Show() 
        {
            Console.WriteLine("==================");
            Console.WriteLine("은행명 : " + bank);
            Console.WriteLine("계좌번호 : " + id);
            Console.WriteLine("입금주 : " + name);
            Console.WriteLine("현재잔액 : " + balance);
            Console.WriteLine("------------------");
        }
    }
}
