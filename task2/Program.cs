namespace task2;
/*
 * Створіть колекцію, до якої можна додавати покупців та категорію придбаної
 * ними продукції. З колекції можна отримувати категорії товарів, які купив
 * покупець або за категорією визначити покупців.
 */
class Program
{
    static void Main(string[] args)
    {
        PurchaseCollection pc = new PurchaseCollection();
        pc.AddPurchase("John Doe", "Electronics");
        pc.AddPurchase("John Doe", "Books");
        pc.AddPurchase("Jane Smith", "Electronics");
        pc.AddPurchase("Jane Smith", "Clothing");

        Console.WriteLine("Categories purchased by John Doe: " + string.Join(", ", pc.GetCategoriesByCustomer("John Doe")));
        Console.WriteLine("Customers who purchased Electronics: " + string.Join(", ", pc.GetCustomerToCategories("Electronics")));
    }
}