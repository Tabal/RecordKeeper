public interface IIndex<K, V>
{
    /// <summary>
    /// Create a new entry in this index that maps the key K to value V
    /// </summary>
    void Insert(K key, ValueTask value);

    /// <summary>
    /// Find an entry by its key
    /// </summary>
    Tuple<K, V> Get(K key);

    /// <summary>
    /// Find all entries that contain a key that is larger than or equal to a specified key
    /// </summary>
    IEnumerable<Tuple<K, V>> LargerThanOrEqualTo(K key);

    /// <summary>
    /// Find all entries that contain a key larger than a specified key
    /// </summary>
    IEnumerable<Tuple<K, V>> LargerThan(K key);

    /// <summary>
    /// Find all entries that contain a key that is less than or equal to a specified key
    /// </summary>
    IEnumerable<Tuple<K, V>> LessThanOrEqualTo(K key);

    /// <summary>
    /// Find all entries that ocntain a key that is less than a specified key
    /// </summary>
    IEnumerable<Tuple<K, V>> LessThan(K key);

    /// <summary>
    /// Delete an entry from this index, can also use IComparer to compare values
    /// </summary>
    bool Delete(K key, V value, IComparer<V> valueComparer = null);

    /// <summary>
    /// Delete all entries of a given key
    /// </summary>
    bool Delete(K key);
}
