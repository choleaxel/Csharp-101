namespace Accounts;

public class BankAccount
{
    public string AccountNumber{ get; set; }
    public string Owner { get; set; }

    public decimal Balance { get; set; }
    public BankAccount() //this is a constructor
    {
        AccountNumber = "My Account";
        Owner = "DDD";
        Balance = decimal.MaxValue;
    }
    
    public BankAccount( string owner, decimal initialBalance)
    {
        Owner = owner;
        Balance = initialBalance;
    }

    public void MakeDeposit(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("What are you doing?!!!!");
        }
        
        this.Balance += amount;   //bc this is under makedeposit calss its saying add makedeposit (class that i'm in) to balance.
    }



    
}
//public is so that this can be used outside the namespace, public, private(only used with it's neighbors)
//can be imported anywhere, protected (certain sets can access, not public)