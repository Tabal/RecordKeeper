﻿public interface IBlock : IDisposable
{
    /// <summary>
    /// Id of the block, must be unique
    /// </summary>
    uint Id { get; }

    /// <summary>
    /// A block may contain one or more header metadata,
    /// each header identified by a number and 8 bytes value.
    /// </summary>
    long GetHeader(int field);

    /// <summary>
    /// Change the value of the specified header.
    /// Data must not be written to disk until the block is disposed
    /// </summary>
    void SetHeader(int field, long value);

    /// <summary>
    /// Read the content of this block (src) into the given buffer (dst)
    /// </summary>
    void Read(byte[] dst, int dstOffset, int srcOffset, int count);

    /// <summary>
    /// Write the content of a given buffer (src) into this (dst)
    /// </summary>
    void Write(byte[] src, int srcOffset, int dstOffset, int count);
}