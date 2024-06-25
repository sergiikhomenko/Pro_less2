
class Program
{
    static void Main()
    {
        // Створюємо і заповнюємо ComparableOrderedDictionary
        var dict1 = new ComparableOrderedDictionary();
        dict1.Add("key1", 10);
        dict1.Add("key2", 20);
        dict1.Add("key3", 30);

        var dict2 = new ComparableOrderedDictionary();
        dict2.Add("key1", 10);
        dict2.Add("key2", 20);
        dict2.Add("key3", 30);

        var dict3 = new ComparableOrderedDictionary();
        dict3.Add("key1", 10);
        dict3.Add("key2", 20);
        dict3.Add("key3", 40);

        // Порівняння за значеннями
        Console.WriteLine("dict1 equals dict2: " + dict1.Equals(dict2)); // true
        Console.WriteLine("dict1 equals dict3: " + dict1.Equals(dict3)); // false

        // Порівняння за ключами і значеннями
        Console.WriteLine("dict1.CompareTo(dict2): " + dict1.CompareTo(dict2)); // 0 (рівні)
        Console.WriteLine("dict1.CompareTo(dict3): " + dict1.CompareTo(dict3)); // -1 (менше)

        // Використання операторів порівняння
        Console.WriteLine("dict1 == dict2: " + (dict1 == dict2)); // true
        Console.WriteLine("dict1 != dict3: " + (dict1 != dict3)); // true
        Console.WriteLine("dict1 < dict3: " + (dict1 < dict3));   // true

        // Перевірка GetHashCode
        Console.WriteLine("dict1.GetHashCode(): " + dict1.GetHashCode());
        Console.WriteLine("dict2.GetHashCode(): " + dict2.GetHashCode());
        Console.WriteLine("dict3.GetHashCode(): " + dict3.GetHashCode());
    }
}