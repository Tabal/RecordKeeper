﻿public interface IBLockStorage
{
    /// <summary>
    /// Number of bytes of custom data per block that this storage can handle
    /// </summary>
    int BlockContentSize { get; }

    /// <summary>
    /// Total number of bytes in header
    /// </summary>
    int BlockSizeHeader { get; }

    /// <summary>
    /// Total block size, equal to content size + header size, should be a multiple of 128B
    /// </summary>
    int BlockSize { get; }

    /// <summary>
    /// Find a block by its id
    /// </summary>
    IBlock Find(uint blockId);

    /// <summary>
    /// Allocate a new block, extend the length of underlying storage
    /// </summary>
    /// <returns></returns>
    IBlock CreateNew();
}