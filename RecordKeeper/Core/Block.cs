using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeper.Core
{
    public class Block : IBlock
    {
        readonly byte[] firstSector;
        readonly long?[] cachedHeaderValue = new long?[5];
        readonly Stream stream;
        readonly BlockStorage storage;
        readonly uint id;
    }
}
