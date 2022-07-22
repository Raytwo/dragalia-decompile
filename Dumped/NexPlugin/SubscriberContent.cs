using System.Collections.Generic;

namespace NexPlugin;

public class SubscriberContent
{
	internal ulong contentId;

	internal ulong pid;

	internal NpDateTime postTime;

	internal List<uint> topics;

	internal List<byte> binary;

	internal string message;

	public ulong GetContentId()
	{
		return default(ulong);
	}

	public string GetMessage()
	{
		return null;
	}

	public List<byte> GetBinary()
	{
		return null;
	}

	public ulong GetPosterPrincipalId()
	{
		return default(ulong);
	}

	public List<uint> GetTopic()
	{
		return null;
	}

	public uint GetTopicSingle()
	{
		return default(uint);
	}

	public NpDateTime GetPostDateTime()
	{
		return default(NpDateTime);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
