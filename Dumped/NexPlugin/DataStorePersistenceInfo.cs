namespace NexPlugin;

public class DataStorePersistenceInfo
{
	internal ulong dataId;

	internal ulong principalId;

	internal ushort persistenceSlotId;

	public ulong GetPrincipalId()
	{
		return default(ulong);
	}

	public ushort GetPersistenceSlotId()
	{
		return default(ushort);
	}

	public ulong GetDataId()
	{
		return default(ulong);
	}

	public bool IsValid()
	{
		return default(bool);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
