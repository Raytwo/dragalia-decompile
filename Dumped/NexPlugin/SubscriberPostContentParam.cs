using System.Collections.Generic;

namespace NexPlugin;

public class SubscriberPostContentParam
{
	internal List<uint> topics;

	internal List<byte> binary;

	internal string message;

	public void SetTopic(List<uint> topics_)
	{
	}

	public void SetTopic(uint topic_)
	{
	}

	public List<uint> GetTopic()
	{
		return null;
	}

	public uint GetTopicSingle()
	{
		return default(uint);
	}

	public void SetMessage(string message_)
	{
	}

	public string GetMessage()
	{
		return null;
	}

	public void SetBinary(List<byte> binary_)
	{
	}

	public List<byte> GetBinary()
	{
		return null;
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
