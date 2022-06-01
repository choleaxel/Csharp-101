namespace Accounts;

public class SavingAccount: BankAccount
{
    public decimal InterestRate { get; set; }
    
    public void AddMonthlyInterest()
    {
        Balance += Balance * InterestRate;  
    }
}