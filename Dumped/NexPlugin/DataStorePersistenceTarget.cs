namespace NexPlugin;

public class DataStorePersistenceTarget
{
	internal ulong ownerId;

	internal ushort persistenceSlotId;

	public DataStorePersistenceTarget(ulong ownerId = 0uL, ushort persistenceSlotId = ushort.MaxValue)
	{
	}

	public void SetOwnerId(ulong ownerId_)
	{
	}

	public ulong GetOwnerId()
	{
		return default(ulong);
	}

	public void SetPersistenceSlotId(ushort persistenceSlotId_)
	{
	}

	public ushort GetPersistenceSlotId()
	{
		return default(ushort);
	}

	public void Reset()
	{
	}

	public override bool Equals(object obj)
	{
		return default(bool);
	}

	public override int GetHashCode()
	{
		return default(int);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
