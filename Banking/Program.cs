using Banking;

var sav1 = new Savings();
sav1.Name = "My Savings";

sav1.Deposit(100);
sav1.PayInterest(8);
Console.WriteLine($"The balance is {sav1.Balance:c}") ;



/*
var acct1 = new Account() {           // Creating a new instance of a class
    Name = "Checking 1"               //Naming the 'Account Checking 1'
};
var acct2 = new Account() {            //Creating 2nd account
    Name = "Checking 2"                //Naming it Checking 2
};



acct1.Deposit(1000);                   //Depositing 1k into Acct1
acct2.Deposit(500);                    //Depositing 500 into Acct2

acct1.Withdraw(200);                    //Withdrawing 200 from Acct1
acct2.Withdraw(50);                     //Withdrawing 50 from Acct2

Console.WriteLine($"Acct1 Balance is {acct1.Balance:c}. Acct2 Balance is {acct2.Balance:c}.");  //to reference the 
                                                                                                //:c makes it currency
acct1.Withdraw(1000);

Console.WriteLine($"Acct1 Balance is {acct1.Balance:c}. Acct2 Balance is {acct2.Balance:c}."); //tried to withdraw more money than acct has.
                                                                                               // came back insufficent funds and canceled
acct2.Transfer(100, acct1);

Console.WriteLine($"Acct1 Balance is {acct1.Balance:c}. Acct2 Balance is {acct2.Balance:c}."); //transferred 100 from acct2 -> acct1

acct1.Deposit(-100);

Console.WriteLine($"Acct1 Balance is {acct1.Balance:c}. Acct2 Balance is {acct2.Balance:c}."); 
*/