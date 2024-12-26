namespace RecordKeeper.Core
{
    public class BlockStorage : IBLockStorage
    {
        readonly Stream stream;
        readonly int blockSize;
        readonly int blockHeaderSize;
        readonly int blockContentSize;
        readonly int unitOfWork;
        readonly Dictionary<uint, Block> blocks = new Dictionary<uint, Block>();

        public int DiskSectorSize {  get {  return blockSize; } }
        public int BlockSize {  get { return blockSize; } }
        public int BlockSizeHeader {  get {  return blockHeaderSize; } }
        public int BlockContentSize { get { return blockContentSize; } }

        public BlockStorage(Stream stream, int blockContentSize, int blockHeaderSize, int blockSize)
        {
            this.stream = stream;
            this.blockContentSize = blockContentSize;
            this.blockHeaderSize = blockHeaderSize;
            this.blockSize = blockSize;
        }

        public IBlock CreateNew()
        {
            throw new NotImplementedException();
        }

        public IBlock Find(uint blockId)
        {
            throw new NotImplementedException();
        }
    }
}
