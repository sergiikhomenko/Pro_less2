namespace task3;

public class Var2
{
    private List<( int id, decimal balance) > accountBalances;

    public Var2()
    {
        accountBalances = new List<(int Id, decimal balance)>();
    }

    public void AddAccount(int id,decimal balance)
    {
        accountBalances.Add((id,balance));
    }

    public decimal GetBalace(int id)
    {
        foreach (var balance in accountBalances)
        {
            if (balance.id == id)
            {
                return balance.balance;
            }
        }

        throw new AggregateException("Account ID not found.");
    }
}