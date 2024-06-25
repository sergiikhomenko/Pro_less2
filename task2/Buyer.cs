namespace task2;
/*
 * Створіть колекцію, до якої можна додавати покупців та категорію придбаної
 * ними продукції. З колекції можна отримувати категорії товарів, які купив
 * покупець або за категорією визначити покупців.
 */

public class PurchaseCollection
{
 private Dictionary<string, HashSet<string>> customerToCategories;
 private Dictionary<string, HashSet<string>> categoryToCustomers;

 public PurchaseCollection()
 {
   customerToCategories = new Dictionary<string, HashSet<string>>();
   categoryToCustomers = new Dictionary<string, HashSet<string>>();
 }

 public void AddPurchase(string customer, string category)
 {
  if (!customerToCategories.ContainsKey(customer))
  {
   customerToCategories[customer] = new HashSet<string>();
  }
  customerToCategories[customer].Add(customer);
  
  
  if (!categoryToCustomers.ContainsKey(category))
  {
   categoryToCustomers[category] = new HashSet<string>();
  }

   categoryToCustomers[category].Add(category);
 }

 public HashSet<string> GetCategoriesByCustomer(string customer)
 { 
  if (customerToCategories.TryGetValue(customer, out var categories))
  {
   return categories;
  }
  return new HashSet<string>();
 }

 public HashSet<string> GetCustomerToCategories(string category)
 {
  if (categoryToCustomers.TryGetValue(category, out var customers))
  {
   return customers;
  }

  return new HashSet<string>();
 }
}