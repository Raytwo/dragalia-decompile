using System.Runtime.InteropServices;

namespace NexPlugin;

[StructLayout(0, Size = 24)]
public struct DataStoreRatingInfo
{
	private long totalValue;

	private long initialValue;

	private uint count;

	private sbyte slot;

	public sbyte GetSlot()
	{
		return default(sbyte);
	}

	public long GetTotalValue()
	{
		return default(long);
	}

	public uint GetCount()
	{
		return default(uint);
	}

	public long GetInitialValue()
	{
		return default(long);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
