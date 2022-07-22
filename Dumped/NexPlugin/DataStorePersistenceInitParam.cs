namespace NexPlugin;

public class DataStorePersistenceInitParam
{
	internal ushort persistenceSlotId;

	internal bool deleteLastObject;

	public DataStorePersistenceInitParam(ushort persistenceSlotId = ushort.MaxValue, bool deleteLastObject = true)
	{
	}

	public void SetPersistenceSlotId(ushort persistenceSlotId_)
	{
	}

	public ushort GetPersistenceSlotId()
	{
		return default(ushort);
	}

	public void SetDeleteLastObject(bool deleteLastObject_)
	{
	}

	public bool GetDeleteLastObject()
	{
		return default(bool);
	}

	public void Reset()
	{
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
