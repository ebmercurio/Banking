using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    internal class Account {

        private static int NextId = 1;  //static because it only needs to start at 1 once, then increase
        //Properties Below
        public int AcctNbr { get; private set; } = 0;  //public to read, private to set the values
        public string Name { get; set; } = string.Empty;  //An Account needs a Name
        public decimal Balance { get; private set; } = 0;  // An Account needs a Balance. Cant changeunless in Account class

        //Methods Below
        public bool Deposit(decimal Amount) {      //Creating a Deposit method(action). Can Deposit decimal amount
            if (Amount <= 0) {
                Console.WriteLine("Amount must be greater than 0");     //To deposit money, it must be greater than 0
                return false;                                       //if amount is less than 0, return
            }
            Balance = Balance + Amount;  //This shows the balance amount after depositing
            return true;
        }
        public bool Withdraw(decimal Amount) {      //Creating a Withdraw method(action). 
            if (Amount <= 0) {                  //To Withdraw money, it must be more than 0
                Console.WriteLine("Amount must be greater than 0");   
                return false;
            }
                if (Amount > Balance) {
                Console.WriteLine("Insufficent Funds");     // if it is more than the balance amount, 
                return false;                               // Display Insufficent funds and return false
            }
            Balance = Balance - Amount;                     //if all is good-- execute and pull money from
            return true;
        }

        public bool Transfer(decimal Amount, Account ToAccount) {  // Creating a Transfer method(action)
            var Success = (Withdraw(Amount));           //creating a Variable to declare if the amount will draw
            if (Success) {                              // do the withdraw, and if it is successful, do the next line
                ToAccount.Deposit(Amount);              //take the withdraw amount, and deposit it to ToAccount account
                return true;
            }
            return false;
        }

        public Account() {
            AcctNbr = NextId++;
        }
    }
}
