namespace task6;
/*
 * Використовуючи клас SortedList, створіть невелику колекцію та виведіть на екран
 * значення пар «ключ-значення» спочатку в алфавітному порядку, а потім у зворотному.
 */
class Program
{
    static void Main(string[] args)
    {
        SortedList<string, string> sortedList = new SortedList<string, string>();
        sortedList.Add("C","Cat");
        sortedList.Add("D", "Book");
        sortedList.Add("A","Apple");

        var list = sortedList.OrderBy(x => x.Key);
        Console.WriteLine("Сортування за алфавітом");
        foreach (var item in  list)
        {
            Console.WriteLine(item);
        }
        
        var list1 = sortedList.OrderByDescending(x => x.Key);
        Console.WriteLine("Сортування у зворотному");
        foreach (var item in  list1)
        {
            Console.WriteLine(item);
        }
        
    }
}