using System.Collections.Generic;

namespace NexPlugin;

public class SubscriberUserStatusInfo
{
	internal ulong pid;

	internal Dictionary<byte, List<byte>> values;

	public ulong GetPrincipalID()
	{
		return default(ulong);
	}

	public bool GetValue(byte key, List<byte> value)
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
