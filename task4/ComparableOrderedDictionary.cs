using System;
using System.Collections;
using System.Collections.Specialized;

public class ComparableOrderedDictionary : OrderedDictionary, IComparable<ComparableOrderedDictionary>, IEquatable<ComparableOrderedDictionary>
{
    public int CompareTo(ComparableOrderedDictionary other)
    {
        if (other == null) return 1;

        var enumerator1 = this.GetEnumerator();
        var enumerator2 = other.GetEnumerator();

        while (enumerator1.MoveNext() && enumerator2.MoveNext())
        {
            var entry1 = (DictionaryEntry)enumerator1.Current;
            var entry2 = (DictionaryEntry)enumerator2.Current;

            var key1 = entry1.Key as IComparable;
            var key2 = entry2.Key as IComparable;

            if (key1 == null || key2 == null)
            {
                throw new InvalidOperationException("Keys повинен бути IComparable.");
            }

            int keyComparison = key1.CompareTo(key2);
            if (keyComparison != 0)
            {
                return keyComparison;
            }

            var value1 = entry1.Value as IComparable;
            var value2 = entry2.Value as IComparable;

            if (value1 == null || value2 == null)
            {
                throw new InvalidOperationException("Values повинен бути IComparable.");
            }

            int valueComparison = value1.CompareTo(value2);
            if (valueComparison != 0)
            {
                return valueComparison;
            }
        }

        return this.Count.CompareTo(other.Count);
    }

    public bool Equals(ComparableOrderedDictionary other)
    {
        if (other == null) return false;
        if (this.Count != other.Count) return false;

        var enumerator1 = this.GetEnumerator();
        var enumerator2 = other.GetEnumerator();

        while (enumerator1.MoveNext() && enumerator2.MoveNext())
        {
            var entry1 = (DictionaryEntry)enumerator1.Current;
            var entry2 = (DictionaryEntry)enumerator2.Current;

            if (!entry1.Key.Equals(entry2.Key) || !entry1.Value.Equals(entry2.Value))
            {
                return false;
            }
        }

        return true;
    }

    public override bool Equals(object obj)
    {
        if (obj is ComparableOrderedDictionary other)
        {
            return Equals(other);
        }

        return false;
    }

    public override int GetHashCode()
    {
        int hash = 17;

        foreach (DictionaryEntry entry in this)
        {
            hash = hash * 31 + (entry.Key?.GetHashCode() ?? 0);
            hash = hash * 31 + (entry.Value?.GetHashCode() ?? 0);
        }

        return hash;
    }

    public static bool operator ==(ComparableOrderedDictionary left, ComparableOrderedDictionary right)
    {
        if (ReferenceEquals(left, right))
        {
            return true;
        }

        if (left is null || right is null)
        {
            return false;
        }

        return left.Equals(right);
    }

    public static bool operator !=(ComparableOrderedDictionary left, ComparableOrderedDictionary right)
    {
        return !(left == right);
    }

    public static bool operator <(ComparableOrderedDictionary left, ComparableOrderedDictionary right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(ComparableOrderedDictionary left, ComparableOrderedDictionary right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >(ComparableOrderedDictionary left, ComparableOrderedDictionary right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(ComparableOrderedDictionary left, ComparableOrderedDictionary right)
    {
        return left.CompareTo(right) >= 0;
    }
}