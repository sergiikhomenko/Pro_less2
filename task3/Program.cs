namespace task3;

/*
 * Декількома способами створіть колекцію, в якій можна зберігати тільки цілі та речові значення,
 * на кшталт «рахунок підприємства – доступна сума» відповідно.
 */
class Program
{
    static void Main(string[] args)
    {
        Var1 accounts = new Var1();
        accounts.AddAccount(1, 1000.50m);
        accounts.AddAccount(2, 2500.00m);

        Console.WriteLine("Balance for account 1: " + accounts.GetBalance(1));
        Console.WriteLine("Balance for account 2: " + accounts.GetBalance(2));

        Var2 accounts2 = new Var2();
        accounts2.AddAccount(3,300.05m);
        accounts2.AddAccount(5,30450.05m);
        
        Console.WriteLine("Balance for account  Var2: " + accounts2.GetBalace(5));
    }
}