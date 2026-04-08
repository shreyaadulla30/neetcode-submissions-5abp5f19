public class MyHashSet
{
    private const int BucketSize = 1000;
    private List<int>[] buckets;

    public MyHashSet()
    {
        buckets = new List<int>[BucketSize];
        for (int i = 0; i < BucketSize; i++)
        {
            buckets[i] = new List<int>();
        }
    }

    private int Hash(int key)
    {
        return key % BucketSize;
    }

    public void Add(int key)
    {
        int index = Hash(key);
        if (!buckets[index].Contains(key))
        {
            buckets[index].Add(key);
        }
    }

    public void Remove(int key)
    {
        int index = Hash(key);
        buckets[index].Remove(key);
    }

    public bool Contains(int key)
    {
        int index = Hash(key);
        return buckets[index].Contains(key);
    }
}
