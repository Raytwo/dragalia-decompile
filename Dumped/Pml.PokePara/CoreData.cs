namespace Pml.PokePara;

public struct CoreData
{
	public const int SIZE = 328;

	public const int CORE_DATA_BLOCK_SIZE = 80;

	public CoreDataHeader header;

	public _003Cblocks_003Ee__FixedBuffer blocks;
}
