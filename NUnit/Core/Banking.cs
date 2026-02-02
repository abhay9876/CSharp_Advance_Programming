/*Testing Banking Transactions
Problem:
Create a BankAccount class with:
● Deposit(double amount): Adds money to the balance.
● Withdraw(double amount): Reduces balance.
● GetBalance(): Returns the current balance.
Write unit tests to check correct balance updates.
Ensure withdrawals fail if funds are insufficient.     */


public class BankAccount
{
    private double _balance;

    public BankAccount(double balance)
    {
        _balance = balance;
    }

    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (amount > _balance)
            return false;

        _balance -= amount;
        return true;
    }

    public double GetBalance()
    {
        return _balance;
    }
}
