public class MyHashMap
{
    private const int SIZE = 1000; // number of buckets
    private List<(int key, int value)>[] buckets;

    public MyHashMap()
    {
        buckets = new List<(int, int)>[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            buckets[i] = new List<(int, int)>();
        }
    }

    private int Hash(int key)
    {
        return key % SIZE;
    }

    public void Put(int key, int value)
    {
        int index = Hash(key);
        var bucket = buckets[index];

        for (int i = 0; i < bucket.Count; i++)
        {
            if (bucket[i].key == key)
            {
                bucket[i] = (key, value); // update
                return;
            }
        }

        bucket.Add((key, value)); // insert
    }

    public int Get(int key)
    {
        int index = Hash(key);
        var bucket = buckets[index];

        foreach (var pair in bucket)
        {
            if (pair.key == key)
            {
                return pair.value;
            }
        }

        return -1;
    }

    public void Remove(int key)
    {
        int index = Hash(key);
        var bucket = buckets[index];

        for (int i = 0; i < bucket.Count; i++)
        {
            if (bucket[i].key == key)
            {
                bucket.RemoveAt(i);
                return;
            }
        }
    }
}