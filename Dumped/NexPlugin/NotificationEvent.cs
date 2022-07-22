namespace NexPlugin;

public class NotificationEvent
{
	internal ulong param1;

	internal ulong param2;

	internal Common.NotificationEvents type;

	internal uint subType;

	internal string stringParam;

	internal ulong pid;

	public ulong GetSource()
	{
		return default(ulong);
	}

	public new Common.NotificationEvents GetType()
	{
		return default(Common.NotificationEvents);
	}

	public uint GetSubType()
	{
		return default(uint);
	}

	public ulong GetParam1()
	{
		return default(ulong);
	}

	public ulong GetParam2()
	{
		return default(ulong);
	}

	public string GetStringParam()
	{
		return null;
	}

	public void Trace()
	{
	}

	internal new string ToString()
	{
		return null;
	}
}
