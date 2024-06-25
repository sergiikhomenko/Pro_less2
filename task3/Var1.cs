namespace task3;

/*
 * Декількома способами створіть колекцію, в якій можна зберігати тільки цілі та речові значення,
 * на кшталт «рахунок підприємства – доступна сума» відповідно.
 */
public class Var1
{
    private Dictionary<int, decimal> accountBalances;

    public Var1()
    {
        accountBalances = new Dictionary<int, decimal>();
    }

    public void AddAccount(int accountID, decimal balance)
    {
        accountBalances[accountID] = balance;
    }

    public decimal GetBalance(int accountID)
    {
        if (accountBalances.TryGetValue(accountID, out decimal balance))
        {
            return balance;
        }

        throw new AggregateException("Account ID not found.");
    }
}