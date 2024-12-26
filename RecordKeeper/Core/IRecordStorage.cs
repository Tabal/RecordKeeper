//To support variable length data, you use a record.
//A record can be one or multiple blocks.
//It's basically just a linked list of blocks.
public interface IRecordStorage
{
    /// <summary>
    /// Effectively update a record
    /// </summary>
    void Update(uint recordId, byte[] data);

    /// <summary>
    /// Get a record's data
    /// </summary>
    byte[] Find(uint recordId);

    /// <summary>
    /// This creates a new empty record
    /// </summary>
    uint Create();

    /// <summary>
    /// This creates a new record with given data and returns its ID
    /// </summary>
    uint Create(byte[] data);

    /// <summary>
    /// Similar to Create(byte[] data), but with a dataGenerator that generates
    /// data after a record is allocated
    /// </summary>
    //Func<uint, byte[]> means the first argument is a function
    //That function has 1 argument, and returns a byte array.
    uint Create(Func<uint, byte[]> dataGenerator);

    //Deletes a record by its ID
    uint Delete(uint recordId);
}